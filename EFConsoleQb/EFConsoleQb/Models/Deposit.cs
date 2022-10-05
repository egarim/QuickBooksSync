using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Deposit
    {
        public Deposit()
        {
            DepositLineItems = new HashSet<DepositLineItem>();
        }

        public string Id { get; set; } = null!;
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
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public float? ExchangeRate { get; set; }
        public string? CustomFields { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }
        public string? Payee { get; set; }
        public string? PayeeId { get; set; }

        public virtual Account? CashBackAccountNavigation { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Account? DepositToAccountNavigation { get; set; }
        public virtual Vendor? PayeeNavigation { get; set; }
        public virtual ICollection<DepositLineItem> DepositLineItems { get; set; }
    }
}
