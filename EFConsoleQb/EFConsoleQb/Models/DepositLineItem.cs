using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class DepositLineItem
    {
        public string Id { get; set; } = null!;
        public string? DepositId { get; set; }
        public int? TxnNumber { get; set; }
        public DateTime? Date { get; set; }
        public string? CashBackAccount { get; set; }
        public string? CashBackAccountId { get; set; }
        public decimal? CashBackAmount { get; set; }
        public string? CashBackId { get; set; }
        public string? CashBackMemo { get; set; }
        public string? DepositToAccount { get; set; }
        public string? DepositToAccountId { get; set; }
        public string? Memo { get; set; }
        public float? TotalDeposit { get; set; }
        public string? CustomFields { get; set; }
        public string? ItemLineId { get; set; }
        public string? ItemAccount { get; set; }
        public string? ItemAccountId { get; set; }
        public decimal? ItemAmount { get; set; }
        public string? ItemCheckNumber { get; set; }
        public string? ItemClass { get; set; }
        public string? ItemClassId { get; set; }
        public string? ItemEntityName { get; set; }
        public string? ItemEntityId { get; set; }
        public string? ItemMemo { get; set; }
        public string? ItemPaymentMethod { get; set; }
        public string? ItemPaymentMethodId { get; set; }
        public string? ItemPaymentId { get; set; }
        public string? ItemPaymentLineId { get; set; }
        public string? ItemRefId { get; set; }
        public string? ItemTxnType { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public float? ExchangeRate { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }
        public string? Payee { get; set; }
        public string? PayeeId { get; set; }

        public virtual Account? CashBackAccountNavigation { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Deposit? Deposit { get; set; }
        public virtual Account? DepositToAccountNavigation { get; set; }
        public virtual Account? ItemAccountNavigation { get; set; }
        public virtual Class? ItemClassNavigation { get; set; }
        public virtual PaymentMethod? ItemPaymentMethodNavigation { get; set; }
        public virtual Vendor? PayeeNavigation { get; set; }
    }
}
