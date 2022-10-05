using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class VendorCreditLinkedTransaction
    {
        public string Id { get; set; } = null!;
        public string? VendorCreditId { get; set; }
        public string? VendorName { get; set; }
        public string? VendorId { get; set; }
        public DateTime? Date { get; set; }
        public int? TxnNumber { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? TransactionId { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? TransactionReferenceNumber { get; set; }
        public string? TransactionType { get; set; }
        public string? TransactionLinkType { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Bill? Transaction { get; set; }
        public virtual Vendor? Vendor { get; set; }
        public virtual VendorCredit? VendorCredit { get; set; }
    }
}
