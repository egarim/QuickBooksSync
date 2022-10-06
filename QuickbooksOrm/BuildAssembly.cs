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
    public class BuildAssembly : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public BuildAssembly(Session session)
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
        private Int32 _TxnNumber;
        public Int32 TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private String? _ItemInventoryAssemblyRefListId;
        public String? ItemInventoryAssemblyRefListId
        {
            get => _ItemInventoryAssemblyRefListId;
            set => SetPropertyValue(nameof(ItemInventoryAssemblyRefListId), ref _ItemInventoryAssemblyRefListId, value);
        }  
        private String? _ItemInventoryAssemblyRefFullName;
        public String? ItemInventoryAssemblyRefFullName
        {
            get => _ItemInventoryAssemblyRefFullName;
            set => SetPropertyValue(nameof(ItemInventoryAssemblyRefFullName), ref _ItemInventoryAssemblyRefFullName, value);
        }  
        private String? _InventorySiteRefListId;
        public String? InventorySiteRefListId
        {
            get => _InventorySiteRefListId;
            set => SetPropertyValue(nameof(InventorySiteRefListId), ref _InventorySiteRefListId, value);
        }  
        private String? _InventorySiteRefFullName;
        public String? InventorySiteRefFullName
        {
            get => _InventorySiteRefFullName;
            set => SetPropertyValue(nameof(InventorySiteRefFullName), ref _InventorySiteRefFullName, value);
        }  
        private String? _SerialNumber;
        public String? SerialNumber
        {
            get => _SerialNumber;
            set => SetPropertyValue(nameof(SerialNumber), ref _SerialNumber, value);
        }  
        private String? _LotNumber;
        public String? LotNumber
        {
            get => _LotNumber;
            set => SetPropertyValue(nameof(LotNumber), ref _LotNumber, value);
        }  
        private DateTime _TxnDate;
        public DateTime TxnDate
        {
            get => _TxnDate;
            set => SetPropertyValue(nameof(TxnDate), ref _TxnDate, value);
        }  
        private String? _RefNumber;
        public String? RefNumber
        {
            get => _RefNumber;
            set => SetPropertyValue(nameof(RefNumber), ref _RefNumber, value);
        }  
        private String? _Memo;
        public String? Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private Boolean _IsPending;
        public Boolean IsPending
        {
            get => _IsPending;
            set => SetPropertyValue(nameof(IsPending), ref _IsPending, value);
        }  
        private Single _QuantityToBuild;
        public Single QuantityToBuild
        {
            get => _QuantityToBuild;
            set => SetPropertyValue(nameof(QuantityToBuild), ref _QuantityToBuild, value);
        }  
        private Single _QuantityCanBuild;
        public Single QuantityCanBuild
        {
            get => _QuantityCanBuild;
            set => SetPropertyValue(nameof(QuantityCanBuild), ref _QuantityCanBuild, value);
        }  
        private Single _QuantityOnHand;
        public Single QuantityOnHand
        {
            get => _QuantityOnHand;
            set => SetPropertyValue(nameof(QuantityOnHand), ref _QuantityOnHand, value);
        }  
        private Single _QuantityOnSalesOrder;
        public Single QuantityOnSalesOrder
        {
            get => _QuantityOnSalesOrder;
            set => SetPropertyValue(nameof(QuantityOnSalesOrder), ref _QuantityOnSalesOrder, value);
        }  
        private Boolean _MarkPendingIfRequired;
        public Boolean MarkPendingIfRequired
        {
            get => _MarkPendingIfRequired;
            set => SetPropertyValue(nameof(MarkPendingIfRequired), ref _MarkPendingIfRequired, value);
        }  
        private String? _ExternalGuid;
        public String? ExternalGuid
        {
            get => _ExternalGuid;
            set => SetPropertyValue(nameof(ExternalGuid), ref _ExternalGuid, value);
        }  
        private String? _BuildAssemblyLineAggregate;
        public String? BuildAssemblyLineAggregate
        {
            get => _BuildAssemblyLineAggregate;
            set => SetPropertyValue(nameof(BuildAssemblyLineAggregate), ref _BuildAssemblyLineAggregate, value);
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
        private string _InventorySiteRefList;
        public string InventorySiteRefList
        {
            get => _InventorySiteRefList;
            set => SetPropertyValue(nameof(InventorySiteRefList), ref _InventorySiteRefList, value);
        }  
        private string _ItemInventoryAssemblyRefList;
        public string ItemInventoryAssemblyRefList
        {
            get => _ItemInventoryAssemblyRefList;
            set => SetPropertyValue(nameof(ItemInventoryAssemblyRefList), ref _ItemInventoryAssemblyRefList, value);
        }
       
    }
}