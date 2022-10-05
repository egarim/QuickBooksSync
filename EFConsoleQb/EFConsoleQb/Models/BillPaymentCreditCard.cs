using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class BillPaymentCreditCard
    {
        public BillPaymentCreditCard()
        {
            BillPaymentCreditCardsAppliedTos = new HashSet<BillPaymentCreditCardsAppliedTo>();
        }

        public string Id { get; set; } = null!;
        public string? PayeeName { get; set; }
        public string? PayeeId { get; set; }
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public string? AccountsPayable { get; set; }
        public string? AccountsPayableId { get; set; }
        public string? CreditCardName { get; set; }
        public string? CreditCardId { get; set; }
        public string? Memo { get; set; }
        public string? AppliedToAggregate { get; set; }
        public float? ExchangeRate { get; set; }
        public float? AmountInHomeCurrency { get; set; }
        public string? CustomFields { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountsPayableNavigation { get; set; }
        public virtual Vendor? Payee { get; set; }
        public virtual ICollection<BillPaymentCreditCardsAppliedTo> BillPaymentCreditCardsAppliedTos { get; set; }
    }
}
