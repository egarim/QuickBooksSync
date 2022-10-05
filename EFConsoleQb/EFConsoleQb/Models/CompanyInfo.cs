using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CompanyInfo
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Address { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        public string? Line4 { get; set; }
        public string? Line5 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Note { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Ssn { get; set; }
        public string? Taxform { get; set; }
        public string? Website { get; set; }
        public string? FirstMonthFiscal { get; set; }
        public string? FirstMonthTax { get; set; }
        public string? LegalAddress { get; set; }
        public string? LegalCity { get; set; }
        public string? LegalCountry { get; set; }
        public string? LegalState { get; set; }
        public string? LegalZip { get; set; }
        public string? LegalName { get; set; }
        public string? ShippingAddress { get; set; }
        public string? ShippingLine1 { get; set; }
        public string? ShippingLine2 { get; set; }
        public string? ShippingLine3 { get; set; }
        public string? ShippingLine4 { get; set; }
        public string? ShippingLine5 { get; set; }
        public string? ShippingCity { get; set; }
        public string? ShippingState { get; set; }
        public string? ShippingPostalCode { get; set; }
        public string? ShippingCountry { get; set; }
        public string? ShippingNote { get; set; }
        public string? OpenedCompanyFile { get; set; }
    }
}
