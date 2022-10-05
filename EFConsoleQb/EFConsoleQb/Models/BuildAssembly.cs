using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class BuildAssembly
    {
        public BuildAssembly()
        {
            BuildAssemblyLineItems = new HashSet<BuildAssemblyLineItem>();
        }

        public string Id { get; set; } = null!;
        public int? TxnNumber { get; set; }
        public string? ItemInventoryAssemblyRefListId { get; set; }
        public string? ItemInventoryAssemblyRefFullName { get; set; }
        public string? InventorySiteRefListId { get; set; }
        public string? InventorySiteRefFullName { get; set; }
        public string? SerialNumber { get; set; }
        public string? LotNumber { get; set; }
        public DateTime? TxnDate { get; set; }
        public string? RefNumber { get; set; }
        public string? Memo { get; set; }
        public bool? IsPending { get; set; }
        public float? QuantityToBuild { get; set; }
        public float? QuantityCanBuild { get; set; }
        public float? QuantityOnHand { get; set; }
        public float? QuantityOnSalesOrder { get; set; }
        public bool? MarkPendingIfRequired { get; set; }
        public string? ExternalGuid { get; set; }
        public string? BuildAssemblyLineAggregate { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual InventorySite? InventorySiteRefList { get; set; }
        public virtual Item? ItemInventoryAssemblyRefList { get; set; }
        public virtual ICollection<BuildAssemblyLineItem> BuildAssemblyLineItems { get; set; }
    }
}
