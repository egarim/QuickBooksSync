using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class WorkersCompCodeLine
    {
        public string Id { get; set; } = null!;
        public string? WorkersCompCodeId { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public float? CurrentRate { get; set; }
        public DateTime? CurrentEffectiveDate { get; set; }
        public float? NextRate { get; set; }
        public DateTime? NextEffectiveDate { get; set; }
        public float? RateHistoryRate { get; set; }
        public DateTime? RateHistoryEffectiveDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }
    }
}
