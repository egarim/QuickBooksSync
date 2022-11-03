﻿using DevExpress.CodeParser;
using DevExpress.ExpressApp.Actions;
using DevExpress.Xpo;
using QuickBooksSync.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBooksSync.Module.Controllers
{
    public class BalanceSheetStandardSyncController:SyncController
    {
        SimpleAction GetBalanceSheets;
        public BalanceSheetStandardSyncController()
        {
            GetBalanceSheets = new SimpleAction(this, "GetBalanceSheets", "View");
            GetBalanceSheets.Execute += GetBalanceSheets_Execute;
            
        }

        protected override string BuildCommand((string FileName, string Entity, string Properties, Type EntityType) WorkerArgs)
        {
            string Select = base.BuildCommand(WorkerArgs)+ " WHERE ReportPeriod = '2022-01-08:2022-01-14'";
            return Select;
        }

        protected override Dictionary<Type, string> GetEntities()
        {

            Dictionary<Type, string> keyValuePairs = new Dictionary<Type, string>();
            //keyValuePairs.Add(typeof(BalanceSheetDetail), "BalanceSheetDetail");
            keyValuePairs.Add(typeof(BalanceSheetStandard), "BalanceSheetStandard");
            return keyValuePairs;
        }

        protected override void SetObjectValues((Dictionary<string, object> Reader, string Entity, string Properties, Type EntityType) WorkerArgs, XPBaseObject Instance)
        {
            base.SetObjectValues(WorkerArgs, Instance);
            Instance.SetMemberValue("Week", 2);
        }

        private void GetBalanceSheets_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            Dictionary<Type, string> Types = new Dictionary<Type, string>();
            //keyValuePairs.Add(typeof(BalanceSheetDetail), "BalanceSheetDetail");
            Types.Add(typeof(BalanceSheetStandard), "BalanceSheetStandard");

            var Company = (Company)this.View.CurrentObject;
            var StartDate = new DateTime(2022, 1, 1);
            Dictionary<int, string> Periods = new Dictionary<int, string>();
            for (int i = 1; i < 10; i++)
            {
                //" WHERE ReportPeriod = '2022-01-08:2022-01-14'"
            
                string Where = $"WHERE ReportPeriod = '{StartDate.ToString("yyyy-MM-dd")}:{StartDate.AddDays(7).ToString("yyyy-MM-dd")}'";
                Debug.WriteLine(Where);
                Periods.Add(i, Where);
               
                StartDate = StartDate.AddDays(8);
            }
            foreach (KeyValuePair<int, string> Period in Periods)
            {
                Dictionary<Type, string> QueryParamters = new Dictionary<Type, string>();
                QueryParamters.Add(typeof(BalanceSheetStandard), Period.Value);
                SyncHelper syncHelper =
                    new SyncHelper(Company,
                    Types,
                    this.Application.CreateObjectSpace(typeof(Company)),
                    () => Debug.WriteLine("Done"),
                    QueryParamters,
                    (instance) => { instance.SetMemberValue("Week", Period.Key); });
                syncHelper.Sync();
            }
            //this.Sync_Execute(sender, e);
            // Execute your business logic (https://docs.devexpress.com/eXpressAppFramework/112737/).
        }

    }
}
