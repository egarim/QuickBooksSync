using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class EmployeeEarning
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? PayPeriod { get; set; }
        public string? EmployeeId { get; set; }
        public string? EarningsId { get; set; }
        public string? EarningsWageName { get; set; }
        public string? EarningsWageId { get; set; }
        public float? EarningsRate { get; set; }
        public string? EarningsRatePercent { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
