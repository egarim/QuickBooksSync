using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CustomerShippingAddress
    {
        public string Id { get; set; } = null!;
        public string? CustomerId { get; set; }
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? ShipToName { get; set; }
        public string? ShipToAddr1 { get; set; }
        public string? ShipToAddr2 { get; set; }
        public string? ShipToAddr3 { get; set; }
        public string? ShipToAddr4 { get; set; }
        public string? ShipToAddr5 { get; set; }
        public string? ShipToCity { get; set; }
        public string? ShipToState { get; set; }
        public string? ShipToPostalCode { get; set; }
        public string? ShipToCountry { get; set; }
        public string? ShipToNote { get; set; }
        public bool? ShipToDefaultShipTo { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
