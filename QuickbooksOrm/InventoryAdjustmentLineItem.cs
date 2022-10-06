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
    public class InventoryAdjustmentLineItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public InventoryAdjustmentLineItem(Session session)
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
        private String? _InventoryAdjustmentId;
        public String? InventoryAdjustmentId
        {
            get => _InventoryAdjustmentId;
            set => SetPropertyValue(nameof(InventoryAdjustmentId), ref _InventoryAdjustmentId, value);
        }  
        private String? _ReferenceNumber;
        public String? ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
        }  
        private String? _Account;
        public String? Account
        {
            get => _Account;
            set => SetPropertyValue(nameof(Account), ref _Account, value);
        }  
        private String? _AccountId;
        public String? AccountId
        {
            get => _AccountId;
            set => SetPropertyValue(nameof(AccountId), ref _AccountId, value);
        }  
        private String? _Class;
        public String? Class
        {
            get => _Class;
            set => SetPropertyValue(nameof(Class), ref _Class, value);
        }  
        private String? _ClassId;
        public String? ClassId
        {
            get => _ClassId;
            set => SetPropertyValue(nameof(ClassId), ref _ClassId, value);
        }  
        private String? _CustomerName;
        public String? CustomerName
        {
            get => _CustomerName;
            set => SetPropertyValue(nameof(CustomerName), ref _CustomerName, value);
        }  
        private String? _CustomerId;
        public String? CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
        }  
        private String? _Memo;
        public String? Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private String? _InventorySite;
        public String? InventorySite
        {
            get => _InventorySite;
            set => SetPropertyValue(nameof(InventorySite), ref _InventorySite, value);
        }  
        private String? _InventorySiteId;
        public String? InventorySiteId
        {
            get => _InventorySiteId;
            set => SetPropertyValue(nameof(InventorySiteId), ref _InventorySiteId, value);
        }  
        private DateTime _Date;
        public DateTime Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private String? _ItemLineId;
        public String? ItemLineId
        {
            get => _ItemLineId;
            set => SetPropertyValue(nameof(ItemLineId), ref _ItemLineId, value);
        }  
        private String? _ItemLineNumber;
        public String? ItemLineNumber
        {
            get => _ItemLineNumber;
            set => SetPropertyValue(nameof(ItemLineNumber), ref _ItemLineNumber, value);
        }  
        private String? _ItemName;
        public String? ItemName
        {
            get => _ItemName;
            set => SetPropertyValue(nameof(ItemName), ref _ItemName, value);
        }  
        private String? _ItemId;
        public String? ItemId
        {
            get => _ItemId;
            set => SetPropertyValue(nameof(ItemId), ref _ItemId, value);
        }  
        private Single _ItemNewQuantity;
        public Single ItemNewQuantity
        {
            get => _ItemNewQuantity;
            set => SetPropertyValue(nameof(ItemNewQuantity), ref _ItemNewQuantity, value);
        }  
        private Single _ItemNewValue;
        public Single ItemNewValue
        {
            get => _ItemNewValue;
            set => SetPropertyValue(nameof(ItemNewValue), ref _ItemNewValue, value);
        }  
        private Single _ItemQuantityDiff;
        public Single ItemQuantityDiff
        {
            get => _ItemQuantityDiff;
            set => SetPropertyValue(nameof(ItemQuantityDiff), ref _ItemQuantityDiff, value);
        }  
        private Single _ItemValueDiff;
        public Single ItemValueDiff
        {
            get => _ItemValueDiff;
            set => SetPropertyValue(nameof(ItemValueDiff), ref _ItemValueDiff, value);
        }  
        private String? _ItemLotNumber;
        public String? ItemLotNumber
        {
            get => _ItemLotNumber;
            set => SetPropertyValue(nameof(ItemLotNumber), ref _ItemLotNumber, value);
        }  
        private String? _ItemSerialNumber;
        public String? ItemSerialNumber
        {
            get => _ItemSerialNumber;
            set => SetPropertyValue(nameof(ItemSerialNumber), ref _ItemSerialNumber, value);
        }  
        private String? _ItemSerialNumberAddedOrRemoved;
        public String? ItemSerialNumberAddedOrRemoved
        {
            get => _ItemSerialNumberAddedOrRemoved;
            set => SetPropertyValue(nameof(ItemSerialNumberAddedOrRemoved), ref _ItemSerialNumberAddedOrRemoved, value);
        }  
        private String? _ItemInventorySiteLocationId;
        public String? ItemInventorySiteLocationId
        {
            get => _ItemInventorySiteLocationId;
            set => SetPropertyValue(nameof(ItemInventorySiteLocationId), ref _ItemInventorySiteLocationId, value);
        }  
        private String? _ItemInventorySiteLocationName;
        public String? ItemInventorySiteLocationName
        {
            get => _ItemInventorySiteLocationName;
            set => SetPropertyValue(nameof(ItemInventorySiteLocationName), ref _ItemInventorySiteLocationName, value);
        }  
        private String? _EditSequence;
        public String? EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }  
        private DateTime _TimeModified;
        public DateTime TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private DateTime _TimeCreated;
        public DateTime TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private string _AccountNavigation;
        public string AccountNavigation
        {
            get => _AccountNavigation;
            set => SetPropertyValue(nameof(AccountNavigation), ref _AccountNavigation, value);
        }  
        private string _ClassNavigation;
        public string ClassNavigation
        {
            get => _ClassNavigation;
            set => SetPropertyValue(nameof(ClassNavigation), ref _ClassNavigation, value);
        }  
        private string _Customer;
        public string Customer
        {
            get => _Customer;
            set => SetPropertyValue(nameof(Customer), ref _Customer, value);
        }  
        private string _InventoryAdjustment;
        public string InventoryAdjustment
        {
            get => _InventoryAdjustment;
            set => SetPropertyValue(nameof(InventoryAdjustment), ref _InventoryAdjustment, value);
        }  
        private string _InventorySiteNavigation;
        public string InventorySiteNavigation
        {
            get => _InventorySiteNavigation;
            set => SetPropertyValue(nameof(InventorySiteNavigation), ref _InventorySiteNavigation, value);
        }  
        private string _Item;
        public string Item
        {
            get => _Item;
            set => SetPropertyValue(nameof(Item), ref _Item, value);
        }
       
    }
}