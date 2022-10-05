using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ItemSite
    {
        public string Id { get; set; } = null!;
        public string? ItemInventoryAssemblyRefListId { get; set; }
        public string? ItemInventoryAssemblyRefFullName { get; set; }
        public string? ItemInventoryRefListId { get; set; }
        public string? ItemInventoryRefFullName { get; set; }
        public string? InventorySiteRefListId { get; set; }
        public string? InventorySiteRefFullName { get; set; }
        public string? InventorySiteLocationRefListId { get; set; }
        public string? InventorySiteLocationRefFullName { get; set; }
        public float? ReorderLevel { get; set; }
        public float? QuantityOnHand { get; set; }
        public float? QuantityOnPurchaseOrders { get; set; }
        public float? QuantityOnSalesOrders { get; set; }
        public float? QuantityToBeBuiltByPendingBuildTxns { get; set; }
        public float? QuantityRequiredByPendingBuildTxns { get; set; }
        public float? QuantityOnPendingTransfers { get; set; }
        public float? AssemblyBuildPoint { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual InventorySite? InventorySiteRefList { get; set; }
        public virtual Item? ItemInventoryAssemblyRefList { get; set; }
        public virtual Item? ItemInventoryRefList { get; set; }
    }
}
