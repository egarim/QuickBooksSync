using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class StatementCharge
    {
        public StatementCharge()
        {
            StatementChargeLinkedTransactions = new HashSet<StatementChargeLinkedTransaction>();
        }

        public string Id { get; set; } = null!;
        public int? TxnNumber { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public DateTime? Date { get; set; }
        public string? ItemName { get; set; }
        public string? ItemId { get; set; }
        public float? Quantity { get; set; }
        public string? UnitOfMeasure { get; set; }
        public string? OverrideUnitOfMeasure { get; set; }
        public string? OverrideUnitOfMeasureId { get; set; }
        public float? Rate { get; set; }
        public decimal? Amount { get; set; }
        public float? Balance { get; set; }
        public string? Description { get; set; }
        public string? AccountsReceivable { get; set; }
        public string? AccountsReceivableId { get; set; }
        public string? Class { get; set; }
        public string? ClassId { get; set; }
        public DateTime? BilledDate { get; set; }
        public DateTime? DueDate { get; set; }
        public bool? IsPaid { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountsReceivableNavigation { get; set; }
        public virtual Class? ClassNavigation { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Item? Item { get; set; }
        public virtual UnitOfMeasure? OverrideUnitOfMeasureNavigation { get; set; }
        public virtual ICollection<StatementChargeLinkedTransaction> StatementChargeLinkedTransactions { get; set; }
    }
}
