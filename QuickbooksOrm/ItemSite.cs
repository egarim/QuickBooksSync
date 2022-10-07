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
    public class ItemSite : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ItemSite(Session session)
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
        private String _ItemInventoryAssemblyRefListId;
        [Size(300)]
        public String ItemInventoryAssemblyRefListId
        {
            get => _ItemInventoryAssemblyRefListId;
            set => SetPropertyValue(nameof(ItemInventoryAssemblyRefListId), ref _ItemInventoryAssemblyRefListId, value);
        }  
        private String _ItemInventoryAssemblyRefFullName;
        [Size(300)]
        public String ItemInventoryAssemblyRefFullName
        {
            get => _ItemInventoryAssemblyRefFullName;
            set => SetPropertyValue(nameof(ItemInventoryAssemblyRefFullName), ref _ItemInventoryAssemblyRefFullName, value);
        }  
        private String _ItemInventoryRefListId;
        [Size(300)]
        public String ItemInventoryRefListId
        {
            get => _ItemInventoryRefListId;
            set => SetPropertyValue(nameof(ItemInventoryRefListId), ref _ItemInventoryRefListId, value);
        }  
        private String _ItemInventoryRefFullName;
        [Size(300)]
        public String ItemInventoryRefFullName
        {
            get => _ItemInventoryRefFullName;
            set => SetPropertyValue(nameof(ItemInventoryRefFullName), ref _ItemInventoryRefFullName, value);
        }  
        private String _InventorySiteRefListId;
        [Size(300)]
        public String InventorySiteRefListId
        {
            get => _InventorySiteRefListId;
            set => SetPropertyValue(nameof(InventorySiteRefListId), ref _InventorySiteRefListId, value);
        }  
        private String _InventorySiteRefFullName;
        [Size(300)]
        public String InventorySiteRefFullName
        {
            get => _InventorySiteRefFullName;
            set => SetPropertyValue(nameof(InventorySiteRefFullName), ref _InventorySiteRefFullName, value);
        }  
        private String _InventorySiteLocationRefListId;
        [Size(300)]
        public String InventorySiteLocationRefListId
        {
            get => _InventorySiteLocationRefListId;
            set => SetPropertyValue(nameof(InventorySiteLocationRefListId), ref _InventorySiteLocationRefListId, value);
        }  
        private String _InventorySiteLocationRefFullName;
        [Size(300)]
        public String InventorySiteLocationRefFullName
        {
            get => _InventorySiteLocationRefFullName;
            set => SetPropertyValue(nameof(InventorySiteLocationRefFullName), ref _InventorySiteLocationRefFullName, value);
        }  
        private Single? _ReorderLevel;
        public Single? ReorderLevel
        {
            get => _ReorderLevel;
            set => SetPropertyValue(nameof(ReorderLevel), ref _ReorderLevel, value);
        }  
        private Single? _QuantityOnHand;
        public Single? QuantityOnHand
        {
            get => _QuantityOnHand;
            set => SetPropertyValue(nameof(QuantityOnHand), ref _QuantityOnHand, value);
        }  
        private Single? _QuantityOnPurchaseOrders;
        public Single? QuantityOnPurchaseOrders
        {
            get => _QuantityOnPurchaseOrders;
            set => SetPropertyValue(nameof(QuantityOnPurchaseOrders), ref _QuantityOnPurchaseOrders, value);
        }  
        private Single? _QuantityOnSalesOrders;
        public Single? QuantityOnSalesOrders
        {
            get => _QuantityOnSalesOrders;
            set => SetPropertyValue(nameof(QuantityOnSalesOrders), ref _QuantityOnSalesOrders, value);
        }  
        private Single? _QuantityToBeBuiltByPendingBuildTxns;
        public Single? QuantityToBeBuiltByPendingBuildTxns
        {
            get => _QuantityToBeBuiltByPendingBuildTxns;
            set => SetPropertyValue(nameof(QuantityToBeBuiltByPendingBuildTxns), ref _QuantityToBeBuiltByPendingBuildTxns, value);
        }  
        private Single? _QuantityRequiredByPendingBuildTxns;
        public Single? QuantityRequiredByPendingBuildTxns
        {
            get => _QuantityRequiredByPendingBuildTxns;
            set => SetPropertyValue(nameof(QuantityRequiredByPendingBuildTxns), ref _QuantityRequiredByPendingBuildTxns, value);
        }  
        private Single? _QuantityOnPendingTransfers;
        public Single? QuantityOnPendingTransfers
        {
            get => _QuantityOnPendingTransfers;
            set => SetPropertyValue(nameof(QuantityOnPendingTransfers), ref _QuantityOnPendingTransfers, value);
        }  
        private Single? _AssemblyBuildPoint;
        public Single? AssemblyBuildPoint
        {
            get => _AssemblyBuildPoint;
            set => SetPropertyValue(nameof(AssemblyBuildPoint), ref _AssemblyBuildPoint, value);
        }  
        private String _EditSequence;
        [Size(300)]
        public String EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
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
        public const string QueryableProperties="Id,ItemInventoryAssemblyRefListId,ItemInventoryAssemblyRefFullName,ItemInventoryRefListId,ItemInventoryRefFullName,InventorySiteRefListId,InventorySiteRefFullName,InventorySiteLocationRefListId,InventorySiteLocationRefFullName,ReorderLevel,QuantityOnHand,QuantityOnPurchaseOrders,QuantityOnSalesOrders,QuantityToBeBuiltByPendingBuildTxns,QuantityRequiredByPendingBuildTxns,QuantityOnPendingTransfers,AssemblyBuildPoint,EditSequence,TimeCreated,TimeModified";
    }
}