using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CreditCardCharge
    {
        public CreditCardCharge()
        {
            CreditCardChargeExpenseItems = new HashSet<CreditCardChargeExpenseItem>();
            CreditCardChargeLineItems = new HashSet<CreditCardChargeLineItem>();
        }

        public string Id { get; set; } = null!;
        public DateTime? Date { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? AccountName { get; set; }
        public string? AccountId { get; set; }
        public string? Memo { get; set; }
        public string? PayeeName { get; set; }
        public string? PayeeId { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public int? ExpenseItemCount { get; set; }
        public string? ExpenseItemAggregate { get; set; }
        public string? CustomFields { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Vendor? Payee { get; set; }
        public virtual ICollection<CreditCardChargeExpenseItem> CreditCardChargeExpenseItems { get; set; }
        public virtual ICollection<CreditCardChargeLineItem> CreditCardChargeLineItems { get; set; }
    }
}
