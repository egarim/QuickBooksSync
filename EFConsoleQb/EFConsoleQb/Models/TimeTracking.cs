using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class TimeTracking
    {
        public string Id { get; set; } = null!;
        public string? BillableStatus { get; set; }
        public DateTime? Date { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public string? Duration { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeId { get; set; }
        public string? Notes { get; set; }
        public string? Class { get; set; }
        public string? ClassId { get; set; }
        public string? PayrollWageItemName { get; set; }
        public string? PayrollWageItemId { get; set; }
        public string? ServiceItemName { get; set; }
        public string? ServiceItemId { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Class? ClassNavigation { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual PayrollWageItem? PayrollWageItem { get; set; }
        public virtual Item? ServiceItem { get; set; }
    }
}
