using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class BillPaymentCreditCardsAppliedTo
    {
        public string Id { get; set; } = null!;
        public string? BillPaymentId { get; set; }
        public string? PayeeName { get; set; }
        public string? PayeeId { get; set; }
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public DateTime? Date { get; set; }
        public string? AccountsPayable { get; set; }
        public string? AccountsPayableId { get; set; }
        public string? CreditCardName { get; set; }
        public string? CreditCardId { get; set; }
        public bool? IsToBePrinted { get; set; }
        public string? Memo { get; set; }
        public float? ExchangeRate { get; set; }
        public float? AmountInHomeCurrency { get; set; }
        public string? CustomFields { get; set; }
        public string? AppliedToRefId { get; set; }
        public decimal? AppliedToAmount { get; set; }
        public float? AppliedToBalanceRemaining { get; set; }
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

        public virtual Account? AccountsPayableNavigation { get; set; }
        public virtual CreditMemo? AppliedToCreditMemo { get; set; }
        public virtual Account? AppliedToDiscountAccount { get; set; }
        public virtual BillPaymentCreditCard? BillPayment { get; set; }
        public virtual Vendor? Payee { get; set; }
    }
}
