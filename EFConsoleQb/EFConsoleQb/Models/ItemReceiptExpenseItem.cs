using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ItemReceiptExpenseItem
    {
        public string Id { get; set; } = null!;
        public string? ItemReceiptId { get; set; }
        public string? VendorName { get; set; }
        public string? VendorId { get; set; }
        public DateTime? Date { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? AccountsPayable { get; set; }
        public string? AccountsPayableId { get; set; }
        public string? Memo { get; set; }
        public string? Amount { get; set; }
        public int? TxnNumber { get; set; }
        public float? ExchangeRate { get; set; }
        public bool? IsTaxIncluded { get; set; }
        public string? ExpenseLineId { get; set; }
        public string? ExpenseLineNumber { get; set; }
        public string? ExpenseAccount { get; set; }
        public string? ExpenseAccountId { get; set; }
        public decimal? ExpenseAmount { get; set; }
        public string? ExpenseBillableStatus { get; set; }
        public string? ExpenseCustomer { get; set; }
        public string? ExpenseCustomerId { get; set; }
        public string? ExpenseClass { get; set; }
        public string? ExpenseClassId { get; set; }
        public string? ExpenseTaxCode { get; set; }
        public string? ExpenseTaxCodeId { get; set; }
        public string? ExpenseCustomFields { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Account? AccountsPayableNavigation { get; set; }
        public virtual Account? ExpenseAccountNavigation { get; set; }
        public virtual Class? ExpenseClassNavigation { get; set; }
        public virtual Customer? ExpenseCustomerNavigation { get; set; }
        public virtual SalesTaxCode? ExpenseTaxCodeNavigation { get; set; }
        public virtual ItemReceipt? ItemReceipt { get; set; }
        public virtual Vendor? Vendor { get; set; }
    }
}
