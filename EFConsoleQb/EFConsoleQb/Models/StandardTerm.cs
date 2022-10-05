using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class StandardTerm
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public int? StdDueDays { get; set; }
        public int? StdDiscountDays { get; set; }
        public float? DiscountPct { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
    }
}
