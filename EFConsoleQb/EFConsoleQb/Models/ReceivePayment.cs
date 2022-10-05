using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ReceivePayment
    {
        public ReceivePayment()
        {
            ReceivePaymentsAppliedTos = new HashSet<ReceivePaymentsAppliedTo>();
        }

        public string Id { get; set; } = null!;
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public DateTime? Date { get; set; }
        public decimal? UnusedPayment { get; set; }
        public decimal? Amount { get; set; }
        public string? AccountsReceivableName { get; set; }
        public string? AccountsReceivableId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerId { get; set; }
        public string? DepositToAccountName { get; set; }
        public string? DepositToAccountId { get; set; }
        public string? PaymentMethodName { get; set; }
        public string? PaymentMethodId { get; set; }
        public string? Memo { get; set; }
        public float? ExchangeRate { get; set; }
        public decimal? TotalAmountInHomeCurrency { get; set; }
        public string? AppliedToAggregate { get; set; }
        public string? CustomFields { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountsReceivable { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Account? DepositToAccount { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual ICollection<ReceivePaymentsAppliedTo> ReceivePaymentsAppliedTos { get; set; }
    }
}
