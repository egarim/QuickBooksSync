using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CustomerContact
    {
        public string Id { get; set; } = null!;
        public string? CustomerId { get; set; }
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? ContactId { get; set; }
        public string? ContactEditSequence { get; set; }
        public string? ContactFirstName { get; set; }
        public string? ContactMiddleName { get; set; }
        public string? ContactLastName { get; set; }
        public string? ContactJobTitle { get; set; }
        public string? ContactSalutation { get; set; }
        public string? ContactMethods { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
