using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class InventoryAdjustment
    {
        public InventoryAdjustment()
        {
            InventoryAdjustmentLineItems = new HashSet<InventoryAdjustmentLineItem>();
        }

        public string Id { get; set; } = null!;
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
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountNavigation { get; set; }
        public virtual Class? ClassNavigation { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual InventorySite? InventorySiteNavigation { get; set; }
        public virtual ICollection<InventoryAdjustmentLineItem> InventoryAdjustmentLineItems { get; set; }
    }
}
