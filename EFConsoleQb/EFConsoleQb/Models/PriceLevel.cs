using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class PriceLevel
    {
        public PriceLevel()
        {
            Customers = new HashSet<Customer>();
            PriceLevelPerItems = new HashSet<PriceLevelPerItem>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? PriceLevelType { get; set; }
        public bool? IsActive { get; set; }
        public float? PriceLevelFixedPercentage { get; set; }
        public string? PriceLevelPerItemAggregate { get; set; }
        public string? PriceLevelPerItemRetCurrencyRefListId { get; set; }
        public string? PriceLevelPerItemRetCurrencyRefFullName { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual Currency? PriceLevelPerItemRetCurrencyRefList { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<PriceLevelPerItem> PriceLevelPerItems { get; set; }
    }
}
