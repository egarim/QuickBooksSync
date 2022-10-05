using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class TransferInventoryLineItem
    {
        public string Id { get; set; } = null!;
        public string? TransferInventoryId { get; set; }
        public DateTime? TxnDate { get; set; }
        public int? TxnNumber { get; set; }
        public string? RefNumber { get; set; }
        public string? FromInventorySiteRefListId { get; set; }
        public string? FromInventorySiteRefFullName { get; set; }
        public string? ToInventorySiteRefListId { get; set; }
        public string? ToInventorySiteRefFullName { get; set; }
        public string? Memo { get; set; }
        public string? ExternalGuid { get; set; }
        public string? TransferInventoryLineRetTxnLineId { get; set; }
        public string? TransferInventoryLineRetItemRefListId { get; set; }
        public string? TransferInventoryLineRetItemRefFullName { get; set; }
        public string? TransferInventoryLineRetFromInventorySiteLocationRefListId { get; set; }
        public string? TransferInventoryLineRetFromInventorySiteLocationRefFullName { get; set; }
        public string? TransferInventoryLineRetToInventorySiteLocationRefListId { get; set; }
        public string? TransferInventoryLineRetToInventorySiteLocationRefFullName { get; set; }
        public float? TransferInventoryLineRetQuantityToTransfer { get; set; }
        public float? TransferInventoryLineRetQuantityTransferred { get; set; }
        public string? TransferInventoryLineRetSerialNumber { get; set; }
        public string? TransferInventoryLineRetLotNumber { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual InventorySite? FromInventorySiteRefList { get; set; }
        public virtual InventorySite? ToInventorySiteRefList { get; set; }
        public virtual Item? TransferInventoryLineRetItemRefList { get; set; }
    }
}
