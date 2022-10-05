using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ReceivePaymentsAppliedTo
    {
        public string Id { get; set; } = null!;
        public string? ReceivePaymentId { get; set; }
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
        public string? AutoApply { get; set; }
        public string? CustomFields { get; set; }
        public string? AppliedToRefId { get; set; }
        public decimal? AppliedToAmount { get; set; }
        public float? AppliedToBalanceRemaining { get; set; }
        public decimal? AppliedToCreditAppliedAmount { get; set; }
        public string? AppliedToCreditMemoId { get; set; }
        public string? AppliedToDiscountAccountName { get; set; }
        public string? AppliedToDiscountAccountId { get; set; }
        public decimal? AppliedToDiscountAmount { get; set; }
        public decimal? AppliedToPaymentAmount { get; set; }
        public string? AppliedToReferenceNumber { get; set; }
        public DateTime? AppliedToTxnDate { get; set; }
        public string? AppliedToTxnType { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountsReceivable { get; set; }
        public virtual CreditMemo? AppliedToCreditMemo { get; set; }
        public virtual Account? AppliedToDiscountAccount { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Account? DepositToAccount { get; set; }
        public virtual PaymentMethod? PaymentMethod { get; set; }
        public virtual ReceivePayment? ReceivePayment { get; set; }
    }
}
