using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class OtherName
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public string? CompanyName { get; set; }
        public string? Salutation { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? OtherNameAddressAddr1 { get; set; }
        public string? OtherNameAddressAddr2 { get; set; }
        public string? OtherNameAddressAddr3 { get; set; }
        public string? OtherNameAddressAddr4 { get; set; }
        public string? OtherNameAddressAddr5 { get; set; }
        public string? OtherNameAddressCity { get; set; }
        public string? OtherNameAddressState { get; set; }
        public string? OtherNameAddressPostalCode { get; set; }
        public string? OtherNameAddressCountry { get; set; }
        public string? OtherNameAddressNote { get; set; }
        public string? Phone { get; set; }
        public string? AltPhone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Contact { get; set; }
        public string? AltContact { get; set; }
        public string? AccountNumber { get; set; }
        public string? Notes { get; set; }
        public string? ExternalGuid { get; set; }
        public string? CustomFields { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }
    }
}
