using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class JournalEntryLine
    {
        public string Id { get; set; } = null!;
        public string? JournalEntryId { get; set; }
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public DateTime? Date { get; set; }
        public int? CreditLineCount { get; set; }
        public int? DebitLineCount { get; set; }
        public string? LineId { get; set; }
        public string? LineType { get; set; }
        public string? LineAccount { get; set; }
        public string? LineAccountId { get; set; }
        public decimal? LineAmount { get; set; }
        public string? LineEntityName { get; set; }
        public string? LineEntityId { get; set; }
        public string? LineMemo { get; set; }
        public string? LineClass { get; set; }
        public string? LineClassId { get; set; }
        public string? LineStatus { get; set; }
        public string? LineTaxItem { get; set; }
        public string? LineTaxItemId { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public float? ExchangeRate { get; set; }
        public bool? IsHomeCurrencyAdjustment { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual JournalEntry? JournalEntry { get; set; }
        public virtual Account? LineAccountNavigation { get; set; }
        public virtual Class? LineClassNavigation { get; set; }
        public virtual SalesTaxItem? LineTaxItemNavigation { get; set; }
    }
}
