using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Check
    {
        public Check()
        {
            CheckExpenseItems = new HashSet<CheckExpenseItem>();
            CheckLineItems = new HashSet<CheckLineItem>();
        }

        public string Id { get; set; } = null!;
        public string? ReferenceNumber { get; set; }
        public int? TxnNumber { get; set; }
        public string? Account { get; set; }
        public string? AccountId { get; set; }
        public string? Payee { get; set; }
        public string? PayeeId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public string? Memo { get; set; }
        public string? Address { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        public string? Line4 { get; set; }
        public string? Line5 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Note { get; set; }
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public int? ExpenseItemCount { get; set; }
        public string? ExpenseItemAggregate { get; set; }
        public bool? IsToBePrinted { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public float? ExchangeRate { get; set; }
        public string? CustomFields { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountNavigation { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Vendor? PayeeNavigation { get; set; }
        public virtual ICollection<CheckExpenseItem> CheckExpenseItems { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItems { get; set; }
    }
}
