using BitFwks.Scheduler.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace QuickBooksSync.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class EmployeeEarning : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public EmployeeEarning(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
         
        private string _Id;
        [Key(false)]
        public string Id
        {
            get => _Id;
            set => SetPropertyValue(nameof(Id), ref _Id, value);
        }  
        private String _Name;
        [Size(300)]
        public String Name
        {
            get => _Name;
            set => SetPropertyValue(nameof(Name), ref _Name, value);
        }  
        private String _PayPeriod;
        [Size(300)]
        public String PayPeriod
        {
            get => _PayPeriod;
            set => SetPropertyValue(nameof(PayPeriod), ref _PayPeriod, value);
        }  
        private String _EmployeeId;
        [Size(300)]
        public String EmployeeId
        {
            get => _EmployeeId;
            set => SetPropertyValue(nameof(EmployeeId), ref _EmployeeId, value);
        }  
        private String _EarningsId;
        [Size(300)]
        public String EarningsId
        {
            get => _EarningsId;
            set => SetPropertyValue(nameof(EarningsId), ref _EarningsId, value);
        }  
        private String _EarningsWageName;
        [Size(300)]
        public String EarningsWageName
        {
            get => _EarningsWageName;
            set => SetPropertyValue(nameof(EarningsWageName), ref _EarningsWageName, value);
        }  
        private String _EarningsWageId;
        [Size(300)]
        public String EarningsWageId
        {
            get => _EarningsWageId;
            set => SetPropertyValue(nameof(EarningsWageId), ref _EarningsWageId, value);
        }  
        private Single? _EarningsRate;
        public Single? EarningsRate
        {
            get => _EarningsRate;
            set => SetPropertyValue(nameof(EarningsRate), ref _EarningsRate, value);
        }  
        private String _EarningsRatePercent;
        [Size(300)]
        public String EarningsRatePercent
        {
            get => _EarningsRatePercent;
            set => SetPropertyValue(nameof(EarningsRatePercent), ref _EarningsRatePercent, value);
        }  
        private DateTime? _TimeModified;
        public DateTime? TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private DateTime? _TimeCreated;
        public DateTime? TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }
        public const string QueryableProperties="Id,Name,PayPeriod,EmployeeId,EarningsId,EarningsWageName,EarningsWageId,EarningsRate,EarningsRatePercent,TimeModified,TimeCreated";
    }
}