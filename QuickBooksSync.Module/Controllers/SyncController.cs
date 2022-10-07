﻿using DevExpress.Data.Filtering;
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
        protected virtual void ExecuteDoEvents()
        {
            
        }
        protected virtual void backgroundWorker_ProgressChanged(object RP_sender, ProgressChangedEventArgs RP_e)
        {


            BackgroundWorker worker = RP_sender as BackgroundWorker;
            if (worker.CancellationPending)
                return;



            //HACK here we are back to the main thread so we can use the object space to create objects

            (Dictionary<string, object> Reader, string Entity, string Properties) WorkerArgs = ((Dictionary<string, object> Reader, string Entity, string Properties))RP_e.UserState;


            var Instance = this.View.ObjectSpace.CreateObject<Account>();
            //var PropList = WorkerArgs.Properties.Split(',');
            foreach (KeyValuePair<string, object> CurrentItem in WorkerArgs.Reader)
            {

                Instance.SetMemberValue(CurrentItem.Key, CurrentItem.Value);
            }

            //ExecuteDoEvents();
            currentCompany.Progress = currentCompany.Progress + 1; ;


        }
        private void Sybc_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            currentCompany = this.View.CurrentObject as Company;
            currentCompany.Progress = 0;
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
                                if (value.GetType() == typeof(Double))
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
                            var ProgressArgs = (values, WorkerArgs.Entity, WorkerArgs.Properties);
                            worker.ReportProgress(0, ProgressArgs);
                           
                            //if (rdr.VisibleFieldCount > 0)
                            //    worker.ReportProgress(0, ProgressArgs);
                        }
                        
                    }


                }

             
            }


            //Using tuples to pass arguments to the backgrown worker
            var WokerArgs = (currentCompany.FilePath, "Accounts",Account.QueryableProperties);

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
