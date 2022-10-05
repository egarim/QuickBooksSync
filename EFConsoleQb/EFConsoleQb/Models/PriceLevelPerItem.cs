using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class PriceLevelPerItem
    {
        public string Id { get; set; } = null!;
        public string? PriceLevelId { get; set; }
        public string? Name { get; set; }
        public string? PriceLevelType { get; set; }
        public bool? IsActive { get; set; }
        public string? PriceLevelPerItemRetItemRefListId { get; set; }
        public string? PriceLevelPerItemRetItemRefFullName { get; set; }
        public decimal? PriceLevelPerItemRetCustomPrice { get; set; }
        public float? PriceLevelPerItemRetCustomPricePercent { get; set; }
        public string? PriceLevelPerItemRetCurrencyRefListId { get; set; }
        public string? PriceLevelPerItemRetCurrencyRefFullName { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual PriceLevel? PriceLevel { get; set; }
        public virtual Currency? PriceLevelPerItemRetCurrencyRefList { get; set; }
        public virtual Item? PriceLevelPerItemRetItemRefList { get; set; }
    }
}
