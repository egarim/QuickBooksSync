using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Transaction
    {
        public string Id { get; set; } = null!;
        public string TxnLineId { get; set; } = null!;
        public string? Type { get; set; }
        public DateTime? Date { get; set; }
        public string? Entity { get; set; }
        public string? EntityId { get; set; }
        public string? AccountName { get; set; }
        public string? AccountId { get; set; }
        public string? ReferenceNumber { get; set; }
        public decimal? Amount { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public float? ExchangeRate { get; set; }
        public decimal? AmountInHomeCurrency { get; set; }
        public string? Memo { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Currency? Currency { get; set; }
    }
}
