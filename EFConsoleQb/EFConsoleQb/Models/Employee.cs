using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeEarnings = new HashSet<EmployeeEarning>();
            TimeTrackings = new HashSet<TimeTracking>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Salutation { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleInitial { get; set; }
        public string? LastName { get; set; }
        public string? JobTitle { get; set; }
        public string? AccountNumber { get; set; }
        public string? Ssn { get; set; }
        public string? EmployeeType { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? AlternatePhone { get; set; }
        public string? Email { get; set; }
        public string? PrintAs { get; set; }
        public string? MobilePhone { get; set; }
        public string? Pager { get; set; }
        public string? PagerPin { get; set; }
        public string? Fax { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Uscitizen { get; set; }
        public string? Ethnicity { get; set; }
        public string? Disabled { get; set; }
        public string? DisabilityDescription { get; set; }
        public string? FormOnFile { get; set; }
        public string? Usveteran { get; set; }
        public string? MilitaryStatus { get; set; }
        public DateTime? HiredDate { get; set; }
        public bool? IsActive { get; set; }
        public string? Notes { get; set; }
        public string? PayPeriod { get; set; }
        public string? PayrollClassName { get; set; }
        public string? PayrollClassId { get; set; }
        public string? Phone { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string? TimeDataForPaychecks { get; set; }
        public string? SickTimeAccrualPeriod { get; set; }
        public DateTime? SickTimeAccrualStartDate { get; set; }
        public string? SickTimeAccrued { get; set; }
        public string? SickTimeAvailable { get; set; }
        public string? SickTimeMaximum { get; set; }
        public bool? SickTimeYearlyReset { get; set; }
        public string? SickTimeUsed { get; set; }
        public string? VacationTimeAccrualPeriod { get; set; }
        public DateTime? VacationTimeAccrualStartDate { get; set; }
        public string? VacationTimeAccrued { get; set; }
        public string? VacationTimeAvailable { get; set; }
        public string? VacationTimeMaximum { get; set; }
        public bool? VacationTimeYearlyReset { get; set; }
        public string? VacationTimeUsed { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Class? PayrollClass { get; set; }
        public virtual ICollection<EmployeeEarning> EmployeeEarnings { get; set; }
        public virtual ICollection<TimeTracking> TimeTrackings { get; set; }
    }
}
