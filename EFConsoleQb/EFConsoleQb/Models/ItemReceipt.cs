using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ItemReceipt
    {
        public ItemReceipt()
        {
            ItemReceiptExpenseItems = new HashSet<ItemReceiptExpenseItem>();
            ItemReceiptLineItems = new HashSet<ItemReceiptLineItem>();
            ItemReceiptLinkedTransactions = new HashSet<ItemReceiptLinkedTransaction>();
        }

        public string Id { get; set; } = null!;
        public string? VendorName { get; set; }
        public string? VendorId { get; set; }
        public DateTime? Date { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? AccountsPayable { get; set; }
        public string? AccountsPayableId { get; set; }
        public string? Memo { get; set; }
        public decimal? Amount { get; set; }
        public int? TxnNumber { get; set; }
        public float? ExchangeRate { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public int? ExpenseItemCount { get; set; }
        public string? ExpenseItemAggregate { get; set; }
        public int? TransactionCount { get; set; }
        public string? TransactionAggregate { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountsPayableNavigation { get; set; }
        public virtual Vendor? Vendor { get; set; }
        public virtual ICollection<ItemReceiptExpenseItem> ItemReceiptExpenseItems { get; set; }
        public virtual ICollection<ItemReceiptLineItem> ItemReceiptLineItems { get; set; }
        public virtual ICollection<ItemReceiptLinkedTransaction> ItemReceiptLinkedTransactions { get; set; }
    }
}
