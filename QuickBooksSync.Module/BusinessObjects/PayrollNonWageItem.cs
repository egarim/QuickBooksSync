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
    public class PayrollNonWageItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public PayrollNonWageItem(Session session)
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
        private String? _Name;
        public String? Name
        {
            get => _Name;
            set => SetPropertyValue(nameof(Name), ref _Name, value);
        }  
        private Boolean _IsActive;
        public Boolean IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String? _NonWageType;
        public String? NonWageType
        {
            get => _NonWageType;
            set => SetPropertyValue(nameof(NonWageType), ref _NonWageType, value);
        }  
        private String? _ExpenseAccountRefFullName;
        public String? ExpenseAccountRefFullName
        {
            get => _ExpenseAccountRefFullName;
            set => SetPropertyValue(nameof(ExpenseAccountRefFullName), ref _ExpenseAccountRefFullName, value);
        }  
        private String? _ExpenseAccountRefListId;
        public String? ExpenseAccountRefListId
        {
            get => _ExpenseAccountRefListId;
            set => SetPropertyValue(nameof(ExpenseAccountRefListId), ref _ExpenseAccountRefListId, value);
        }  
        private String? _LiabilityAccountRefFullName;
        public String? LiabilityAccountRefFullName
        {
            get => _LiabilityAccountRefFullName;
            set => SetPropertyValue(nameof(LiabilityAccountRefFullName), ref _LiabilityAccountRefFullName, value);
        }  
        private String? _LiabilityAccountRefListId;
        public String? LiabilityAccountRefListId
        {
            get => _LiabilityAccountRefListId;
            set => SetPropertyValue(nameof(LiabilityAccountRefListId), ref _LiabilityAccountRefListId, value);
        }  
        private DateTime _TimeCreated;
        public DateTime TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private DateTime _TimeModified;
        public DateTime TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private String? _EditSequence;
        public String? EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }  
        private string _ExpenseAccountRefList;
        public string ExpenseAccountRefList
        {
            get => _ExpenseAccountRefList;
            set => SetPropertyValue(nameof(ExpenseAccountRefList), ref _ExpenseAccountRefList, value);
        }  
        private string _LiabilityAccountRefList;
        public string LiabilityAccountRefList
        {
            get => _LiabilityAccountRefList;
            set => SetPropertyValue(nameof(LiabilityAccountRefList), ref _LiabilityAccountRefList, value);
        }
       
    }
}