using DevExpress.ExpressApp;
using DevExpress.Xpo;
using QuickBooksSync.Module.BusinessObjects;
using System;
using System.ComponentModel;
using System.Data.CData.QuickBooks;
using System.Diagnostics;
using System.Linq;
using XafWinBackgroundWorker.Module.BusinessObjects;

namespace QuickBooksSync.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.

    public class SyncHelper
    {
        int RunningWorkers;
        DateTime StartTime;
        int Pages = 0;
        int CurrentPage = 0;
        Dictionary<string, KeyValuePair<BackgroundWorker, object>> Workers = new Dictionary<string, KeyValuePair<BackgroundWorker, object>>();
        int pages;
        Company currentCompany;
        IObjectSpace ObjectSpace;
        Action OnFinish;
        Dictionary<Type, string> Entities;
        Dictionary<Type, string> EntityQueryParamters;
        Action<XPBaseObject> AfterSetValues;
        public SyncHelper(Company Company , Dictionary<Type, string> entities, IObjectSpace objectSpace,Action onFinish, Dictionary<Type, string> entityQueryParamters,Action<XPBaseObject> afterSetValues=null)
        {
            currentCompany = Company;
            ObjectSpace = objectSpace;
            OnFinish = onFinish;
            Entities = entities;
            EntityQueryParamters = entityQueryParamters;
            AfterSetValues = afterSetValues;
        }
        public string Log { get; set; }
        public void Sync()
        {
            RunningWorkers = 0;
            StartTime = DateTime.Now;

            
            //HACK tables list
          
            Dictionary<Type, string> Entities = GetEntities();


          
            Workers.Clear();
            foreach (var entity in Entities)
            {

                string QueryableProperties = entity.Key.GetAllPublicConstantValues<string>()[0];

                var bWorker = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };

                bWorker.DoWork += backgroundWorker_DoWork;
                bWorker.ProgressChanged += backgroundWorker_ProgressChanged;
                bWorker.RunWorkerCompleted += BWorker_RunWorkerCompleted;


                void BWorker_RunWorkerCompleted(object WC_sender, RunWorkerCompletedEventArgs WC_e)
                {
                    BackgroundWorker worker = WC_sender as BackgroundWorker;
                    if (worker.CancellationPending)
                        return;


                    RunningWorkers--;


                    (string Entity, string ExceptionMessage, DateTime StartTime) Result = ((string, string, DateTime))WC_e.Result;


                    var LogLine = $"{Result.Entity.PadRight(50, '.')}done in:{DateTime.Now.Subtract(Result.StartTime).ToString(@"hh\:mm\:ss")} {Result.ExceptionMessage}" + Environment.NewLine;
                    Log = Log + LogLine;

                    if (RunningWorkers == 0)
                    {
                        Debug.Write("Commiting");
                        currentCompany.SyncTime = DateTime.Now.Subtract(StartTime).ToString(@"hh\:mm\:ss");
                        //TODO add action here
                        this.ObjectSpace.CommitChanges();
                        //this.View.Refresh();
                        if (CurrentPage <= pages)
                        {
                            ProcessPage(CurrentPage + 1);
                        }
                        else
                        { 
                            if(OnFinish!=null)
                                OnFinish.Invoke();
                        }
                    }



                }
                void backgroundWorker_ProgressChanged(object RP_sender, ProgressChangedEventArgs RP_e)
                {


                    BackgroundWorker worker = RP_sender as BackgroundWorker;
                    if (worker.CancellationPending)
                        return;




                    //HACK here we are back to the main thread so we can use the object space to create objects

                    (Dictionary<string, object> Reader, string Entity, string Properties, Type EntityType) WorkerArgs = ((Dictionary<string, object> Reader, string Entity, string Properties, Type EntityType))RP_e.UserState;


                    var Instance = this.ObjectSpace.CreateObject(WorkerArgs.EntityType) as XPBaseObject;//XPLiteObject;
                                                                                                             //var PropList = WorkerArgs.Properties.Split(',');

                    SetObjectValues(WorkerArgs, Instance);


                    //ExecuteDoEvents();
                    //currentCompany.Progress = currentCompany.Progress + 1; ;


                }
                void backgroundWorker_DoWork(object BW_sender, DoWorkEventArgs BW_e)
                {
                    BackgroundWorker worker = BW_sender as BackgroundWorker;
                    var WorkerArgs = ((string FileName, string Entity, string Properties, Type EntityType))BW_e.Argument;

                    (string Entity, string ExceptionMessage, DateTime StartTime) Result = (WorkerArgs.Entity, "", DateTime.Now);

                    using (QuickBooksConnection connection = new QuickBooksConnection(new QuickBooksConnectionStringBuilder() { CompanyFile = WorkerArgs.FileName, PoolWaitTime = 600 }))
                    {


                        try
                        {

                            connection.Open();

                            var accountsCommand = connection.CreateCommand();
                            //accountsCommand.CommandText = $"SELECT {WorkerArgs.Properties} FROM {WorkerArgs.Entity}";
                            accountsCommand.CommandText = BuildCommand(WorkerArgs);
                            QuickBooksDataReader rdr = accountsCommand.ExecuteReader();
                            int currentRecord = 0;
                            while (rdr.Read())
                            {
                                if (worker.CancellationPending == true)
                                {
                                    BW_e.Cancel = true;
                                    break;
                                }
                                else
                                {
                                    Dictionary<string, object> values = new Dictionary<string, object>();
                                    var PropList = WorkerArgs.Properties.Split(',');
                                    foreach (var property in PropList)
                                    {
                                        object value = rdr.GetValue(property);
                                        //Debug.WriteLine(value.GetType());
                                        if (value.GetType() == typeof(double))
                                        {
                                            value = Convert.ChangeType(value, typeof(float));
                                        }
                                        if (value.GetType() == typeof(DBNull))

                                        {

                                            value = null;
                                        }
                                        values.Add(property, value);
                                    }

                                    //Debug.WriteLine($"record:{currentRecord} val count:{values.Count}");
                                    currentRecord++;
                                    var ProgressArgs = (values, WorkerArgs.Entity, WorkerArgs.Properties, WorkerArgs.EntityType);
                                    //System.Threading.Thread.Sleep(50);
                                    worker.ReportProgress(0, ProgressArgs);

                                    //if (rdr.VisibleFieldCount > 0)
                                    //    worker.ReportProgress(0, ProgressArgs);
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            Result.ExceptionMessage = ex.Message;
                            Debug.WriteLine("Read Exception");
                            Debug.WriteLine(ex.Message);
                        }



                    }



                    BW_e.Result = Result;
                }


                //Using tuples to pass arguments to the backgrown worker
                var WokerArgs = (currentCompany.FilePath, entity.Value, QueryableProperties, entity.Key);

                //bWorker.RunWorkerAsync(WokerArgs);
                Workers.Add(entity.Value, new KeyValuePair<BackgroundWorker, object>(bWorker, WokerArgs));

            }

            int WorkersCount = Workers.Count();
            var ExtranPage = WorkersCount % currentCompany.MaxConcurrentThreads;
            pages = WorkersCount / currentCompany.MaxConcurrentThreads;
            if (ExtranPage > 0)
            {
                pages = pages + 1;
            }

            ProcessPage(1);

        }
        protected virtual string BuildCommand((string FileName, string Entity, string Properties, Type EntityType) WorkerArgs)
        {
            return $"SELECT * FROM {WorkerArgs.Entity} {GetQueryParameters(WorkerArgs.EntityType)}";
        }
        protected virtual string GetQueryParameters(Type EntityType)
        {
            if (this.EntityQueryParamters != null)
                return this.EntityQueryParamters[EntityType];
            else
                return "";
        }
        protected virtual void SetObjectValues((Dictionary<string, object> Reader, string Entity, string Properties, Type EntityType) WorkerArgs, XPBaseObject Instance)
        {
            foreach (KeyValuePair<string, object> CurrentItem in WorkerArgs.Reader)
            {

                Instance.SetMemberValue(CurrentItem.Key, CurrentItem.Value);
            }
            if (AfterSetValues != null)
                AfterSetValues.Invoke(Instance);

        }

        protected virtual Dictionary<Type, string> GetEntities()
        {
            return Entities;
        }

        private void ProcessPage(int PageNumber)
        {
            var PageData = GetPage(Workers, PageNumber, currentCompany.MaxConcurrentThreads);
            CurrentPage = PageNumber;
            foreach (var item in PageData)
            {
                item.Value.Key.RunWorkerAsync(item.Value.Value);
                RunningWorkers++;
            }
        }

        protected Dictionary<string, KeyValuePair<BackgroundWorker, object>> GetPage(Dictionary<string, KeyValuePair<BackgroundWorker, object>> list, int pageNumber, int pageSize = 10)
        {

            return new Dictionary<string, KeyValuePair<BackgroundWorker, object>>(list.Skip((pageNumber - 1) * pageSize).Take(pageSize));

        }
    }
}
