using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class TransferInventory
    {
        public string Id { get; set; } = null!;
        public DateTime? TxnDate { get; set; }
        public int? TxnNumber { get; set; }
        public string? RefNumber { get; set; }
        public string? FromInventorySiteRefListId { get; set; }
        public string? FromInventorySiteRefFullName { get; set; }
        public string? ToInventorySiteRefListId { get; set; }
        public string? ToInventorySiteRefFullName { get; set; }
        public string? Memo { get; set; }
        public string? ExternalGuid { get; set; }
        public string? TransferInventoryLineAggregate { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual InventorySite? FromInventorySiteRefList { get; set; }
        public virtual InventorySite? ToInventorySiteRefList { get; set; }
    }
}
