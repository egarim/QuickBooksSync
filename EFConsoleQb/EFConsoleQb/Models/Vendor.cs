using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            BillExpenseItems = new HashSet<BillExpenseItem>();
            BillLineItems = new HashSet<BillLineItem>();
            BillPaymentChecks = new HashSet<BillPaymentCheck>();
            BillPaymentChecksAppliedTos = new HashSet<BillPaymentChecksAppliedTo>();
            BillPaymentCreditCards = new HashSet<BillPaymentCreditCard>();
            BillPaymentCreditCardsAppliedTos = new HashSet<BillPaymentCreditCardsAppliedTo>();
            Bills = new HashSet<Bill>();
            CheckExpenseItems = new HashSet<CheckExpenseItem>();
            CheckLineItems = new HashSet<CheckLineItem>();
            Checks = new HashSet<Check>();
            CreditCardChargeExpenseItems = new HashSet<CreditCardChargeExpenseItem>();
            CreditCardChargeLineItems = new HashSet<CreditCardChargeLineItem>();
            CreditCardCharges = new HashSet<CreditCardCharge>();
            CreditCardCreditExpenseItems = new HashSet<CreditCardCreditExpenseItem>();
            CreditCardCreditLineItems = new HashSet<CreditCardCreditLineItem>();
            CreditCardCredits = new HashSet<CreditCardCredit>();
            DepositLineItems = new HashSet<DepositLineItem>();
            Deposits = new HashSet<Deposit>();
            ItemLineItems = new HashSet<ItemLineItem>();
            ItemReceiptExpenseItems = new HashSet<ItemReceiptExpenseItem>();
            ItemReceiptLineItems = new HashSet<ItemReceiptLineItem>();
            ItemReceiptLinkedTransactions = new HashSet<ItemReceiptLinkedTransaction>();
            ItemReceipts = new HashSet<ItemReceipt>();
            Items = new HashSet<Item>();
            PurchaseOrderLineItems = new HashSet<PurchaseOrderLineItem>();
            PurchaseOrderLinkedTransactions = new HashSet<PurchaseOrderLinkedTransaction>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesTaxItems = new HashSet<SalesTaxItem>();
            VendorCreditExpenseItems = new HashSet<VendorCreditExpenseItem>();
            VendorCreditLineItems = new HashSet<VendorCreditLineItem>();
            VendorCreditLinkedTransactions = new HashSet<VendorCreditLinkedTransaction>();
            VendorCredits = new HashSet<VendorCredit>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Salutation { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleInitial { get; set; }
        public string? LastName { get; set; }
        public string? Company { get; set; }
        public string? Contact { get; set; }
        public string? AccountNumber { get; set; }
        public string? Type { get; set; }
        public string? TypeId { get; set; }
        public float? CreditLimit { get; set; }
        public string? TaxIdentity { get; set; }
        public string? SalesTaxCountry { get; set; }
        public string? AlternateContact { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? AlternatePhone { get; set; }
        public string? Email { get; set; }
        public string? Cc { get; set; }
        public string? Notes { get; set; }
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
        public string? ShippingAddress { get; set; }
        public string? ShippingLine1 { get; set; }
        public string? ShippingLine2 { get; set; }
        public string? ShippingLine3 { get; set; }
        public string? ShippingLine4 { get; set; }
        public string? ShippingLine5 { get; set; }
        public string? ShippingCity { get; set; }
        public string? ShippingState { get; set; }
        public string? ShippingPostalCode { get; set; }
        public string? ShippingCountry { get; set; }
        public string? ShippingNote { get; set; }
        public float? Balance { get; set; }
        public string? Terms { get; set; }
        public string? TermsId { get; set; }
        public bool? EligibleFor1099 { get; set; }
        public string? NameOnCheck { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public bool? IsActive { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }
        public string? PrefillAccountId1 { get; set; }
        public string? PrefillAccountName1 { get; set; }
        public string? PrefillAccountId2 { get; set; }
        public string? PrefillAccountName2 { get; set; }
        public string? PrefillAccountId3 { get; set; }
        public string? PrefillAccountName3 { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual ICollection<BillExpenseItem> BillExpenseItems { get; set; }
        public virtual ICollection<BillLineItem> BillLineItems { get; set; }
        public virtual ICollection<BillPaymentCheck> BillPaymentChecks { get; set; }
        public virtual ICollection<BillPaymentChecksAppliedTo> BillPaymentChecksAppliedTos { get; set; }
        public virtual ICollection<BillPaymentCreditCard> BillPaymentCreditCards { get; set; }
        public virtual ICollection<BillPaymentCreditCardsAppliedTo> BillPaymentCreditCardsAppliedTos { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<CheckExpenseItem> CheckExpenseItems { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItems { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<CreditCardChargeExpenseItem> CreditCardChargeExpenseItems { get; set; }
        public virtual ICollection<CreditCardChargeLineItem> CreditCardChargeLineItems { get; set; }
        public virtual ICollection<CreditCardCharge> CreditCardCharges { get; set; }
        public virtual ICollection<CreditCardCreditExpenseItem> CreditCardCreditExpenseItems { get; set; }
        public virtual ICollection<CreditCardCreditLineItem> CreditCardCreditLineItems { get; set; }
        public virtual ICollection<CreditCardCredit> CreditCardCredits { get; set; }
        public virtual ICollection<DepositLineItem> DepositLineItems { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<ItemLineItem> ItemLineItems { get; set; }
        public virtual ICollection<ItemReceiptExpenseItem> ItemReceiptExpenseItems { get; set; }
        public virtual ICollection<ItemReceiptLineItem> ItemReceiptLineItems { get; set; }
        public virtual ICollection<ItemReceiptLinkedTransaction> ItemReceiptLinkedTransactions { get; set; }
        public virtual ICollection<ItemReceipt> ItemReceipts { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<PurchaseOrderLineItem> PurchaseOrderLineItems { get; set; }
        public virtual ICollection<PurchaseOrderLinkedTransaction> PurchaseOrderLinkedTransactions { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesTaxItem> SalesTaxItems { get; set; }
        public virtual ICollection<VendorCreditExpenseItem> VendorCreditExpenseItems { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItems { get; set; }
        public virtual ICollection<VendorCreditLinkedTransaction> VendorCreditLinkedTransactions { get; set; }
        public virtual ICollection<VendorCredit> VendorCredits { get; set; }
    }
}
