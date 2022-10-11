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
    [NavigationItem("Quickbooks Data")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class PriceLevelPerItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public PriceLevelPerItem(Session session)
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
        private String _PriceLevelId;
        [Size(300)]
        public String PriceLevelId
        {
            get => _PriceLevelId;
            set => SetPropertyValue(nameof(PriceLevelId), ref _PriceLevelId, value);
        }  
        private String _Name;
        [Size(300)]
        public String Name
        {
            get => _Name;
            set => SetPropertyValue(nameof(Name), ref _Name, value);
        }  
        private String _PriceLevelType;
        [Size(300)]
        public String PriceLevelType
        {
            get => _PriceLevelType;
            set => SetPropertyValue(nameof(PriceLevelType), ref _PriceLevelType, value);
        }  
        private Boolean? _IsActive;
        public Boolean? IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String _PriceLevelPerItemRetItemRefListId;
        [Size(300)]
        public String PriceLevelPerItemRetItemRefListId
        {
            get => _PriceLevelPerItemRetItemRefListId;
            set => SetPropertyValue(nameof(PriceLevelPerItemRetItemRefListId), ref _PriceLevelPerItemRetItemRefListId, value);
        }  
        private String _PriceLevelPerItemRetItemRefFullName;
        [Size(300)]
        public String PriceLevelPerItemRetItemRefFullName
        {
            get => _PriceLevelPerItemRetItemRefFullName;
            set => SetPropertyValue(nameof(PriceLevelPerItemRetItemRefFullName), ref _PriceLevelPerItemRetItemRefFullName, value);
        }  
        private Decimal? _PriceLevelPerItemRetCustomPrice;
        public Decimal? PriceLevelPerItemRetCustomPrice
        {
            get => _PriceLevelPerItemRetCustomPrice;
            set => SetPropertyValue(nameof(PriceLevelPerItemRetCustomPrice), ref _PriceLevelPerItemRetCustomPrice, value);
        }  
        private Single? _PriceLevelPerItemRetCustomPricePercent;
        public Single? PriceLevelPerItemRetCustomPricePercent
        {
            get => _PriceLevelPerItemRetCustomPricePercent;
            set => SetPropertyValue(nameof(PriceLevelPerItemRetCustomPricePercent), ref _PriceLevelPerItemRetCustomPricePercent, value);
        }  
        private String _PriceLevelPerItemRetCurrencyRefListId;
        [Size(300)]
        public String PriceLevelPerItemRetCurrencyRefListId
        {
            get => _PriceLevelPerItemRetCurrencyRefListId;
            set => SetPropertyValue(nameof(PriceLevelPerItemRetCurrencyRefListId), ref _PriceLevelPerItemRetCurrencyRefListId, value);
        }  
        private String _PriceLevelPerItemRetCurrencyRefFullName;
        [Size(300)]
        public String PriceLevelPerItemRetCurrencyRefFullName
        {
            get => _PriceLevelPerItemRetCurrencyRefFullName;
            set => SetPropertyValue(nameof(PriceLevelPerItemRetCurrencyRefFullName), ref _PriceLevelPerItemRetCurrencyRefFullName, value);
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
        public const string QueryableProperties="Id,PriceLevelId,Name,PriceLevelType,IsActive,PriceLevelPerItemRetItemRefListId,PriceLevelPerItemRetItemRefFullName,PriceLevelPerItemRetCustomPrice,PriceLevelPerItemRetCustomPricePercent,PriceLevelPerItemRetCurrencyRefListId,PriceLevelPerItemRetCurrencyRefFullName,TimeCreated,TimeModified,EditSequence";
        public const string QuickbooksTableName="PriceLevelPerItem";
    }
}