using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            Customers = new HashSet<Customer>();
            InverseParent = new HashSet<CustomerType>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? ParentName { get; set; }
        public string? ParentId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual CustomerType? Parent { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<CustomerType> InverseParent { get; set; }
    }
}
