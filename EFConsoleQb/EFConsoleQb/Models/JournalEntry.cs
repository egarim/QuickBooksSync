using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class JournalEntry
    {
        public JournalEntry()
        {
            JournalEntryLines = new HashSet<JournalEntryLine>();
        }

        public string Id { get; set; } = null!;
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public DateTime? Date { get; set; }
        public int? CreditLineCount { get; set; }
        public int? DebitLineCount { get; set; }
        public string? FirstCreditAccount { get; set; }
        public decimal? FirstCreditAmount { get; set; }
        public string? FirstCreditMemo { get; set; }
        public string? FirstCreditEntityName { get; set; }
        public string? FirstCreditEntityId { get; set; }
        public string? FirstDebitAccount { get; set; }
        public decimal? FirstDebitAmount { get; set; }
        public string? FirstDebitMemo { get; set; }
        public string? FirstDebitEntityName { get; set; }
        public string? FirstDebitEntityId { get; set; }
        public string? LineAggregate { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public float? ExchangeRate { get; set; }
        public bool? IsHomeCurrencyAdjustment { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual ICollection<JournalEntryLine> JournalEntryLines { get; set; }
    }
}
