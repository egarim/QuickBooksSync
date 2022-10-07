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
    public class WorkersCompCode : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public WorkersCompCode(Session session)
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
        private String _Desc;
        [Size(300)]
        public String Desc
        {
            get => _Desc;
            set => SetPropertyValue(nameof(Desc), ref _Desc, value);
        }  
        private Single? _CurrentRate;
        public Single? CurrentRate
        {
            get => _CurrentRate;
            set => SetPropertyValue(nameof(CurrentRate), ref _CurrentRate, value);
        }  
        private DateTime? _CurrentEffectiveDate;
        public DateTime? CurrentEffectiveDate
        {
            get => _CurrentEffectiveDate;
            set => SetPropertyValue(nameof(CurrentEffectiveDate), ref _CurrentEffectiveDate, value);
        }  
        private Single? _NextRate;
        public Single? NextRate
        {
            get => _NextRate;
            set => SetPropertyValue(nameof(NextRate), ref _NextRate, value);
        }  
        private DateTime? _NextEffectiveDate;
        public DateTime? NextEffectiveDate
        {
            get => _NextEffectiveDate;
            set => SetPropertyValue(nameof(NextEffectiveDate), ref _NextEffectiveDate, value);
        }  
        private String _RateHistory;
        [Size(300)]
        public String RateHistory
        {
            get => _RateHistory;
            set => SetPropertyValue(nameof(RateHistory), ref _RateHistory, value);
        }  
        private Boolean? _IsActive;
        public Boolean? IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private DateTime? _TimeCreated;
        public DateTime? TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private DateTime? _TimeModified;
        public DateTime? TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private String _EditSequence;
        [Size(300)]
        public String EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }
        public const string QueryableProperties="Id,Name,Desc,CurrentRate,CurrentEffectiveDate,NextRate,NextEffectiveDate,RateHistory,IsActive,TimeCreated,TimeModified,EditSequence";
    }
}