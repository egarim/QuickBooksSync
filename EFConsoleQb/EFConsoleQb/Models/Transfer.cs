using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Transfer
    {
        public string Id { get; set; } = null!;
        public string? TxnNumber { get; set; }
        public DateTime? TxnDate { get; set; }
        public string? TransferFromAccountRefListId { get; set; }
        public string? TransferFromAccountRefFullName { get; set; }
        public float? FromAccountBalance { get; set; }
        public string? TransferToAccountRefListId { get; set; }
        public string? TransferToAccountRefFullName { get; set; }
        public float? ToAccountBalance { get; set; }
        public string? ClassRefListId { get; set; }
        public string? ClassRefFullName { get; set; }
        public decimal? Amount { get; set; }
        public string? Memo { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
        public string? EditSequence { get; set; }

        public virtual Class? ClassRefList { get; set; }
        public virtual Account? TransferFromAccountRefList { get; set; }
        public virtual Account? TransferToAccountRefList { get; set; }
    }
}
