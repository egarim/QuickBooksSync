using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Customer
    {
        public Customer()
        {
            BillExpenseItems = new HashSet<BillExpenseItem>();
            BillLineItems = new HashSet<BillLineItem>();
            CheckExpenseItems = new HashSet<CheckExpenseItem>();
            CheckLineItems = new HashSet<CheckLineItem>();
            CreditCardChargeExpenseItems = new HashSet<CreditCardChargeExpenseItem>();
            CreditCardChargeLineItems = new HashSet<CreditCardChargeLineItem>();
            CreditCardCreditExpenseItems = new HashSet<CreditCardCreditExpenseItem>();
            CreditCardCreditLineItems = new HashSet<CreditCardCreditLineItem>();
            CreditCardRefunds = new HashSet<CreditCardRefund>();
            CreditMemoLineItems = new HashSet<CreditMemoLineItem>();
            CreditMemoLinkedTransactions = new HashSet<CreditMemoLinkedTransaction>();
            CreditMemos = new HashSet<CreditMemo>();
            CustomerContacts = new HashSet<CustomerContact>();
            CustomerNotes = new HashSet<CustomerNote>();
            CustomerShippingAddresses = new HashSet<CustomerShippingAddress>();
            EstimateLineItems = new HashSet<EstimateLineItem>();
            EstimateLinkedTransactions = new HashSet<EstimateLinkedTransaction>();
            Estimates = new HashSet<Estimate>();
            InventoryAdjustmentLineItems = new HashSet<InventoryAdjustmentLineItem>();
            InventoryAdjustments = new HashSet<InventoryAdjustment>();
            InverseParent = new HashSet<Customer>();
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
            InvoiceLinkedTransactions = new HashSet<InvoiceLinkedTransaction>();
            Invoices = new HashSet<Invoice>();
            ItemReceiptExpenseItems = new HashSet<ItemReceiptExpenseItem>();
            ItemReceiptLineItems = new HashSet<ItemReceiptLineItem>();
            PurchaseOrderLineItems = new HashSet<PurchaseOrderLineItem>();
            ReceivePaymentToDeposits = new HashSet<ReceivePaymentToDeposit>();
            ReceivePayments = new HashSet<ReceivePayment>();
            ReceivePaymentsAppliedTos = new HashSet<ReceivePaymentsAppliedTo>();
            SalesOrderLineItems = new HashSet<SalesOrderLineItem>();
            SalesOrderLinkedTransactions = new HashSet<SalesOrderLinkedTransaction>();
            SalesOrders = new HashSet<SalesOrder>();
            SalesReceiptLineItems = new HashSet<SalesReceiptLineItem>();
            SalesReceipts = new HashSet<SalesReceipt>();
            StatementChargeLinkedTransactions = new HashSet<StatementChargeLinkedTransaction>();
            StatementCharges = new HashSet<StatementCharge>();
            TimeTrackings = new HashSet<TimeTracking>();
            VehicleMileages = new HashSet<VehicleMileage>();
            VendorCreditExpenseItems = new HashSet<VendorCreditExpenseItem>();
            VendorCreditLineItems = new HashSet<VendorCreditLineItem>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? Salutation { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleInitial { get; set; }
        public string? LastName { get; set; }
        public string? AccountNumber { get; set; }
        public string? Company { get; set; }
        public float? Balance { get; set; }
        public float? CustomerBalance { get; set; }
        public string? Contact { get; set; }
        public string? Type { get; set; }
        public string? TypeId { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? AlternateContact { get; set; }
        public string? AlternatePhone { get; set; }
        public string? Email { get; set; }
        public string? Cc { get; set; }
        public string? AdditionalContactInfo { get; set; }
        public string? ContactsAggregate { get; set; }
        public string? ClassName { get; set; }
        public string? ClassId { get; set; }
        public string? Notes { get; set; }
        public string? NotesAggregate { get; set; }
        public string? ParentName { get; set; }
        public string? ParentId { get; set; }
        public int? Sublevel { get; set; }
        public string? JobStatus { get; set; }
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobProjectedEndDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public string? JobDescription { get; set; }
        public string? JobType { get; set; }
        public string? JobTypeId { get; set; }
        public string? CreditCardAddress { get; set; }
        public int? CreditCardExpMonth { get; set; }
        public int? CreditCardExpYear { get; set; }
        public string? CreditCardNameOnCard { get; set; }
        public string? CreditCardNumber { get; set; }
        public string? CreditCardPostalCode { get; set; }
        public float? CreditLimit { get; set; }
        public string? BillingAddress { get; set; }
        public string? BillingLine1 { get; set; }
        public string? BillingLine2 { get; set; }
        public string? BillingLine3 { get; set; }
        public string? BillingLine4 { get; set; }
        public string? BillingLine5 { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingState { get; set; }
        public string? BillingPostalCode { get; set; }
        public string? BillingCountry { get; set; }
        public string? BillingNote { get; set; }
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
        public string? ShippingAggregate { get; set; }
        public string? ResaleNumber { get; set; }
        public string? SalesRep { get; set; }
        public string? SalesRepId { get; set; }
        public string? Terms { get; set; }
        public string? TermsId { get; set; }
        public string? CurrencyName { get; set; }
        public string? CurrencyId { get; set; }
        public string? TaxCode { get; set; }
        public string? TaxCodeId { get; set; }
        public string? TaxItem { get; set; }
        public string? TaxItemId { get; set; }
        public string? SalesTaxCountry { get; set; }
        public string? PriceLevel { get; set; }
        public string? PriceLevelId { get; set; }
        public string? PreferredDeliveryMethod { get; set; }
        public string? PreferredPaymentMethodName { get; set; }
        public string? PreferredPaymentMethodId { get; set; }
        public bool? IsActive { get; set; }
        public string? CustomFields { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual JobType? JobTypeNavigation { get; set; }
        public virtual Customer? Parent { get; set; }
        public virtual PaymentMethod? PreferredPaymentMethod { get; set; }
        public virtual PriceLevel? PriceLevelNavigation { get; set; }
        public virtual SalesRep? SalesRepNavigation { get; set; }
        public virtual SalesTaxCode? TaxCodeNavigation { get; set; }
        public virtual SalesTaxItem? TaxItemNavigation { get; set; }
        public virtual CustomerType? TypeNavigation { get; set; }
        public virtual ICollection<BillExpenseItem> BillExpenseItems { get; set; }
        public virtual ICollection<BillLineItem> BillLineItems { get; set; }
        public virtual ICollection<CheckExpenseItem> CheckExpenseItems { get; set; }
        public virtual ICollection<CheckLineItem> CheckLineItems { get; set; }
        public virtual ICollection<CreditCardChargeExpenseItem> CreditCardChargeExpenseItems { get; set; }
        public virtual ICollection<CreditCardChargeLineItem> CreditCardChargeLineItems { get; set; }
        public virtual ICollection<CreditCardCreditExpenseItem> CreditCardCreditExpenseItems { get; set; }
        public virtual ICollection<CreditCardCreditLineItem> CreditCardCreditLineItems { get; set; }
        public virtual ICollection<CreditCardRefund> CreditCardRefunds { get; set; }
        public virtual ICollection<CreditMemoLineItem> CreditMemoLineItems { get; set; }
        public virtual ICollection<CreditMemoLinkedTransaction> CreditMemoLinkedTransactions { get; set; }
        public virtual ICollection<CreditMemo> CreditMemos { get; set; }
        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
        public virtual ICollection<CustomerNote> CustomerNotes { get; set; }
        public virtual ICollection<CustomerShippingAddress> CustomerShippingAddresses { get; set; }
        public virtual ICollection<EstimateLineItem> EstimateLineItems { get; set; }
        public virtual ICollection<EstimateLinkedTransaction> EstimateLinkedTransactions { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<InventoryAdjustmentLineItem> InventoryAdjustmentLineItems { get; set; }
        public virtual ICollection<InventoryAdjustment> InventoryAdjustments { get; set; }
        public virtual ICollection<Customer> InverseParent { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual ICollection<InvoiceLinkedTransaction> InvoiceLinkedTransactions { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<ItemReceiptExpenseItem> ItemReceiptExpenseItems { get; set; }
        public virtual ICollection<ItemReceiptLineItem> ItemReceiptLineItems { get; set; }
        public virtual ICollection<PurchaseOrderLineItem> PurchaseOrderLineItems { get; set; }
        public virtual ICollection<ReceivePaymentToDeposit> ReceivePaymentToDeposits { get; set; }
        public virtual ICollection<ReceivePayment> ReceivePayments { get; set; }
        public virtual ICollection<ReceivePaymentsAppliedTo> ReceivePaymentsAppliedTos { get; set; }
        public virtual ICollection<SalesOrderLineItem> SalesOrderLineItems { get; set; }
        public virtual ICollection<SalesOrderLinkedTransaction> SalesOrderLinkedTransactions { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<SalesReceiptLineItem> SalesReceiptLineItems { get; set; }
        public virtual ICollection<SalesReceipt> SalesReceipts { get; set; }
        public virtual ICollection<StatementChargeLinkedTransaction> StatementChargeLinkedTransactions { get; set; }
        public virtual ICollection<StatementCharge> StatementCharges { get; set; }
        public virtual ICollection<TimeTracking> TimeTrackings { get; set; }
        public virtual ICollection<VehicleMileage> VehicleMileages { get; set; }
        public virtual ICollection<VendorCreditExpenseItem> VendorCreditExpenseItems { get; set; }
        public virtual ICollection<VendorCreditLineItem> VendorCreditLineItems { get; set; }
    }
}
