using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class VehicleMileage
    {
        public string Id { get; set; } = null!;
        public string? VehicleRefFullName { get; set; }
        public string? VehicleRefListId { get; set; }
        public string? CustomerRefFullName { get; set; }
        public string? CustomerRefListId { get; set; }
        public string? ItemRefFullName { get; set; }
        public string? ItemRefListId { get; set; }
        public string? ClassRefFullName { get; set; }
        public string? ClassRefListId { get; set; }
        public string? TripStartDate { get; set; }
        public string? TripEndDate { get; set; }
        public int? OdometerStart { get; set; }
        public int? OdometerEnd { get; set; }
        public float? TotalMiles { get; set; }
        public string? Notes { get; set; }
        public string? BillableStatus { get; set; }
        public float? StandardMileageRate { get; set; }
        public float? StandardMileageTotalAmount { get; set; }
        public float? BillableRate { get; set; }
        public decimal? BillableAmount { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual Class? ClassRefList { get; set; }
        public virtual Customer? CustomerRefList { get; set; }
        public virtual Item? ItemRefList { get; set; }
    }
}
