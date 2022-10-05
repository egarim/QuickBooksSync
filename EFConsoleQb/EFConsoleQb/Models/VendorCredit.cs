using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class VendorCredit
    {
        public VendorCredit()
        {
            VendorCreditExpenseItems = new HashSet<VendorCreditExpenseItem>();
            VendorCreditLineItems = new HashSet<VendorCreditLineItem>();
            VendorCreditLinkedTransactions = new HashSet<VendorCreditLinkedTransaction>();
        }

        public string Id { get; set; } = null!;
        public string? VendorName { get; set; }
        public string? VendorId { get; set; }
        public DateTime? Date { get; set; }
        public int? TxnNumber { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? AccountsPayable { get; set; }
        public string? AccountsPayableId { get; set; }
        public decimal? Amount { get; set; }
        public string? Memo { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? TaxCode { get; set; }
        public string? TaxCodeId { get; set; }
        public string? ExchangeRate { get; set; }
        public int? ItemCount { get; set; }
        public string? ItemAggregate { get; set; }
        public int? ExpenseItemCount { get; set; }
        public string? ExpenseItemAggregate { get; set; }
        public int? TransactionCount { get; set; }
        public string? TransactionAggregate { get; set; }
        public string? CustomFields { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountsPayableNavigation { get; set; }
        public virtual SalesTaxCode? TaxCodeNavigation { get; set; }
        public virtual Vendor? Vendor { get; set; }
        public virtual ICollection<VendorCreditExpenseItem> VendorCreditExpenseItems { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItems { get; set; }
        public virtual ICollection<VendorCreditLinkedTransaction> VendorCreditLinkedTransactions { get; set; }
    }
}
