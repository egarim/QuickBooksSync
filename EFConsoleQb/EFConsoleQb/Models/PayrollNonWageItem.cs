using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class PayrollNonWageItem
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public string? NonWageType { get; set; }
        public string? ExpenseAccountRefFullName { get; set; }
        public string? ExpenseAccountRefListId { get; set; }
        public string? LiabilityAccountRefFullName { get; set; }
        public string? LiabilityAccountRefListId { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual Account? ExpenseAccountRefList { get; set; }
        public virtual Account? LiabilityAccountRefList { get; set; }
    }
}
