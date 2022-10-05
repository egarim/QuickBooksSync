using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ReceivePaymentToDeposit
    {
        public string Id { get; set; } = null!;
        public string? TxnType { get; set; }
        public string? TxnLineId { get; set; }
        public string? CustomerRefListId { get; set; }
        public string? CustomerRefFullName { get; set; }
        public DateTime? TxnDate { get; set; }
        public string? RefNumber { get; set; }
        public decimal? Amount { get; set; }
        public string? CurrencyId { get; set; }
        public string? CurrencyName { get; set; }
        public float? ExchangeRate { get; set; }
        public float? AmountInHomeCurrency { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual Customer? CustomerRefList { get; set; }
    }
}
