using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillExpenseItems = new HashSet<BillExpenseItem>();
            BillLineItems = new HashSet<BillLineItem>();
            BillLinkedTransactions = new HashSet<BillLinkedTransaction>();
            VendorCreditLinkedTransactions = new HashSet<VendorCreditLinkedTransaction>();
        }

        public string Id { get; set; } = null!;
        public string? VendorName { get; set; }
        public string? VendorId { get; set; }
        public string? ReferenceNumber { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public int? TxnNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Terms { get; set; }
        public string? TermsId { get; set; }
        public string? AccountsPayable { get; set; }
        public string? AccountsPayableId { get; set; }
        public string? Memo { get; set; }
        public bool? IsPaid { get; set; }
        public float? ExchangeRate { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public int? ExpenseItemCount { get; set; }
        public string? ExpenseItemAggregate { get; set; }
        public int? TransactionCount { get; set; }
        public string? TransactionAggregate { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public string? CustomFields { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }
        public decimal? OpenAmount { get; set; }

        public virtual Account? AccountsPayableNavigation { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Vendor? Vendor { get; set; }
        public virtual ICollection<BillExpenseItem> BillExpenseItems { get; set; }
        public virtual ICollection<BillLineItem> BillLineItems { get; set; }
        public virtual ICollection<BillLinkedTransaction> BillLinkedTransactions { get; set; }
        public virtual ICollection<VendorCreditLinkedTransaction> VendorCreditLinkedTransactions { get; set; }
    }
}
