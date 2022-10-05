using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class WorkersCompCode
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public float? CurrentRate { get; set; }
        public DateTime? CurrentEffectiveDate { get; set; }
        public float? NextRate { get; set; }
        public DateTime? NextEffectiveDate { get; set; }
        public string? RateHistory { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }
    }
}
