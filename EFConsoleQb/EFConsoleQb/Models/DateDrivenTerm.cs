using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class DateDrivenTerm
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public int? DayOfMonthDue { get; set; }
        public int? DueNextMonthDays { get; set; }
        public int? DiscountDayOfMonth { get; set; }
        public float? DiscountPct { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
    }
}
