using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class JobType
    {
        public JobType()
        {
            Customers = new HashSet<Customer>();
            InverseParentRefList = new HashSet<JobType>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public bool? IsActive { get; set; }
        public string? ParentRefFullName { get; set; }
        public string? ParentRefListId { get; set; }
        public int? Sublevel { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual JobType? ParentRefList { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<JobType> InverseParentRefList { get; set; }
    }
}
