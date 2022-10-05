using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class InventoryAdjustmentLineItem
    {
        public string Id { get; set; } = null!;
        public string? InventoryAdjustmentId { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? Account { get; set; }
        public string? AccountId { get; set; }
        public string? Class { get; set; }
        public string? ClassId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public string? Memo { get; set; }
        public string? InventorySite { get; set; }
        public string? InventorySiteId { get; set; }
        public DateTime? Date { get; set; }
        public string? ItemLineId { get; set; }
        public string? ItemLineNumber { get; set; }
        public string? ItemName { get; set; }
        public string? ItemId { get; set; }
        public float? ItemNewQuantity { get; set; }
        public float? ItemNewValue { get; set; }
        public float? ItemQuantityDiff { get; set; }
        public float? ItemValueDiff { get; set; }
        public string? ItemLotNumber { get; set; }
        public string? ItemSerialNumber { get; set; }
        public string? ItemSerialNumberAddedOrRemoved { get; set; }
        public string? ItemInventorySiteLocationId { get; set; }
        public string? ItemInventorySiteLocationName { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountNavigation { get; set; }
        public virtual Class? ClassNavigation { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual InventoryAdjustment? InventoryAdjustment { get; set; }
        public virtual InventorySite? InventorySiteNavigation { get; set; }
        public virtual Item? Item { get; set; }
    }
}
