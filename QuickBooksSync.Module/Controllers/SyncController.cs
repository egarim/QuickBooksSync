using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using QuickBooksSync.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.CData.QuickBooks;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using XafWinBackgroundWorker.Module.BusinessObjects;

namespace QuickBooksSync.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class SyncController : ViewController
    {
        SimpleAction ActiveALl;
        SimpleAction GenerateEntities;
        SimpleAction Sync;
        Company currentCompany;
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public SyncController()
        {
            InitializeComponent();
            Sync = new SimpleAction(this, "Sync", "View");
            Sync.Execute += Sybc_Execute;
            GenerateEntities = new SimpleAction(this, "GenerateEntites", "View");
            GenerateEntities.Execute += GenerateEntities_Execute;

            ActiveALl = new SimpleAction(this, "SelectAll", "View");
            ActiveALl.Execute += ActiveALl_Execute;



            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        private void ActiveALl_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            // Execute your business logic (https://docs.devexpress.com/eXpressAppFramework/112737/).
        }
        private void GenerateEntities_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\manu_\\source\\repos\\QuickBooksSync\\EFConsoleQb\\EFConsoleQb\\Models");
            var Files = directoryInfo.GetFiles();
            foreach (FileInfo fileInfo in Files)
            {
                CompanyEntity entity = this.View.ObjectSpace.CreateObject<CompanyEntity>();
                entity.Name = fileInfo.Name.Replace(".cs", "");
            }
            this.View.ObjectSpace.CommitChanges();

            // Execute your business logic (https://docs.devexpress.com/eXpressAppFramework/112737/).
        }
        private void Sybc_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            currentCompany = this.View.CurrentObject as Company;
            var bWorker = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            bWorker.DoWork += backgroundWorker_DoWork;
            bWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            bWorker.RunWorkerCompleted += BWorker_RunWorkerCompleted;
            using (QuickBooksConnection connection = new QuickBooksConnection(new QuickBooksConnectionStringBuilder() { CompanyFile = currentCompany.FilePath, PoolWaitTime = 600 }))
            {

                connection.Open();
                var CountCommand = connection.CreateCommand();
               
            
                CountCommand.CommandText = "SELECT COUNT(id) from Accounts";
                int RecordCount;
                RecordCount = (int)CountCommand.ExecuteScalar();
               
               
                currentCompany.Max = RecordCount;
                //var accountsCommand = connection.CreateCommand();
                //accountsCommand.CommandText = "SELECT * FROM Accounts";
                //QuickBooksDataReader rdr = accountsCommand.ExecuteReader();
                //while (rdr.Read())
                //{
                //}
            }

            void BWorker_RunWorkerCompleted(object WC_sender, RunWorkerCompletedEventArgs WC_e)
            {
                BackgroundWorker worker = WC_sender as BackgroundWorker;
                if (worker.CancellationPending)
                    return;

                if (this.View == null)
                    return;

                this.View.ObjectSpace.CommitChanges();
            }
            void backgroundWorker_ProgressChanged(object RP_sender, ProgressChangedEventArgs RP_e)
            {


                BackgroundWorker worker = RP_sender as BackgroundWorker;
                if (worker.CancellationPending)
                    return;


             
                //HACK here we are back to the main thread so we can use the object space to create objects

                (QuickBooksDataReader Reader, string Entity, string Properties) WorkerArgs = ((QuickBooksDataReader Reader, string Entity,string Properties))RP_e.UserState;

                var PropList = WorkerArgs.Properties.Split(',');
                foreach (string item in PropList)
                {
                    Debug.WriteLine($"{item};{WorkerArgs.Reader[item]}");
                }
                currentCompany.Progress++;

                //WorkerArgs.c

                //var File = this.View.ObjectSpace.CreateObject<DirectoryFile>();
                //File.File = this.View.ObjectSpace.CreateObject<FileData>();
                //File.File.LoadFromStream(WorkerArgs.FileName, new MemoryStream(WorkerArgs.Data));
                //CurrentDirectory.DirectoryFiles.Add(File);
                //CurrentDirectory.Progress++;
                //resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
            }
            void backgroundWorker_DoWork(object BW_sender, DoWorkEventArgs BW_e)
            {
                BackgroundWorker worker = BW_sender as BackgroundWorker;
                var WorkerArgs = ((string FileName, string Entity,string Properties))BW_e.Argument;
                using (QuickBooksConnection connection = new QuickBooksConnection(new QuickBooksConnectionStringBuilder() { CompanyFile = WorkerArgs.FileName, PoolWaitTime = 600 }))
                {

                    connection.Open();

                    var accountsCommand = connection.CreateCommand();
                    accountsCommand.CommandText = $"SELECT {WorkerArgs.Properties} FROM {WorkerArgs.Entity}";
                    QuickBooksDataReader rdr = accountsCommand.ExecuteReader();
                    while (rdr.Read())
                    {
                        System.Threading.Thread.Sleep(500);
                        var ProgressArgs = (rdr, WorkerArgs.Entity, WorkerArgs.Properties);
                        worker.ReportProgress(0, ProgressArgs);
                        
                    }


                }


                //(Faker Faker, int FilesToGenerate) WorkerArgs = ((Faker Faker, int FilesToGenerate))BW_e.Argument;

                //for (int i = 1; i <= WorkerArgs.FilesToGenerate; i++)
                //{
                //    if (worker.CancellationPending == true)
                //    {
                //        BW_e.Cancel = true;
                //        break;
                //    }
                //    else
                //    {
                //        //HACK We generate a filename and a random text as bytes to return to the main thread
                //        var DataForMainThread = ($"{WorkerArgs.Faker.Name.FirstName()}_{WorkerArgs.Faker.Name.LastName()}.txt", Encoding.ASCII.GetBytes(WorkerArgs.Faker.Lorem.Sentence(50)));


                //        //HACK if the process is too fast we can add delay to show the progress effect performing a time consuming operation and report progress.
                //        System.Threading.Thread.Sleep(500);

                //        worker.ReportProgress(i, DataForMainThread);
                //    }
                //}
            }




            //Using tuples to pass arguments to the backgrown worker
            var WokerArgs = (currentCompany.FilePath, "Accounts",Account.QueriableProperties);

            bWorker.RunWorkerAsync(WokerArgs);
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
