using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class BillLinkedTransaction
    {
        public string Id { get; set; } = null!;
        public string? BillId { get; set; }
        public string? TransactionId { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? TransactionReferenceNumber { get; set; }
        public string? TransactionType { get; set; }
        public string? TransactionLinkType { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Bill? Bill { get; set; }
    }
}
