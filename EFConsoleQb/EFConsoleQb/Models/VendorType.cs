using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class VendorType
    {
        public VendorType()
        {
            InverseParentRefList = new HashSet<VendorType>();
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

        public virtual VendorType? ParentRefList { get; set; }
        public virtual ICollection<VendorType> InverseParentRefList { get; set; }
    }
}
