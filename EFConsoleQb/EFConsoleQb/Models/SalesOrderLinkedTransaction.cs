using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class SalesOrderLinkedTransaction
    {
        public string Id { get; set; } = null!;
        public string? SalesOrderId { get; set; }
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public DateTime? Date { get; set; }
        public string? TransactionId { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? TransactionReferenceNumber { get; set; }
        public string? TransactionType { get; set; }
        public string? TransactionLinkType { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual SalesOrder? SalesOrder { get; set; }
        public virtual Invoice? Transaction { get; set; }
    }
}
