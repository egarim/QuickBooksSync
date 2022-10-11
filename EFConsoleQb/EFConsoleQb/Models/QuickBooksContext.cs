using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFConsoleQb.Models
{
    public partial class QuickBooksContext : DbContext
    {
        public QuickBooksContext()
        {
        }

        public QuickBooksContext(DbContextOptions<QuickBooksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<BalanceSheetDetail> BalanceSheetDetails { get; set; } = null!;
        public virtual DbSet<BalanceSheetStandard> BalanceSheetStandards { get; set; } = null!;
        public virtual DbSet<BalanceSheetSummary> BalanceSheetSummaries { get; set; } = null!;
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<BillExpenseItem> BillExpenseItems { get; set; } = null!;
        public virtual DbSet<BillLineItem> BillLineItems { get; set; } = null!;
        public virtual DbSet<BillLinkedTransaction> BillLinkedTransactions { get; set; } = null!;
        public virtual DbSet<BillPaymentCheck> BillPaymentChecks { get; set; } = null!;
        public virtual DbSet<BillPaymentChecksAppliedTo> BillPaymentChecksAppliedTos { get; set; } = null!;
        public virtual DbSet<BillPaymentCreditCard> BillPaymentCreditCards { get; set; } = null!;
        public virtual DbSet<BillPaymentCreditCardsAppliedTo> BillPaymentCreditCardsAppliedTos { get; set; } = null!;
        public virtual DbSet<BuildAssembly> BuildAssemblies { get; set; } = null!;
        public virtual DbSet<BuildAssemblyLineItem> BuildAssemblyLineItems { get; set; } = null!;
        public virtual DbSet<Check> Checks { get; set; } = null!;
        public virtual DbSet<CheckExpenseItem> CheckExpenseItems { get; set; } = null!;
        public virtual DbSet<CheckLineItem> CheckLineItems { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<CompanyInfo> CompanyInfos { get; set; } = null!;
        public virtual DbSet<CreditCardCharge> CreditCardCharges { get; set; } = null!;
        public virtual DbSet<CreditCardChargeExpenseItem> CreditCardChargeExpenseItems { get; set; } = null!;
        public virtual DbSet<CreditCardChargeLineItem> CreditCardChargeLineItems { get; set; } = null!;
        public virtual DbSet<CreditCardCredit> CreditCardCredits { get; set; } = null!;
        public virtual DbSet<CreditCardCreditExpenseItem> CreditCardCreditExpenseItems { get; set; } = null!;
        public virtual DbSet<CreditCardCreditLineItem> CreditCardCreditLineItems { get; set; } = null!;
        public virtual DbSet<CreditCardRefund> CreditCardRefunds { get; set; } = null!;
        public virtual DbSet<CreditMemo> CreditMemos { get; set; } = null!;
        public virtual DbSet<CreditMemoLineItem> CreditMemoLineItems { get; set; } = null!;
        public virtual DbSet<CreditMemoLinkedTransaction> CreditMemoLinkedTransactions { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<CustomColumn> CustomColumns { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; } = null!;
        public virtual DbSet<CustomerMessage> CustomerMessages { get; set; } = null!;
        public virtual DbSet<CustomerNote> CustomerNotes { get; set; } = null!;
        public virtual DbSet<CustomerShippingAddress> CustomerShippingAddresses { get; set; } = null!;
        public virtual DbSet<CustomerType> CustomerTypes { get; set; } = null!;
        public virtual DbSet<DateDrivenTerm> DateDrivenTerms { get; set; } = null!;
        public virtual DbSet<DeletedEntity> DeletedEntities { get; set; } = null!;
        public virtual DbSet<DeletedTransaction> DeletedTransactions { get; set; } = null!;
        public virtual DbSet<Deposit> Deposits { get; set; } = null!;
        public virtual DbSet<DepositLineItem> DepositLineItems { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeEarning> EmployeeEarnings { get; set; } = null!;
        public virtual DbSet<Estimate> Estimates { get; set; } = null!;
        public virtual DbSet<EstimateLineItem> EstimateLineItems { get; set; } = null!;
        public virtual DbSet<EstimateLinkedTransaction> EstimateLinkedTransactions { get; set; } = null!;
        public virtual DbSet<Host> Hosts { get; set; } = null!;
        public virtual DbSet<InventoryAdjustment> InventoryAdjustments { get; set; } = null!;
        public virtual DbSet<InventoryAdjustmentLineItem> InventoryAdjustmentLineItems { get; set; } = null!;
        public virtual DbSet<InventorySite> InventorySites { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; } = null!;
        public virtual DbSet<InvoiceLinkedTransaction> InvoiceLinkedTransactions { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<ItemLineItem> ItemLineItems { get; set; } = null!;
        public virtual DbSet<ItemReceipt> ItemReceipts { get; set; } = null!;
        public virtual DbSet<ItemReceiptExpenseItem> ItemReceiptExpenseItems { get; set; } = null!;
        public virtual DbSet<ItemReceiptLineItem> ItemReceiptLineItems { get; set; } = null!;
        public virtual DbSet<ItemReceiptLinkedTransaction> ItemReceiptLinkedTransactions { get; set; } = null!;
        public virtual DbSet<ItemSite> ItemSites { get; set; } = null!;
        public virtual DbSet<JobType> JobTypes { get; set; } = null!;
        public virtual DbSet<JournalEntry> JournalEntries { get; set; } = null!;
        public virtual DbSet<JournalEntryLine> JournalEntryLines { get; set; } = null!;
        public virtual DbSet<OtherName> OtherNames { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<PayrollNonWageItem> PayrollNonWageItems { get; set; } = null!;
        public virtual DbSet<PayrollWageItem> PayrollWageItems { get; set; } = null!;
        public virtual DbSet<Preference> Preferences { get; set; } = null!;
        public virtual DbSet<PriceLevel> PriceLevels { get; set; } = null!;
        public virtual DbSet<PriceLevelPerItem> PriceLevelPerItems { get; set; } = null!;
        public virtual DbSet<ProfitAndLossDetail> ProfitAndLossDetails { get; set; } = null!;
        public virtual DbSet<ProfitAndLossStandard> ProfitAndLossStandards { get; set; } = null!;
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; } = null!;
        public virtual DbSet<PurchaseOrderLineItem> PurchaseOrderLineItems { get; set; } = null!;
        public virtual DbSet<PurchaseOrderLinkedTransaction> PurchaseOrderLinkedTransactions { get; set; } = null!;
        public virtual DbSet<ReceivePayment> ReceivePayments { get; set; } = null!;
        public virtual DbSet<ReceivePaymentToDeposit> ReceivePaymentToDeposits { get; set; } = null!;
        public virtual DbSet<ReceivePaymentsAppliedTo> ReceivePaymentsAppliedTos { get; set; } = null!;
        public virtual DbSet<SalesOrder> SalesOrders { get; set; } = null!;
        public virtual DbSet<SalesOrderLineItem> SalesOrderLineItems { get; set; } = null!;
        public virtual DbSet<SalesOrderLinkedTransaction> SalesOrderLinkedTransactions { get; set; } = null!;
        public virtual DbSet<SalesReceipt> SalesReceipts { get; set; } = null!;
        public virtual DbSet<SalesReceiptLineItem> SalesReceiptLineItems { get; set; } = null!;
        public virtual DbSet<SalesRep> SalesReps { get; set; } = null!;
        public virtual DbSet<SalesTaxCode> SalesTaxCodes { get; set; } = null!;
        public virtual DbSet<SalesTaxItem> SalesTaxItems { get; set; } = null!;
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; } = null!;
        public virtual DbSet<StandardTerm> StandardTerms { get; set; } = null!;
        public virtual DbSet<StatementCharge> StatementCharges { get; set; } = null!;
        public virtual DbSet<StatementChargeLinkedTransaction> StatementChargeLinkedTransactions { get; set; } = null!;
        public virtual DbSet<Template> Templates { get; set; } = null!;
        public virtual DbSet<TimeTracking> TimeTrackings { get; set; } = null!;
        public virtual DbSet<ToDo> ToDos { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<Transfer> Transfers { get; set; } = null!;
        public virtual DbSet<TransferInventory> TransferInventories { get; set; } = null!;
        public virtual DbSet<TransferInventoryLineItem> TransferInventoryLineItems { get; set; } = null!;
        public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; } = null!;
        public virtual DbSet<UnitOfMeasureDefaultUnit> UnitOfMeasureDefaultUnits { get; set; } = null!;
        public virtual DbSet<UnitOfMeasureRelatedUnit> UnitOfMeasureRelatedUnits { get; set; } = null!;
        public virtual DbSet<VehicleMileage> VehicleMileages { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;
        public virtual DbSet<VendorCredit> VendorCredits { get; set; } = null!;
        public virtual DbSet<VendorCreditExpenseItem> VendorCreditExpenseItems { get; set; } = null!;
        public virtual DbSet<VendorCreditLineItem> VendorCreditLineItems { get; set; } = null!;
        public virtual DbSet<VendorCreditLinkedTransaction> VendorCreditLinkedTransactions { get; set; } = null!;
        public virtual DbSet<VendorType> VendorTypes { get; set; } = null!;
        public virtual DbSet<WorkersCompCode> WorkersCompCodes { get; set; } = null!;
        public virtual DbSet<WorkersCompCodeLine> WorkersCompCodeLines { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseQuickBooks("company file=C:\\exelinesincTesting.qbw;pool wait time=600;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Accounts", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ACCOUNTS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountBalance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Balance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BankAccount).HasColumnType("varchar(2000)");

                entity.Property(e => e.CashFlowClassification)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.Description).HasColumnType("varchar(200)");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(1000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.Number).HasColumnType("varchar(2000)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(255)");

                entity.Property(e => e.ParentName).HasColumnType("varchar(255)");

                entity.Property(e => e.SpecialType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Sublevel)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxLineId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxLineName)
                    .HasColumnType("varchar(256)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Accounts_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Accounts_ParentId_REF_Accounts_ID");
            });

            modelBuilder.Entity<BalanceSheetDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BalanceSheetDetail", "QuickBooks");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Balance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Class)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Clr)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Label)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Split)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<BalanceSheetStandard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BalanceSheetStandard", "QuickBooks");

                entity.Property(e => e.Label)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Total)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<BalanceSheetSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BalanceSheetSummary", "QuickBooks");

                entity.Property(e => e.Account)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Total)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bills", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BILLS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpenseItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsPaid)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.OpenAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAggregate)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_Bills_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Bills_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_Bills_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<BillExpenseItem>(entity =>
            {
                entity.ToTable("BillExpenseItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BILLEXPENSEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillId).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpenseAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ExpenseBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ExpenseClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomFields)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseMemo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ExpenseTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.IsPaid)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.OpenAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.BillExpenseItemAccountsPayableNavigations)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_BillExpenseItems_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillExpenseItems)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_BillExpenseItems_BillId_REF_Bills_ID");

                entity.HasOne(d => d.ExpenseAccountNavigation)
                    .WithMany(p => p.BillExpenseItemExpenseAccountNavigations)
                    .HasForeignKey(d => d.ExpenseAccountId)
                    .HasConstraintName("FK_BillExpenseItems_ExpenseAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ExpenseClassNavigation)
                    .WithMany(p => p.BillExpenseItems)
                    .HasForeignKey(d => d.ExpenseClassId)
                    .HasConstraintName("FK_BillExpenseItems_ExpenseClassId_REF_Class_ID");

                entity.HasOne(d => d.ExpenseCustomerNavigation)
                    .WithMany(p => p.BillExpenseItems)
                    .HasForeignKey(d => d.ExpenseCustomerId)
                    .HasConstraintName("FK_BillExpenseItems_ExpenseCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ExpenseTaxCodeNavigation)
                    .WithMany(p => p.BillExpenseItems)
                    .HasForeignKey(d => d.ExpenseTaxCodeId)
                    .HasConstraintName("FK_BillExpenseItems_ExpenseTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.BillExpenseItems)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_BillExpenseItems_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<BillLineItem>(entity =>
            {
                entity.ToTable("BillLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BILLLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.IsPaid)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCost).HasColumnType("float");

                entity.Property(e => e.ItemCustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLotNumber).HasColumnType("varchar(40)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemSerialNumber).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.OpenAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.BillLineItems)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_BillLineItems_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillLineItems)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_BillLineItems_BillId_REF_Bills_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.BillLineItems)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_BillLineItems_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.BillLineItems)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_BillLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemCustomerNavigation)
                    .WithMany(p => p.BillLineItems)
                    .HasForeignKey(d => d.ItemCustomerId)
                    .HasConstraintName("FK_BillLineItems_ItemCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.BillLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_BillLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.BillLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_BillLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySite)
                    .WithMany(p => p.BillLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteId)
                    .HasConstraintName("FK_BillLineItems_ItemInventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.BillLineItems)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_BillLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.BillLineItems)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_BillLineItems_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<BillLinkedTransaction>(entity =>
            {
                entity.ToTable("BillLinkedTransactions", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BILLLINKEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BillId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionLinkType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillLinkedTransactions)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK_BillLinkedTransactions_BillId_REF_Bills_ID");
            });

            modelBuilder.Entity<BillPaymentCheck>(entity =>
            {
                entity.ToTable("BillPaymentChecks", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BILLPAYMENTCHECKS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AmountInHomeCurrency)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.BankAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.BankAccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.BillPaymentCheckAccountsPayableNavigations)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_BillPaymentChecks_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.BillPaymentCheckBankAccounts)
                    .HasForeignKey(d => d.BankAccountId)
                    .HasConstraintName("FK_BillPaymentChecks_BankAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.BillPaymentChecks)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_BillPaymentChecks_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<BillPaymentChecksAppliedTo>(entity =>
            {
                entity.ToTable("BillPaymentChecksAppliedTo", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BILLPAYMENTCHECKSAPPLIEDTO_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(1000)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.AmountInHomeCurrency)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToBalanceRemaining)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToCreditAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToCreditMemoId).HasColumnType("varchar(255)");

                entity.Property(e => e.AppliedToDiscountAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AppliedToDiscountAccountName).HasColumnType("varchar(1000)");

                entity.Property(e => e.AppliedToDiscountAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToPaymentAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToRefId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToTxnDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToTxnType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BankAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.BankAccountName).HasColumnType("varchar(1000)");

                entity.Property(e => e.BillPaymentId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BillPayment)
                    .WithMany(p => p.BillPaymentChecksAppliedTos)
                    .HasForeignKey(d => d.BillPaymentId)
                    .HasConstraintName("FK_BillPaymentChecksAppliedTo_BillPaymentId_REF_BillPaymentChecks_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.BillPaymentChecksAppliedTos)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_BillPaymentChecksAppliedTo_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<BillPaymentCreditCard>(entity =>
            {
                entity.ToTable("BillPaymentCreditCards", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BILLPAYMENTCREDITCARDS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AmountInHomeCurrency)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.CreditCardId).HasColumnType("varchar(255)");

                entity.Property(e => e.CreditCardName).HasColumnType("varchar(1000)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.BillPaymentCreditCards)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_BillPaymentCreditCards_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.BillPaymentCreditCards)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_BillPaymentCreditCards_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<BillPaymentCreditCardsAppliedTo>(entity =>
            {
                entity.ToTable("BillPaymentCreditCardsAppliedTo", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BILLPAYMENTCREDITCARDSAPPLIEDTO_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.AmountInHomeCurrency)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToBalanceRemaining)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToCreditMemoId).HasColumnType("varchar(255)");

                entity.Property(e => e.AppliedToDiscountAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AppliedToDiscountAccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.AppliedToDiscountAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToPaymentAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToRefId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToTxnDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToTxnType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillPaymentId).HasColumnType("varchar(255)");

                entity.Property(e => e.CreditCardId).HasColumnType("varchar(255)");

                entity.Property(e => e.CreditCardName).HasColumnType("varchar(1000)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.BillPaymentCreditCardsAppliedToAccountsPayableNavigations)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_BillPaymentCreditCardsAppliedTo_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.AppliedToCreditMemo)
                    .WithMany(p => p.BillPaymentCreditCardsAppliedTos)
                    .HasForeignKey(d => d.AppliedToCreditMemoId)
                    .HasConstraintName("FK_BillPaymentCreditCardsAppliedTo_AppliedToCreditMemoId_REF_CreditMemos_ID");

                entity.HasOne(d => d.AppliedToDiscountAccount)
                    .WithMany(p => p.BillPaymentCreditCardsAppliedToAppliedToDiscountAccounts)
                    .HasForeignKey(d => d.AppliedToDiscountAccountId)
                    .HasConstraintName("FK_BillPaymentCreditCardsAppliedTo_AppliedToDiscountAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.BillPayment)
                    .WithMany(p => p.BillPaymentCreditCardsAppliedTos)
                    .HasForeignKey(d => d.BillPaymentId)
                    .HasConstraintName("FK_BillPaymentCreditCardsAppliedTo_BillPaymentId_REF_BillPaymentCreditCards_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.BillPaymentCreditCardsAppliedTos)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_BillPaymentCreditCardsAppliedTo_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<BuildAssembly>(entity =>
            {
                entity.ToTable("BuildAssemblies", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BUILDASSEMBLIES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BuildAssemblyLineAggregate)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExternalGuid)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ExternalGUID");

                entity.Property(e => e.InventorySiteRefFullName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("InventorySiteRef_FullName");

                entity.Property(e => e.InventorySiteRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("InventorySiteRef_ListID");

                entity.Property(e => e.IsPending)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemInventoryAssemblyRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemInventoryAssemblyRef_FullName");

                entity.Property(e => e.ItemInventoryAssemblyRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemInventoryAssemblyRef_ListID");

                entity.Property(e => e.LotNumber).HasColumnType("varchar(40)");

                entity.Property(e => e.MarkPendingIfRequired).HasColumnType("bool");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.QuantityCanBuild)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityOnHand)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityOnSalesOrder)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityToBuild).HasColumnType("float");

                entity.Property(e => e.RefNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SerialNumber).HasColumnType("varchar(5000)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnDate).HasColumnType("date");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.InventorySiteRefList)
                    .WithMany(p => p.BuildAssemblies)
                    .HasForeignKey(d => d.InventorySiteRefListId)
                    .HasConstraintName("FK_BuildAssemblies_InventorySiteRef_ListID_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemInventoryAssemblyRefList)
                    .WithMany(p => p.BuildAssemblies)
                    .HasForeignKey(d => d.ItemInventoryAssemblyRefListId)
                    .HasConstraintName("FK_BuildAssemblies_ItemInventoryAssemblyRef_ListID_REF_Items_ID");
            });

            modelBuilder.Entity<BuildAssemblyLineItem>(entity =>
            {
                entity.ToTable("BuildAssemblyLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_BUILDASSEMBLYLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BuildAssemblyId).HasColumnType("varchar(255)");

                entity.Property(e => e.ComponentItemLineRetDesc)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ComponentItemLineRet_Desc");

                entity.Property(e => e.ComponentItemLineRetInventorySiteRefFullName)
                    .HasColumnType("varchar(31)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ComponentItemLineRet_InventorySiteRef_FullName");

                entity.Property(e => e.ComponentItemLineRetInventorySiteRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ComponentItemLineRet_InventorySiteRef_ListID");

                entity.Property(e => e.ComponentItemLineRetItemRefFullName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ComponentItemLineRet_ItemRef_FullName");

                entity.Property(e => e.ComponentItemLineRetItemRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ComponentItemLineRet_ItemRef_ListID");

                entity.Property(e => e.ComponentItemLineRetQuantityNeeded)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ComponentItemLineRet_QuantityNeeded");

                entity.Property(e => e.ComponentItemLineRetQuantityOnHand)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ComponentItemLineRet_QuantityOnHand");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExternalGuid)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ExternalGUID");

                entity.Property(e => e.InventorySiteRefFullName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("InventorySiteRef_FullName");

                entity.Property(e => e.InventorySiteRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("InventorySiteRef_ListID");

                entity.Property(e => e.IsPending)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemInventoryAssemblyRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemInventoryAssemblyRef_FullName");

                entity.Property(e => e.ItemInventoryAssemblyRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemInventoryAssemblyRef_ListID");

                entity.Property(e => e.LotNumber).HasColumnType("varchar(40)");

                entity.Property(e => e.MarkPendingIfRequired).HasColumnType("bool");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.QuantityCanBuild)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityOnHand)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityOnSalesOrder)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityToBuild).HasColumnType("float");

                entity.Property(e => e.RefNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SerialNumber).HasColumnType("varchar(5000)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnDate).HasColumnType("date");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.BuildAssembly)
                    .WithMany(p => p.BuildAssemblyLineItems)
                    .HasForeignKey(d => d.BuildAssemblyId)
                    .HasConstraintName("FK_BuildAssemblyLineItems_BuildAssemblyId_REF_BuildAssemblies_ID");

                entity.HasOne(d => d.ComponentItemLineRetInventorySiteRefList)
                    .WithMany(p => p.BuildAssemblyLineItemComponentItemLineRetInventorySiteRefLists)
                    .HasForeignKey(d => d.ComponentItemLineRetInventorySiteRefListId)
                    .HasConstraintName("FK_BuildAssemblyLineItems_ComponentItemLineRet_InventorySiteRef_ListID_REF_InventorySites_ID");

                entity.HasOne(d => d.ComponentItemLineRetItemRefList)
                    .WithMany(p => p.BuildAssemblyLineItemComponentItemLineRetItemRefLists)
                    .HasForeignKey(d => d.ComponentItemLineRetItemRefListId)
                    .HasConstraintName("FK_BuildAssemblyLineItems_ComponentItemLineRet_ItemRef_ListID_REF_Items_ID");

                entity.HasOne(d => d.InventorySiteRefList)
                    .WithMany(p => p.BuildAssemblyLineItemInventorySiteRefLists)
                    .HasForeignKey(d => d.InventorySiteRefListId)
                    .HasConstraintName("FK_BuildAssemblyLineItems_InventorySiteRef_ListID_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemInventoryAssemblyRefList)
                    .WithMany(p => p.BuildAssemblyLineItemItemInventoryAssemblyRefLists)
                    .HasForeignKey(d => d.ItemInventoryAssemblyRefListId)
                    .HasConstraintName("FK_BuildAssemblyLineItems_ItemInventoryAssemblyRef_ListID_REF_Items_ID");
            });

            modelBuilder.Entity<Check>(entity =>
            {
                entity.ToTable("Checks", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CHECKS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.City).HasColumnType("varchar(255)");

                entity.Property(e => e.Country).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpenseItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Line1).HasColumnType("varchar(500)");

                entity.Property(e => e.Line2).HasColumnType("varchar(500)");

                entity.Property(e => e.Line3).HasColumnType("varchar(500)");

                entity.Property(e => e.Line4).HasColumnType("varchar(500)");

                entity.Property(e => e.Line5).HasColumnType("varchar(41)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Note).HasColumnType("varchar(41)");

                entity.Property(e => e.Payee).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.State).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.Checks)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Checks_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Checks)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Checks_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.PayeeNavigation)
                    .WithMany(p => p.Checks)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_Checks_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<CheckExpenseItem>(entity =>
            {
                entity.ToTable("CheckExpenseItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CHECKEXPENSEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CheckId).HasColumnType("varchar(255)");

                entity.Property(e => e.City).HasColumnType("varchar(255)");

                entity.Property(e => e.Country).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpenseAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ExpenseBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ExpenseClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomFields)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseMemo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ExpenseTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.Line1).HasColumnType("varchar(500)");

                entity.Property(e => e.Line2).HasColumnType("varchar(500)");

                entity.Property(e => e.Line3).HasColumnType("varchar(500)");

                entity.Property(e => e.Line4).HasColumnType("varchar(500)");

                entity.Property(e => e.Line5).HasColumnType("varchar(41)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Note).HasColumnType("varchar(41)");

                entity.Property(e => e.Payee).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.State).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.CheckExpenseItemAccountNavigations)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CheckExpenseItems_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Check)
                    .WithMany(p => p.CheckExpenseItems)
                    .HasForeignKey(d => d.CheckId)
                    .HasConstraintName("FK_CheckExpenseItems_CheckId_REF_Checks_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CheckExpenseItems)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_CheckExpenseItems_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.ExpenseAccountNavigation)
                    .WithMany(p => p.CheckExpenseItemExpenseAccountNavigations)
                    .HasForeignKey(d => d.ExpenseAccountId)
                    .HasConstraintName("FK_CheckExpenseItems_ExpenseAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ExpenseClassNavigation)
                    .WithMany(p => p.CheckExpenseItems)
                    .HasForeignKey(d => d.ExpenseClassId)
                    .HasConstraintName("FK_CheckExpenseItems_ExpenseClassId_REF_Class_ID");

                entity.HasOne(d => d.ExpenseCustomerNavigation)
                    .WithMany(p => p.CheckExpenseItems)
                    .HasForeignKey(d => d.ExpenseCustomerId)
                    .HasConstraintName("FK_CheckExpenseItems_ExpenseCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ExpenseTaxCodeNavigation)
                    .WithMany(p => p.CheckExpenseItems)
                    .HasForeignKey(d => d.ExpenseTaxCodeId)
                    .HasConstraintName("FK_CheckExpenseItems_ExpenseTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.PayeeNavigation)
                    .WithMany(p => p.CheckExpenseItems)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_CheckExpenseItems_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<CheckLineItem>(entity =>
            {
                entity.ToTable("CheckLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CHECKLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CheckId).HasColumnType("varchar(255)");

                entity.Property(e => e.City).HasColumnType("varchar(255)");

                entity.Property(e => e.Country).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCost).HasColumnType("float");

                entity.Property(e => e.ItemCustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.Line1).HasColumnType("varchar(500)");

                entity.Property(e => e.Line2).HasColumnType("varchar(500)");

                entity.Property(e => e.Line3).HasColumnType("varchar(500)");

                entity.Property(e => e.Line4).HasColumnType("varchar(500)");

                entity.Property(e => e.Line5).HasColumnType("varchar(41)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Note).HasColumnType("varchar(41)");

                entity.Property(e => e.Payee).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.State).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.CheckLineItems)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CheckLineItems_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Check)
                    .WithMany(p => p.CheckLineItems)
                    .HasForeignKey(d => d.CheckId)
                    .HasConstraintName("FK_CheckLineItems_CheckId_REF_Checks_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CheckLineItems)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_CheckLineItems_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.CheckLineItems)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_CheckLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemCustomerNavigation)
                    .WithMany(p => p.CheckLineItems)
                    .HasForeignKey(d => d.ItemCustomerId)
                    .HasConstraintName("FK_CheckLineItems_ItemCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.CheckLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_CheckLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.CheckLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_CheckLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySite)
                    .WithMany(p => p.CheckLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteId)
                    .HasConstraintName("FK_CheckLineItems_ItemInventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.CheckLineItems)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_CheckLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.PayeeNavigation)
                    .WithMany(p => p.CheckLineItems)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_CheckLineItems_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CLASS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(1000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.ParentRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentRef_FullName");

                entity.Property(e => e.ParentRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentRef_ListId");

                entity.Property(e => e.Sublevel)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ParentRefList)
                    .WithMany(p => p.InverseParentRefList)
                    .HasForeignKey(d => d.ParentRefListId)
                    .HasConstraintName("FK_Class_ParentRef_ListId_REF_Class_ID");
            });

            modelBuilder.Entity<CompanyInfo>(entity =>
            {
                entity.ToTable("CompanyInfo", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_COMPANYINFO_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(20)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.City)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Country)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(1023)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Fax)
                    .HasColumnType("varchar(51)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.FirstMonthFiscal)
                    .HasColumnType("varchar(10)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.FirstMonthTax)
                    .HasColumnType("varchar(10)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.LegalAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.LegalCity)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.LegalCountry)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.LegalName)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.LegalState)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.LegalZip)
                    .HasColumnType("varchar(30)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Line1)
                    .HasColumnType("varchar(500)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Line2)
                    .HasColumnType("varchar(500)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Line3)
                    .HasColumnType("varchar(500)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Line4)
                    .HasColumnType("varchar(500)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Line5)
                    .HasColumnType("varchar(41)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Note)
                    .HasColumnType("varchar(41)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OpenedCompanyFile)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(51)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PostalCode)
                    .HasColumnType("varchar(30)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCountry)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingLine1)
                    .HasColumnType("varchar(500)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingLine2)
                    .HasColumnType("varchar(500)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingLine3)
                    .HasColumnType("varchar(500)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingLine4)
                    .HasColumnType("varchar(500)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingLine5)
                    .HasColumnType("varchar(41)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingNote)
                    .HasColumnType("varchar(41)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingPostalCode)
                    .HasColumnType("varchar(30)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingState)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Ssn)
                    .HasColumnType("varchar(11)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SSN");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Taxform)
                    .HasColumnType("varchar(11)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Website)
                    .HasColumnType("varchar(128)")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<CreditCardCharge>(entity =>
            {
                entity.ToTable("CreditCardCharges", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITCARDCHARGES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExpenseItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(11)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CreditCardCharges)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CreditCardCharges_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.CreditCardCharges)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_CreditCardCharges_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<CreditCardChargeExpenseItem>(entity =>
            {
                entity.ToTable("CreditCardChargeExpenseItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITCARDCHARGEEXPENSEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.CcchargeId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CCChargeId");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpenseAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ExpenseBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ExpenseClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseMemo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ExpenseTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CreditCardChargeExpenseItemAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CreditCardChargeExpenseItems_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Cccharge)
                    .WithMany(p => p.CreditCardChargeExpenseItems)
                    .HasForeignKey(d => d.CcchargeId)
                    .HasConstraintName("FK_CreditCardChargeExpenseItems_CCChargeId_REF_CreditCardCharges_ID");

                entity.HasOne(d => d.ExpenseAccountNavigation)
                    .WithMany(p => p.CreditCardChargeExpenseItemExpenseAccountNavigations)
                    .HasForeignKey(d => d.ExpenseAccountId)
                    .HasConstraintName("FK_CreditCardChargeExpenseItems_ExpenseAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ExpenseClassNavigation)
                    .WithMany(p => p.CreditCardChargeExpenseItems)
                    .HasForeignKey(d => d.ExpenseClassId)
                    .HasConstraintName("FK_CreditCardChargeExpenseItems_ExpenseClassId_REF_Class_ID");

                entity.HasOne(d => d.ExpenseCustomerNavigation)
                    .WithMany(p => p.CreditCardChargeExpenseItems)
                    .HasForeignKey(d => d.ExpenseCustomerId)
                    .HasConstraintName("FK_CreditCardChargeExpenseItems_ExpenseCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ExpenseTaxCodeNavigation)
                    .WithMany(p => p.CreditCardChargeExpenseItems)
                    .HasForeignKey(d => d.ExpenseTaxCodeId)
                    .HasConstraintName("FK_CreditCardChargeExpenseItems_ExpenseTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.CreditCardChargeExpenseItems)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_CreditCardChargeExpenseItems_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<CreditCardChargeLineItem>(entity =>
            {
                entity.ToTable("CreditCardChargeLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITCARDCHARGELINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.CcchargeId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CCChargeId");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCost).HasColumnType("float");

                entity.Property(e => e.ItemCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(100)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CreditCardChargeLineItems)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CreditCardChargeLineItems_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Cccharge)
                    .WithMany(p => p.CreditCardChargeLineItems)
                    .HasForeignKey(d => d.CcchargeId)
                    .HasConstraintName("FK_CreditCardChargeLineItems_CCChargeId_REF_CreditCardCharges_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.CreditCardChargeLineItems)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_CreditCardChargeLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemCustomerNavigation)
                    .WithMany(p => p.CreditCardChargeLineItems)
                    .HasForeignKey(d => d.ItemCustomerId)
                    .HasConstraintName("FK_CreditCardChargeLineItems_ItemCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.CreditCardChargeLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_CreditCardChargeLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.CreditCardChargeLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_CreditCardChargeLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySite)
                    .WithMany(p => p.CreditCardChargeLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteId)
                    .HasConstraintName("FK_CreditCardChargeLineItems_ItemInventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.CreditCardChargeLineItems)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_CreditCardChargeLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.CreditCardChargeLineItems)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_CreditCardChargeLineItems_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<CreditCardCredit>(entity =>
            {
                entity.ToTable("CreditCardCredits", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITCARDCREDITS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExpenseItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CreditCardCredits)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CreditCardCredits_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.CreditCardCredits)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_CreditCardCredits_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<CreditCardCreditExpenseItem>(entity =>
            {
                entity.ToTable("CreditCardCreditExpenseItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITCARDCREDITEXPENSEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.CccreditId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CCCreditId");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpenseAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ExpenseBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ExpenseClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseMemo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ExpenseTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CreditCardCreditExpenseItemAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CreditCardCreditExpenseItems_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Cccredit)
                    .WithMany(p => p.CreditCardCreditExpenseItems)
                    .HasForeignKey(d => d.CccreditId)
                    .HasConstraintName("FK_CreditCardCreditExpenseItems_CCCreditId_REF_CreditCardCredits_ID");

                entity.HasOne(d => d.ExpenseAccountNavigation)
                    .WithMany(p => p.CreditCardCreditExpenseItemExpenseAccountNavigations)
                    .HasForeignKey(d => d.ExpenseAccountId)
                    .HasConstraintName("FK_CreditCardCreditExpenseItems_ExpenseAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ExpenseClassNavigation)
                    .WithMany(p => p.CreditCardCreditExpenseItems)
                    .HasForeignKey(d => d.ExpenseClassId)
                    .HasConstraintName("FK_CreditCardCreditExpenseItems_ExpenseClassId_REF_Class_ID");

                entity.HasOne(d => d.ExpenseCustomerNavigation)
                    .WithMany(p => p.CreditCardCreditExpenseItems)
                    .HasForeignKey(d => d.ExpenseCustomerId)
                    .HasConstraintName("FK_CreditCardCreditExpenseItems_ExpenseCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ExpenseTaxCodeNavigation)
                    .WithMany(p => p.CreditCardCreditExpenseItems)
                    .HasForeignKey(d => d.ExpenseTaxCodeId)
                    .HasConstraintName("FK_CreditCardCreditExpenseItems_ExpenseTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.CreditCardCreditExpenseItems)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_CreditCardCreditExpenseItems_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<CreditCardCreditLineItem>(entity =>
            {
                entity.ToTable("CreditCardCreditLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITCARDCREDITLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.CccreditId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CCCreditId");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCost).HasColumnType("float");

                entity.Property(e => e.ItemCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CreditCardCreditLineItems)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CreditCardCreditLineItems_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Cccredit)
                    .WithMany(p => p.CreditCardCreditLineItems)
                    .HasForeignKey(d => d.CccreditId)
                    .HasConstraintName("FK_CreditCardCreditLineItems_CCCreditId_REF_CreditCardCredits_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.CreditCardCreditLineItems)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_CreditCardCreditLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemCustomerNavigation)
                    .WithMany(p => p.CreditCardCreditLineItems)
                    .HasForeignKey(d => d.ItemCustomerId)
                    .HasConstraintName("FK_CreditCardCreditLineItems_ItemCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.CreditCardCreditLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_CreditCardCreditLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.CreditCardCreditLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_CreditCardCreditLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySite)
                    .WithMany(p => p.CreditCardCreditLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteId)
                    .HasConstraintName("FK_CreditCardCreditLineItems_ItemInventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.CreditCardCreditLineItems)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_CreditCardCreditLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Payee)
                    .WithMany(p => p.CreditCardCreditLineItems)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_CreditCardCreditLineItems_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<CreditCardRefund>(entity =>
            {
                entity.ToTable("CreditCardRefunds", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITCARDREFUNDS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AddressAddr1)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("Address_Addr1");

                entity.Property(e => e.AddressAddr2)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("Address_Addr2");

                entity.Property(e => e.AddressAddr3)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("Address_Addr3");

                entity.Property(e => e.AddressAddr4)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("Address_Addr4");

                entity.Property(e => e.AddressAddr5)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("Address_Addr5");

                entity.Property(e => e.AddressCity)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("Address_City");

                entity.Property(e => e.AddressCountry)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("Address_Country");

                entity.Property(e => e.AddressNote)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("Address_Note");

                entity.Property(e => e.AddressPostalCode)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("Address_PostalCode");

                entity.Property(e => e.AddressState)
                    .HasColumnType("varchar(21)")
                    .HasColumnName("Address_State");

                entity.Property(e => e.AraccountRefFullName)
                    .HasColumnType("varchar(159)")
                    .HasColumnName("ARAccountRef_FullName");

                entity.Property(e => e.AraccountRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ARAccountRef_ListID");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnInputInfoCommercialCardCode)
                    .HasColumnType("varchar(24)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnInputInfo_CommercialCardCode");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnInputInfoCreditCardAddress)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnInputInfo_CreditCardAddress");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnInputInfoCreditCardNumber)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnInputInfo_CreditCardNumber");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnInputInfoCreditCardPostalCode)
                    .HasColumnType("varchar(18)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnInputInfo_CreditCardPostalCode");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnInputInfoCreditCardTxnType)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnInputInfo_CreditCardTxnType");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnInputInfoExpirationMonth)
                    .HasColumnType("int")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnInputInfo_ExpirationMonth");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnInputInfoExpirationYear)
                    .HasColumnType("int")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnInputInfo_ExpirationYear");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnInputInfoNameOnCard)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnInputInfo_NameOnCard");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnInputInfoTransactionMode)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnInputInfo_TransactionMode");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnResultInfoAuthorizationCode)
                    .HasColumnType("varchar(12)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnResultInfo_AuthorizationCode");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnResultInfoAvsstreet)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnResultInfo_AVSStreet");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnResultInfoAvszip)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnResultInfo_AVSZip");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnResultInfoCardSecurityCodeMatch)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnResultInfo_CardSecurityCodeMatch");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnResultInfoCreditCardTransId)
                    .HasColumnType("varchar(24)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnResultInfo_CreditCardTransID");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnResultInfoMerchantAccountNumber)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnResultInfo_MerchantAccountNumber");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnResultInfoResultCode)
                    .HasColumnType("int")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnResultInfo_ResultCode");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnResultInfoResultMessage)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnResultInfo_ResultMessage");

                entity.Property(e => e.CreditCardTxnInfoCreditCardTxnResultInfoTxnAuthorizationTime)
                    .HasColumnType("datetime")
                    .HasColumnName("CreditCardTxnInfo_CreditCardTxnResultInfo_TxnAuthorizationTime");

                entity.Property(e => e.CurrencyRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("CurrencyRef_ListID");

                entity.Property(e => e.CurrencyRefName)
                    .HasColumnType("varchar(64)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("CurrencyRef_Name");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(5000)");

                entity.Property(e => e.CustomerRefFullName)
                    .HasColumnType("varchar(209)")
                    .HasColumnName("CustomerRef_FullName");

                entity.Property(e => e.CustomerRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CustomerRef_ListID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.Memo).HasColumnType("varchar(4095)");

                entity.Property(e => e.PaymentMethodRefFullName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("PaymentMethodRef_FullName");

                entity.Property(e => e.PaymentMethodRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PaymentMethodRef_ListID");

                entity.Property(e => e.RefNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.RefundAppliedToTxnAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.RefundFromAccountRefFullName)
                    .HasColumnType("varchar(159)")
                    .HasColumnName("RefundFromAccountRef_FullName");

                entity.Property(e => e.RefundFromAccountRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("RefundFromAccountRef_ListID");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmountInHomeCurrency)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnDate).HasColumnType("date");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AraccountRefList)
                    .WithMany(p => p.CreditCardRefundAraccountRefLists)
                    .HasForeignKey(d => d.AraccountRefListId)
                    .HasConstraintName("FK_CreditCardRefunds_ARAccountRef_ListID_REF_Accounts_ID");

                entity.HasOne(d => d.CustomerRefList)
                    .WithMany(p => p.CreditCardRefunds)
                    .HasForeignKey(d => d.CustomerRefListId)
                    .HasConstraintName("FK_CreditCardRefunds_CustomerRef_ListID_REF_Customers_ID");

                entity.HasOne(d => d.PaymentMethodRefList)
                    .WithMany(p => p.CreditCardRefunds)
                    .HasForeignKey(d => d.PaymentMethodRefListId)
                    .HasConstraintName("FK_CreditCardRefunds_PaymentMethodRef_ListID_REF_PaymentMethods_ID");

                entity.HasOne(d => d.RefundFromAccountRefList)
                    .WithMany(p => p.CreditCardRefundRefundFromAccountRefLists)
                    .HasForeignKey(d => d.RefundFromAccountRefListId)
                    .HasConstraintName("FK_CreditCardRefunds_RefundFromAccountRef_ListID_REF_Accounts_ID");
            });

            modelBuilder.Entity<CreditMemo>(entity =>
            {
                entity.ToTable("CreditMemos", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITMEMOS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsReceivable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsReceivableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CreditRemaining)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerSalesTax).HasColumnType("varchar(3)");

                entity.Property(e => e.CustomerSalesTaxId).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsPending).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.Ponumber)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("PONumber");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipDate).HasColumnType("date");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Tax).HasColumnType("float");

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAggregate)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountsReceivableNavigation)
                    .WithMany(p => p.CreditMemos)
                    .HasForeignKey(d => d.AccountsReceivableId)
                    .HasConstraintName("FK_CreditMemos_AccountsReceivableId_REF_Accounts_ID");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.CreditMemos)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_CreditMemos_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CreditMemos)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CreditMemos_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerSalesTaxNavigation)
                    .WithMany(p => p.CreditMemos)
                    .HasForeignKey(d => d.CustomerSalesTaxId)
                    .HasConstraintName("FK_CreditMemos_CustomerSalesTaxId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.CreditMemos)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_CreditMemos_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.CreditMemos)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_CreditMemos_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.CreditMemos)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_CreditMemos_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.CreditMemos)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_CreditMemos_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.CreditMemos)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_CreditMemos_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<CreditMemoLineItem>(entity =>
            {
                entity.ToTable("CreditMemoLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITMEMOLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsReceivable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsReceivableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CreditMemoId).HasColumnType("varchar(255)");

                entity.Property(e => e.CreditRemaining)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerSalesTax).HasColumnType("varchar(3)");

                entity.Property(e => e.CustomerSalesTaxId).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsPending).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemIsGetPrintItemsInGroup).HasColumnType("varchar(1000)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLotNumber).HasColumnType("varchar(40)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemOther1).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemOther2).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemRate).HasColumnType("float");

                entity.Property(e => e.ItemRatePercent).HasColumnType("float");

                entity.Property(e => e.ItemSerialNumber).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemUomsetFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetFullName");

                entity.Property(e => e.ItemUomsetListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetListID");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.Ponumber)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("PONumber");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipDate).HasColumnType("date");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Tax).HasColumnType("float");

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountsReceivableNavigation)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.AccountsReceivableId)
                    .HasConstraintName("FK_CreditMemoLineItems_AccountsReceivableId_REF_Accounts_ID");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.CreditMemoLineItemClassNavigations)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_CreditMemoLineItems_ClassId_REF_Class_ID");

                entity.HasOne(d => d.CreditMemo)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.CreditMemoId)
                    .HasConstraintName("FK_CreditMemoLineItems_CreditMemoId_REF_CreditMemos_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CreditMemoLineItems_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerSalesTaxNavigation)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.CustomerSalesTaxId)
                    .HasConstraintName("FK_CreditMemoLineItems_CustomerSalesTaxId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.CreditMemoLineItemItemClassNavigations)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_CreditMemoLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.CreditMemoLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_CreditMemoLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.CreditMemoLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_CreditMemoLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySite)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteId)
                    .HasConstraintName("FK_CreditMemoLineItems_ItemInventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.CreditMemoLineItemItemTaxCodeNavigations)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_CreditMemoLineItems_ItemTaxCodeId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.ItemUomsetList)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.ItemUomsetListId)
                    .HasConstraintName("FK_CreditMemoLineItems_ItemUOMSetListID_REF_UnitOfMeasure_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_CreditMemoLineItems_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_CreditMemoLineItems_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_CreditMemoLineItems_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.CreditMemoLineItemTaxItemNavigations)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_CreditMemoLineItems_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.CreditMemoLineItems)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_CreditMemoLineItems_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<CreditMemoLinkedTransaction>(entity =>
            {
                entity.ToTable("CreditMemoLinkedTransactions", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CREDITMEMOLINKEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CreditMemoId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionLinkType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.CreditMemo)
                    .WithMany(p => p.CreditMemoLinkedTransactions)
                    .HasForeignKey(d => d.CreditMemoId)
                    .HasConstraintName("FK_CreditMemoLinkedTransactions_CreditMemoId_REF_CreditMemos_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CreditMemoLinkedTransactions)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CreditMemoLinkedTransactions_CustomerId_REF_Customers_ID");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CURRENCY_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AsOfDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CurrencyCode).HasColumnType("varchar(3)");

                entity.Property(e => e.CurrencyFormatDecimalPlaces)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("CurrencyFormat_DecimalPlaces");

                entity.Property(e => e.CurrencyFormatDecimalSeparator)
                    .HasColumnType("varchar(6)")
                    .HasColumnName("CurrencyFormat_DecimalSeparator");

                entity.Property(e => e.CurrencyFormatThousandSeparator)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("CurrencyFormat_ThousandSeparator");

                entity.Property(e => e.CurrencyFormatThousandSeparatorGrouping)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("CurrencyFormat_ThousandSeparatorGrouping");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.IsUserDefinedCurrency)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name).HasColumnType("varchar(64)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<CustomColumn>(entity =>
            {
                entity.HasKey(e => e.DataExtId)
                    .HasName("CustomColumns_PRIMARYKEY");

                entity.ToTable("CustomColumns", "QuickBooks");

                entity.HasIndex(e => e.DataExtId, "CDATA_QUICKBOOKS_CUSTOMCOLUMNS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.DataExtId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DataExtID");

                entity.Property(e => e.AssignToObject)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.DataExtFormatString)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.DataExtListRequire)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.DataExtName)
                    .HasColumnType("varchar(31)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.DataExtTxnRequire)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.DataExtType)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OwnerId)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("OwnerID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customers", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CUSTOMERS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasColumnType("varchar(99)");

                entity.Property(e => e.AdditionalContactInfo).HasColumnType("varchar(2000)");

                entity.Property(e => e.AlternateContact).HasColumnType("varchar(41)");

                entity.Property(e => e.AlternatePhone).HasColumnType("varchar(21)");

                entity.Property(e => e.Balance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(31)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(31)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(13)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(21)");

                entity.Property(e => e.Cc).HasColumnType("varchar(1023)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(2000)");

                entity.Property(e => e.ClassName).HasColumnType("varchar(2000)");

                entity.Property(e => e.Company).HasColumnType("varchar(41)");

                entity.Property(e => e.Contact).HasColumnType("varchar(41)");

                entity.Property(e => e.ContactsAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.CreditCardAddress).HasColumnType("varchar(41)");

                entity.Property(e => e.CreditCardExpMonth).HasColumnType("int");

                entity.Property(e => e.CreditCardExpYear).HasColumnType("int");

                entity.Property(e => e.CreditCardNameOnCard).HasColumnType("varchar(41)");

                entity.Property(e => e.CreditCardNumber).HasColumnType("varchar(25)");

                entity.Property(e => e.CreditCardPostalCode).HasColumnType("varchar(41)");

                entity.Property(e => e.CreditLimit).HasColumnType("float");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerBalance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Email).HasColumnType("varchar(1023)");

                entity.Property(e => e.Fax).HasColumnType("varchar(21)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(25)");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(159)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.JobDescription).HasColumnType("varchar(99)");

                entity.Property(e => e.JobEndDate).HasColumnType("date");

                entity.Property(e => e.JobProjectedEndDate).HasColumnType("date");

                entity.Property(e => e.JobStartDate).HasColumnType("date");

                entity.Property(e => e.JobStatus).HasColumnType("varchar(10)");

                entity.Property(e => e.JobType).HasColumnType("varchar(255)");

                entity.Property(e => e.JobTypeId).HasColumnType("varchar(255)");

                entity.Property(e => e.LastName).HasColumnType("varchar(25)");

                entity.Property(e => e.MiddleInitial).HasColumnType("varchar(5)");

                entity.Property(e => e.Name).HasColumnType("varchar(41)");

                entity.Property(e => e.Notes).HasColumnType("varchar(5000)");

                entity.Property(e => e.NotesAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(255)");

                entity.Property(e => e.ParentName).HasColumnType("varchar(255)");

                entity.Property(e => e.Phone).HasColumnType("varchar(21)");

                entity.Property(e => e.PreferredDeliveryMethod).HasColumnType("varchar(20)");

                entity.Property(e => e.PreferredPaymentMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.PreferredPaymentMethodName).HasColumnType("varchar(100)");

                entity.Property(e => e.PriceLevel).HasColumnType("varchar(100)");

                entity.Property(e => e.PriceLevelId).HasColumnType("varchar(255)");

                entity.Property(e => e.ResaleNumber).HasColumnType("varchar(16)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.SalesTaxCountry).HasColumnType("varchar(100)");

                entity.Property(e => e.Salutation).HasColumnType("varchar(15)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(31)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(31)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(13)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(21)");

                entity.Property(e => e.Sublevel).HasColumnType("int");

                entity.Property(e => e.TaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.TaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type).HasColumnType("varchar(255)");

                entity.Property(e => e.TypeId).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Customers_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.JobTypeNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.JobTypeId)
                    .HasConstraintName("FK_Customers_JobTypeId_REF_JobTypes_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Customers_ParentId_REF_Customers_ID");

                entity.HasOne(d => d.PreferredPaymentMethod)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PreferredPaymentMethodId)
                    .HasConstraintName("FK_Customers_PreferredPaymentMethodId_REF_PaymentMethods_ID");

                entity.HasOne(d => d.PriceLevelNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PriceLevelId)
                    .HasConstraintName("FK_Customers_PriceLevelId_REF_PriceLevels_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.SalesRep)
                    .HasConstraintName("FK_Customers_SalesRep_REF_SalesReps_ID");

                entity.HasOne(d => d.TaxCodeNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_Customers_TaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_Customers_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Customers_TypeId_REF_CustomerTypes_ID");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.ToTable("CustomerContacts", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CUSTOMERCONTACTS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactEditSequence).HasColumnType("varchar(500)");

                entity.Property(e => e.ContactFirstName).HasColumnType("varchar(500)");

                entity.Property(e => e.ContactId).HasColumnType("varchar(500)");

                entity.Property(e => e.ContactJobTitle).HasColumnType("varchar(41)");

                entity.Property(e => e.ContactLastName).HasColumnType("varchar(500)");

                entity.Property(e => e.ContactMethods).HasColumnType("varchar(1000)");

                entity.Property(e => e.ContactMiddleName).HasColumnType("varchar(500)");

                entity.Property(e => e.ContactSalutation).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.EditSequence).HasColumnType("varchar(16)");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(1000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerContacts_CustomerId_REF_Customers_ID");
            });

            modelBuilder.Entity<CustomerMessage>(entity =>
            {
                entity.ToTable("CustomerMessages", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CUSTOMERMESSAGES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(101)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<CustomerNote>(entity =>
            {
                entity.ToTable("CustomerNotes", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CUSTOMERNOTES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("varchar(5000)");

                entity.Property(e => e.EditSequence).HasColumnType("varchar(16)");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(1000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.Note).HasColumnType("varchar(5000)");

                entity.Property(e => e.NoteId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerNotes)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerNotes_CustomerID_REF_Customers_ID");
            });

            modelBuilder.Entity<CustomerShippingAddress>(entity =>
            {
                entity.ToTable("CustomerShippingAddresses", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CUSTOMERSHIPPINGADDRESSES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.EditSequence).HasColumnType("varchar(16)");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(1000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.ShipToAddr1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShipToAddr2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShipToAddr3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShipToAddr4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShipToAddr5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShipToCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipToCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipToDefaultShipTo).HasColumnType("bool");

                entity.Property(e => e.ShipToName).HasColumnType("varchar(500)");

                entity.Property(e => e.ShipToNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShipToPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShipToState).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerShippingAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerShippingAddresses_CustomerId_REF_Customers_ID");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.ToTable("CustomerTypes", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_CUSTOMERTYPES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(159)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(255)");

                entity.Property(e => e.ParentName).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_CustomerTypes_ParentId_REF_CustomerTypes_ID");
            });

            modelBuilder.Entity<DateDrivenTerm>(entity =>
            {
                entity.ToTable("DateDrivenTerms", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_DATEDRIVENTERMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.DayOfMonthDue).HasColumnType("int");

                entity.Property(e => e.DiscountDayOfMonth).HasColumnType("int");

                entity.Property(e => e.DiscountPct).HasColumnType("float");

                entity.Property(e => e.DueNextMonthDays).HasColumnType("int");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<DeletedEntity>(entity =>
            {
                entity.HasKey(e => e.ListId)
                    .HasName("DeletedEntities_PRIMARYKEY");

                entity.ToTable("DeletedEntities", "QuickBooks");

                entity.HasIndex(e => e.ListId, "CDATA_QUICKBOOKS_DELETEDENTITIES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.ListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ListID");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ListDelType)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeDeleted)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<DeletedTransaction>(entity =>
            {
                entity.HasKey(e => e.TxnId)
                    .HasName("DeletedTransactions_PRIMARYKEY");

                entity.ToTable("DeletedTransactions", "QuickBooks");

                entity.HasIndex(e => e.TxnId, "CDATA_QUICKBOOKS_DELETEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.TxnId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TxnID");

                entity.Property(e => e.RefNumber)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeDeleted)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnDelType)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.ToTable("Deposits", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_DEPOSITS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CashBackAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.CashBackAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.CashBackAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.CashBackId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CashBackMemo).HasColumnType("varchar(5000)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepositToAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.DepositToAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Payee).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalDeposit)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.CashBackAccountNavigation)
                    .WithMany(p => p.DepositCashBackAccountNavigations)
                    .HasForeignKey(d => d.CashBackAccountId)
                    .HasConstraintName("FK_Deposits_CashBackAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Deposits_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.DepositToAccountNavigation)
                    .WithMany(p => p.DepositDepositToAccountNavigations)
                    .HasForeignKey(d => d.DepositToAccountId)
                    .HasConstraintName("FK_Deposits_DepositToAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.PayeeNavigation)
                    .WithMany(p => p.Deposits)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_Deposits_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<DepositLineItem>(entity =>
            {
                entity.ToTable("DepositLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_DEPOSITLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CashBackAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.CashBackAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.CashBackAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.CashBackId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CashBackMemo).HasColumnType("varchar(5000)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepositId).HasColumnType("varchar(255)");

                entity.Property(e => e.DepositToAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.DepositToAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ItemAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemCheckNumber).HasColumnType("varchar(11)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemEntityId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemEntityName).HasColumnType("varchar(209)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemMemo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemPaymentId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemPaymentLineId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemPaymentMethod).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemPaymentMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemRefId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemTxnType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Payee).HasColumnType("varchar(255)");

                entity.Property(e => e.PayeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalDeposit)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.CashBackAccountNavigation)
                    .WithMany(p => p.DepositLineItemCashBackAccountNavigations)
                    .HasForeignKey(d => d.CashBackAccountId)
                    .HasConstraintName("FK_DepositLineItems_CashBackAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.DepositLineItems)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_DepositLineItems_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.Deposit)
                    .WithMany(p => p.DepositLineItems)
                    .HasForeignKey(d => d.DepositId)
                    .HasConstraintName("FK_DepositLineItems_DepositId_REF_Deposits_ID");

                entity.HasOne(d => d.DepositToAccountNavigation)
                    .WithMany(p => p.DepositLineItemDepositToAccountNavigations)
                    .HasForeignKey(d => d.DepositToAccountId)
                    .HasConstraintName("FK_DepositLineItems_DepositToAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ItemAccountNavigation)
                    .WithMany(p => p.DepositLineItemItemAccountNavigations)
                    .HasForeignKey(d => d.ItemAccountId)
                    .HasConstraintName("FK_DepositLineItems_ItemAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.DepositLineItems)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_DepositLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemPaymentMethodNavigation)
                    .WithMany(p => p.DepositLineItems)
                    .HasForeignKey(d => d.ItemPaymentMethodId)
                    .HasConstraintName("FK_DepositLineItems_ItemPaymentMethodId_REF_PaymentMethods_ID");

                entity.HasOne(d => d.PayeeNavigation)
                    .WithMany(p => p.DepositLineItems)
                    .HasForeignKey(d => d.PayeeId)
                    .HasConstraintName("FK_DepositLineItems_PayeeId_REF_Vendors_ID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_EMPLOYEES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasColumnType("varchar(99)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AlternatePhone).HasColumnType("varchar(21)");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.City).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.DisabilityDescription).HasColumnType("varchar(25)");

                entity.Property(e => e.Disabled).HasColumnType("varchar(10)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Email).HasColumnType("varchar(1023)");

                entity.Property(e => e.EmployeeType).HasColumnType("varchar(13)");

                entity.Property(e => e.Ethnicity).HasColumnType("varchar(20)");

                entity.Property(e => e.Fax).HasColumnType("varchar(21)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(25)");

                entity.Property(e => e.FormOnFile).HasColumnType("varchar(10)");

                entity.Property(e => e.Gender).HasColumnType("varchar(12)");

                entity.Property(e => e.HiredDate).HasColumnType("date");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.JobTitle).HasColumnType("varchar(41)");

                entity.Property(e => e.LastName).HasColumnType("varchar(25)");

                entity.Property(e => e.Line1).HasColumnType("varchar(500)");

                entity.Property(e => e.Line2).HasColumnType("varchar(500)");

                entity.Property(e => e.MiddleInitial).HasColumnType("varchar(25)");

                entity.Property(e => e.MilitaryStatus).HasColumnType("varchar(10)");

                entity.Property(e => e.MobilePhone).HasColumnType("varchar(21)");

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.Notes).HasColumnType("varchar(5000)");

                entity.Property(e => e.Pager).HasColumnType("varchar(21)");

                entity.Property(e => e.PagerPin)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("PagerPIN");

                entity.Property(e => e.PayPeriod).HasColumnType("varchar(13)");

                entity.Property(e => e.PayrollClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayrollClassName).HasColumnType("varchar(159)");

                entity.Property(e => e.Phone).HasColumnType("varchar(21)");

                entity.Property(e => e.PostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.PrintAs).HasColumnType("varchar(110)");

                entity.Property(e => e.ReleasedDate).HasColumnType("date");

                entity.Property(e => e.Salutation).HasColumnType("varchar(15)");

                entity.Property(e => e.SickTimeAccrualPeriod).HasColumnType("varchar(19)");

                entity.Property(e => e.SickTimeAccrualStartDate).HasColumnType("date");

                entity.Property(e => e.SickTimeAccrued).HasColumnType("varchar(30)");

                entity.Property(e => e.SickTimeAvailable).HasColumnType("varchar(30)");

                entity.Property(e => e.SickTimeMaximum).HasColumnType("varchar(30)");

                entity.Property(e => e.SickTimeUsed).HasColumnType("varchar(30)");

                entity.Property(e => e.SickTimeYearlyReset).HasColumnType("bool");

                entity.Property(e => e.Ssn)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("SSN");

                entity.Property(e => e.State).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeDataForPaychecks).HasColumnType("varchar(18)");

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Uscitizen)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("USCitizen");

                entity.Property(e => e.Usveteran)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("USVeteran");

                entity.Property(e => e.VacationTimeAccrualPeriod).HasColumnType("varchar(19)");

                entity.Property(e => e.VacationTimeAccrualStartDate).HasColumnType("date");

                entity.Property(e => e.VacationTimeAccrued).HasColumnType("varchar(30)");

                entity.Property(e => e.VacationTimeAvailable).HasColumnType("varchar(30)");

                entity.Property(e => e.VacationTimeMaximum).HasColumnType("varchar(30)");

                entity.Property(e => e.VacationTimeUsed).HasColumnType("varchar(30)");

                entity.Property(e => e.VacationTimeYearlyReset).HasColumnType("bool");

                entity.HasOne(d => d.PayrollClass)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PayrollClassId)
                    .HasConstraintName("FK_Employees_PayrollClassId_REF_Class_ID");
            });

            modelBuilder.Entity<EmployeeEarning>(entity =>
            {
                entity.ToTable("EmployeeEarnings", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_EMPLOYEEEARNINGS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EarningsId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EarningsRate).HasColumnType("float");

                entity.Property(e => e.EarningsRatePercent).HasColumnType("varchar(2000)");

                entity.Property(e => e.EarningsWageId).HasColumnType("varchar(255)");

                entity.Property(e => e.EarningsWageName).HasColumnType("varchar(31)");

                entity.Property(e => e.EmployeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PayPeriod).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeEarnings)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeEarnings_EmployeeId_REF_Employees_ID");
            });

            modelBuilder.Entity<Estimate>(entity =>
            {
                entity.ToTable("Estimates", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ESTIMATES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerSalesTaxId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerSalesTaxName).HasColumnType("varchar(3)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.Other).HasColumnType("varchar(29)");

                entity.Property(e => e.Ponumber)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("PONumber");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Tax)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAggregate)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.Estimates)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Estimates_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Estimates)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Estimates_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerSalesTax)
                    .WithMany(p => p.Estimates)
                    .HasForeignKey(d => d.CustomerSalesTaxId)
                    .HasConstraintName("FK_Estimates_CustomerSalesTaxId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.Estimates)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_Estimates_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.Estimates)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_Estimates_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.Estimates)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_Estimates_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.Estimates)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_Estimates_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<EstimateLineItem>(entity =>
            {
                entity.ToTable("EstimateLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ESTIMATELINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerSalesTaxId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerSalesTaxName).HasColumnType("varchar(3)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EstimateId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemIsGetPrintItemsInGroup).HasColumnType("varchar(1000)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemLineID");

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemMarkupRate).HasColumnType("float");

                entity.Property(e => e.ItemMarkupRatePercent).HasColumnType("float");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemOther1).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemOther2).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemRate).HasColumnType("float");

                entity.Property(e => e.ItemRatePercent).HasColumnType("float");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemUomsetFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetFullName");

                entity.Property(e => e.ItemUomsetListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetListID");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.Ponumber)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("PONumber");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Tax)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.EstimateLineItemClassNavigations)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_EstimateLineItems_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.EstimateLineItems)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_EstimateLineItems_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerSalesTax)
                    .WithMany(p => p.EstimateLineItemCustomerSalesTaxes)
                    .HasForeignKey(d => d.CustomerSalesTaxId)
                    .HasConstraintName("FK_EstimateLineItems_CustomerSalesTaxId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Estimate)
                    .WithMany(p => p.EstimateLineItems)
                    .HasForeignKey(d => d.EstimateId)
                    .HasConstraintName("FK_EstimateLineItems_EstimateId_REF_Estimates_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.EstimateLineItemItemClassNavigations)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_EstimateLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.EstimateLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_EstimateLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.EstimateLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_EstimateLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySiteNameNavigation)
                    .WithMany(p => p.EstimateLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteName)
                    .HasConstraintName("FK_EstimateLineItems_ItemInventorySiteName_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.EstimateLineItemItemTaxCodeNavigations)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_EstimateLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.ItemUomsetList)
                    .WithMany(p => p.EstimateLineItems)
                    .HasForeignKey(d => d.ItemUomsetListId)
                    .HasConstraintName("FK_EstimateLineItems_ItemUOMSetListID_REF_UnitOfMeasure_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.EstimateLineItems)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_EstimateLineItems_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.EstimateLineItems)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_EstimateLineItems_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.EstimateLineItems)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_EstimateLineItems_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.EstimateLineItems)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_EstimateLineItems_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<EstimateLinkedTransaction>(entity =>
            {
                entity.ToTable("EstimateLinkedTransactions", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ESTIMATELINKEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomerName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EstimateId).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionLinkType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.EstimateLinkedTransactions)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_EstimateLinkedTransactions_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.Estimate)
                    .WithMany(p => p.EstimateLinkedTransactions)
                    .HasForeignKey(d => d.EstimateId)
                    .HasConstraintName("FK_EstimateLinkedTransactions_EstimateId_REF_Estimates_ID");
            });

            modelBuilder.Entity<Host>(entity =>
            {
                entity.HasKey(e => e.ProductName)
                    .HasName("Host_PRIMARYKEY");

                entity.ToTable("Host", "QuickBooks");

                entity.HasIndex(e => e.ProductName, "CDATA_QUICKBOOKS_HOST_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.ProductName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Country)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsAutomaticLogin)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.MajorVersion)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.MinorVersion)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QbfileMode)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("QBFileMode");

                entity.Property(e => e.SupportedQbxmlversion)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SupportedQBXMLVersion");
            });

            modelBuilder.Entity<InventoryAdjustment>(entity =>
            {
                entity.ToTable("InventoryAdjustments", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_INVENTORYADJUSTMENTS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.InventorySite).HasColumnType("varchar(31)");

                entity.Property(e => e.InventorySiteId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.InventoryAdjustments)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_InventoryAdjustments_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.InventoryAdjustments)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_InventoryAdjustments_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.InventoryAdjustments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_InventoryAdjustments_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.InventorySiteNavigation)
                    .WithMany(p => p.InventoryAdjustments)
                    .HasForeignKey(d => d.InventorySiteId)
                    .HasConstraintName("FK_InventoryAdjustments_InventorySiteId_REF_InventorySites_ID");
            });

            modelBuilder.Entity<InventoryAdjustmentLineItem>(entity =>
            {
                entity.ToTable("InventoryAdjustmentLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_INVENTORYADJUSTMENTLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.InventoryAdjustmentId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("InventoryAdjustmentID");

                entity.Property(e => e.InventorySite).HasColumnType("varchar(31)");

                entity.Property(e => e.InventorySiteId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemLineId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLotNumber).HasColumnType("varchar(40)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemNewQuantity).HasColumnType("float");

                entity.Property(e => e.ItemNewValue).HasColumnType("float");

                entity.Property(e => e.ItemQuantityDiff).HasColumnType("float");

                entity.Property(e => e.ItemSerialNumber).HasColumnType("varchar(4095)");

                entity.Property(e => e.ItemSerialNumberAddedOrRemoved).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemValueDiff).HasColumnType("float");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.InventoryAdjustmentLineItems)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_InventoryAdjustmentLineItems_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.InventoryAdjustmentLineItems)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_InventoryAdjustmentLineItems_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.InventoryAdjustmentLineItems)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_InventoryAdjustmentLineItems_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.InventoryAdjustment)
                    .WithMany(p => p.InventoryAdjustmentLineItems)
                    .HasForeignKey(d => d.InventoryAdjustmentId)
                    .HasConstraintName("FK_InventoryAdjustmentLineItems_InventoryAdjustmentID_REF_InventoryAdjustments_ID");

                entity.HasOne(d => d.InventorySiteNavigation)
                    .WithMany(p => p.InventoryAdjustmentLineItems)
                    .HasForeignKey(d => d.InventorySiteId)
                    .HasConstraintName("FK_InventoryAdjustmentLineItems_InventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InventoryAdjustmentLineItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_InventoryAdjustmentLineItems_ItemId_REF_Items_ID");
            });

            modelBuilder.Entity<InventorySite>(entity =>
            {
                entity.ToTable("InventorySites", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_INVENTORYSITES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Contact).HasColumnType("varchar(41)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Email).HasColumnType("varchar(1023)");

                entity.Property(e => e.Fax).HasColumnType("varchar(21)");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.IsDefaultSite)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.Phone).HasColumnType("varchar(21)");

                entity.Property(e => e.SiteAddressAddr1)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("SiteAddress_Addr1");

                entity.Property(e => e.SiteAddressAddr2)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("SiteAddress_Addr2");

                entity.Property(e => e.SiteAddressAddr3)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("SiteAddress_Addr3");

                entity.Property(e => e.SiteAddressAddr4)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("SiteAddress_Addr4");

                entity.Property(e => e.SiteAddressAddr5)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("SiteAddress_Addr5");

                entity.Property(e => e.SiteAddressCity)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SiteAddress_City");

                entity.Property(e => e.SiteAddressCountry)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SiteAddress_Country");

                entity.Property(e => e.SiteAddressPostalCode)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("SiteAddress_PostalCode");

                entity.Property(e => e.SiteAddressState)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SiteAddress_State");

                entity.Property(e => e.SiteDesc).HasColumnType("varchar(100)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoices", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_INVOICES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Balance).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.BalanceInHomeCurrency).HasColumnType("float");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.CustomerTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsFinanceCharge).HasColumnType("varchar(16)");

                entity.Property(e => e.IsPaid)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsPending).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.Other).HasColumnType("varchar(29)");

                entity.Property(e => e.Ponumber)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("POnumber");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipDate).HasColumnType("date");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SuggestedDiscountAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.SuggestedDiscountDate).HasColumnType("date");

                entity.Property(e => e.Tax)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAggregate)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Invoices_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Invoices_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Invoices_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Invoices_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerTaxCodeNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerTaxCodeId)
                    .HasConstraintName("FK_Invoices_CustomerTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_Invoices_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_Invoices_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_Invoices_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_Invoices_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_Invoices_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<InvoiceLineItem>(entity =>
            {
                entity.ToTable("InvoiceLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_INVOICELINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Balance).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.BalanceInHomeCurrency).HasColumnType("float");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.CustomerTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.InvoiceId).HasColumnType("varchar(255)");

                entity.Property(e => e.IsFinanceCharge).HasColumnType("varchar(16)");

                entity.Property(e => e.IsPaid)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsPending).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemIsGetPrintItemsInGroup).HasColumnType("varchar(1000)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLotNumber).HasColumnType("varchar(40)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemOther1).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemOther2).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemRate).HasColumnType("float");

                entity.Property(e => e.ItemRatePercent).HasColumnType("float");

                entity.Property(e => e.ItemSerialNumber).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemServiceDate).HasColumnType("date");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemUomsetFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetFullName");

                entity.Property(e => e.ItemUomsetListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetListID");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.Other).HasColumnType("varchar(29)");

                entity.Property(e => e.Ponumber)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("PONumber");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipDate).HasColumnType("date");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SuggestedDiscountAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.SuggestedDiscountDate).HasColumnType("date");

                entity.Property(e => e.Tax)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_InvoiceLineItems_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.InvoiceLineItemClassNavigations)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_InvoiceLineItems_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_InvoiceLineItems_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_InvoiceLineItems_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerTaxCodeNavigation)
                    .WithMany(p => p.InvoiceLineItemCustomerTaxCodeNavigations)
                    .HasForeignKey(d => d.CustomerTaxCodeId)
                    .HasConstraintName("FK_InvoiceLineItems_CustomerTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_InvoiceLineItems_InvoiceId_REF_Invoices_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.InvoiceLineItemItemClassNavigations)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_InvoiceLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.InvoiceLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_InvoiceLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvoiceLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_InvoiceLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySite)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteId)
                    .HasConstraintName("FK_InvoiceLineItems_ItemInventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.InvoiceLineItemItemTaxCodeNavigations)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_InvoiceLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.ItemUomsetList)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.ItemUomsetListId)
                    .HasConstraintName("FK_InvoiceLineItems_ItemUOMSetListID_REF_UnitOfMeasure_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_InvoiceLineItems_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_InvoiceLineItems_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_InvoiceLineItems_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_InvoiceLineItems_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_InvoiceLineItems_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<InvoiceLinkedTransaction>(entity =>
            {
                entity.ToTable("InvoiceLinkedTransactions", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_INVOICELINKEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AccountId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomerId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomerName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.InvoiceId).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionLinkType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.InvoiceLinkedTransactions)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_InvoiceLinkedTransactions_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.InvoiceLinkedTransactions)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_InvoiceLinkedTransactions_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceLinkedTransactions)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_InvoiceLinkedTransactions_InvoiceId_REF_Invoices_ID");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Items", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AssetAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.AssetAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AssetAcquiredAs).HasColumnType("varchar(3)");

                entity.Property(e => e.AssetBookValue).HasColumnType("float");

                entity.Property(e => e.AssetCostBasis).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AssetDepreciation).HasColumnType("float");

                entity.Property(e => e.AssetDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.AssetLocation).HasColumnType("varchar(50)");

                entity.Property(e => e.AssetNotes).HasColumnType("varchar(5000)");

                entity.Property(e => e.AssetNumber).HasColumnType("varchar(10)");

                entity.Property(e => e.AssetPonumber)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("AssetPONumber");

                entity.Property(e => e.AssetSerialNumber).HasColumnType("varchar(5000)");

                entity.Property(e => e.AssetWarrantyExpires).HasColumnType("date");

                entity.Property(e => e.AverageCost)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Barcode).HasColumnType("varchar(50)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.Cogsaccount)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("COGSAccount");

                entity.Property(e => e.CogsaccountId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("COGSAccountId");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.DateSold).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(5000)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(159)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.InventoryDate).HasColumnType("date");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.IsPrintItemsInGroup).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemCount).HasColumnType("int");

                entity.Property(e => e.LineAggregate)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(255)");

                entity.Property(e => e.ParentName).HasColumnType("varchar(255)");

                entity.Property(e => e.PartNumber).HasColumnType("varchar(31)");

                entity.Property(e => e.PaymentMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.PaymentMethodName).HasColumnType("varchar(100)");

                entity.Property(e => e.PreferredVendor).HasColumnType("varchar(255)");

                entity.Property(e => e.PreferredVendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.Price).HasColumnType("float");

                entity.Property(e => e.PricePercent).HasColumnType("float");

                entity.Property(e => e.PurchaseCost).HasColumnType("float");

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.PurchaseDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.PurchaseTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.PurchaseTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.QuantityOnHand)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityOnOrder)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityOnSalesOrder)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReorderPoint).HasColumnType("float");

                entity.Property(e => e.SalesExpense).HasColumnType("varchar(2000)");

                entity.Property(e => e.SpecialItemType).HasColumnType("varchar(50)");

                entity.Property(e => e.Sublevel)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.TaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxRate).HasColumnType("float");

                entity.Property(e => e.TaxVendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxVendorName).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type).HasColumnType("varchar(100)");

                entity.Property(e => e.UnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.UnitOfMeasureId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorOrPayeeName).HasColumnType("varchar(50)");

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.ItemAccountNavigations)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Items_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.AssetAccountNavigation)
                    .WithMany(p => p.ItemAssetAccountNavigations)
                    .HasForeignKey(d => d.AssetAccountId)
                    .HasConstraintName("FK_Items_AssetAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Items_ClassId_REF_Class_ID");

                entity.HasOne(d => d.CogsaccountNavigation)
                    .WithMany(p => p.ItemCogsaccountNavigations)
                    .HasForeignKey(d => d.CogsaccountId)
                    .HasConstraintName("FK_Items_COGSAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ExpenseAccountNavigation)
                    .WithMany(p => p.ItemExpenseAccountNavigations)
                    .HasForeignKey(d => d.ExpenseAccountId)
                    .HasConstraintName("FK_Items_ExpenseAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Items_ParentId_REF_Items_ID");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_Items_PaymentMethodId_REF_PaymentMethods_ID");

                entity.HasOne(d => d.PreferredVendorNavigation)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.PreferredVendorId)
                    .HasConstraintName("FK_Items_PreferredVendorId_REF_Vendors_ID");

                entity.HasOne(d => d.PurchaseTaxCodeNavigation)
                    .WithMany(p => p.ItemPurchaseTaxCodeNavigations)
                    .HasForeignKey(d => d.PurchaseTaxCodeId)
                    .HasConstraintName("FK_Items_PurchaseTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.TaxCodeNavigation)
                    .WithMany(p => p.ItemTaxCodeNavigations)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_Items_TaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.TaxVendor)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.TaxVendorId)
                    .HasConstraintName("FK_Items_TaxVendorId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.UnitOfMeasureNavigation)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.UnitOfMeasureId)
                    .HasConstraintName("FK_Items_UnitOfMeasureId_REF_UnitOfMeasure_ID");
            });

            modelBuilder.Entity<ItemLineItem>(entity =>
            {
                entity.ToTable("ItemLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ITEMLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AssetAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.AssetAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AverageCost)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Barcode).HasColumnType("varchar(2000)");

                entity.Property(e => e.Cogsaccount)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("COGSAccount");

                entity.Property(e => e.CogsaccountId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("COGSAccountId");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Description).HasColumnType("varchar(5000)");

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(1000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.LineItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.LineItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.LineItemNumber).HasColumnType("int");

                entity.Property(e => e.LineItemQuantity).HasColumnType("float");

                entity.Property(e => e.LineItemUnitOfMeasure).HasColumnType("varchar(2000)");

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.ParentId).HasColumnType("varchar(255)");

                entity.Property(e => e.ParentName).HasColumnType("varchar(255)");

                entity.Property(e => e.PreferredVendor).HasColumnType("varchar(255)");

                entity.Property(e => e.PreferredVendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.Price).HasColumnType("float");

                entity.Property(e => e.PurchaseCost).HasColumnType("float");

                entity.Property(e => e.PurchaseDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.TaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.TaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type).HasColumnType("varchar(100)");

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.ItemLineItemAccountNavigations)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_ItemLineItems_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.AssetAccountNavigation)
                    .WithMany(p => p.ItemLineItemAssetAccountNavigations)
                    .HasForeignKey(d => d.AssetAccountId)
                    .HasConstraintName("FK_ItemLineItems_AssetAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.CogsaccountNavigation)
                    .WithMany(p => p.ItemLineItemCogsaccountNavigations)
                    .HasForeignKey(d => d.CogsaccountId)
                    .HasConstraintName("FK_ItemLineItems_COGSAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.ItemLineItemLineItems)
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("FK_ItemLineItems_LineItemId_REF_Items_ID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ItemLineItemParents)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_ItemLineItems_ParentId_REF_Items_ID");

                entity.HasOne(d => d.PreferredVendorNavigation)
                    .WithMany(p => p.ItemLineItems)
                    .HasForeignKey(d => d.PreferredVendorId)
                    .HasConstraintName("FK_ItemLineItems_PreferredVendorId_REF_Vendors_ID");

                entity.HasOne(d => d.TaxCodeNavigation)
                    .WithMany(p => p.ItemLineItems)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_ItemLineItems_TaxCodeId_REF_SalesTaxCodes_ID");
            });

            modelBuilder.Entity<ItemReceipt>(entity =>
            {
                entity.ToTable("ItemReceipts", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ITEMRECEIPTS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpenseItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAggregate)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.ItemReceipts)
                    .HasForeignKey(d => d.AccountsPayable)
                    .HasConstraintName("FK_ItemReceipts_AccountsPayable_REF_Accounts_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ItemReceipts)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_ItemReceipts_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<ItemReceiptExpenseItem>(entity =>
            {
                entity.ToTable("ItemReceiptExpenseItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ITEMRECEIPTEXPENSEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpenseAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ExpenseBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ExpenseClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomFields)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ExpenseTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemReceiptId).HasColumnType("varchar(255)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.ItemReceiptExpenseItemAccountsPayableNavigations)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_ItemReceiptExpenseItems_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.ExpenseAccountNavigation)
                    .WithMany(p => p.ItemReceiptExpenseItemExpenseAccountNavigations)
                    .HasForeignKey(d => d.ExpenseAccountId)
                    .HasConstraintName("FK_ItemReceiptExpenseItems_ExpenseAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ExpenseClassNavigation)
                    .WithMany(p => p.ItemReceiptExpenseItems)
                    .HasForeignKey(d => d.ExpenseClassId)
                    .HasConstraintName("FK_ItemReceiptExpenseItems_ExpenseClassId_REF_Class_ID");

                entity.HasOne(d => d.ExpenseCustomerNavigation)
                    .WithMany(p => p.ItemReceiptExpenseItems)
                    .HasForeignKey(d => d.ExpenseCustomerId)
                    .HasConstraintName("FK_ItemReceiptExpenseItems_ExpenseCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ExpenseTaxCodeNavigation)
                    .WithMany(p => p.ItemReceiptExpenseItems)
                    .HasForeignKey(d => d.ExpenseTaxCodeId)
                    .HasConstraintName("FK_ItemReceiptExpenseItems_ExpenseTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.ItemReceipt)
                    .WithMany(p => p.ItemReceiptExpenseItems)
                    .HasForeignKey(d => d.ItemReceiptId)
                    .HasConstraintName("FK_ItemReceiptExpenseItems_ItemReceiptId_REF_ItemReceipts_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ItemReceiptExpenseItems)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_ItemReceiptExpenseItems_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<ItemReceiptLineItem>(entity =>
            {
                entity.ToTable("ItemReceiptLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ITEMRECEIPTLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCost).HasColumnType("float");

                entity.Property(e => e.ItemCustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLotNumber).HasColumnType("varchar(40)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemReceiptId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemSerialNumber).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.ItemReceiptLineItems)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_ItemReceiptLineItems_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.ItemReceiptLineItems)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_ItemReceiptLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemCustomerNavigation)
                    .WithMany(p => p.ItemReceiptLineItems)
                    .HasForeignKey(d => d.ItemCustomerId)
                    .HasConstraintName("FK_ItemReceiptLineItems_ItemCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.ItemReceiptLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_ItemReceiptLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemReceiptLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_ItemReceiptLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySiteNameNavigation)
                    .WithMany(p => p.ItemReceiptLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteName)
                    .HasConstraintName("FK_ItemReceiptLineItems_ItemInventorySiteName_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemReceipt)
                    .WithMany(p => p.ItemReceiptLineItems)
                    .HasForeignKey(d => d.ItemReceiptId)
                    .HasConstraintName("FK_ItemReceiptLineItems_ItemReceiptId_REF_ItemReceipts_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.ItemReceiptLineItems)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_ItemReceiptLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ItemReceiptLineItems)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_ItemReceiptLineItems_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<ItemReceiptLinkedTransaction>(entity =>
            {
                entity.ToTable("ItemReceiptLinkedTransactions", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ITEMRECEIPTLINKEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ItemReceiptId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionLinkType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionReferenceNumber)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.ItemReceiptLinkedTransactions)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_ItemReceiptLinkedTransactions_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.ItemReceipt)
                    .WithMany(p => p.ItemReceiptLinkedTransactions)
                    .HasForeignKey(d => d.ItemReceiptId)
                    .HasConstraintName("FK_ItemReceiptLinkedTransactions_ItemReceiptId_REF_ItemReceipts_ID");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.ItemReceiptLinkedTransactions)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_ItemReceiptLinkedTransactions_TransactionId_REF_PurchaseOrders_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ItemReceiptLinkedTransactions)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_ItemReceiptLinkedTransactions_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<ItemSite>(entity =>
            {
                entity.ToTable("ItemSites", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_ITEMSITES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AssemblyBuildPoint)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.InventorySiteLocationRefFullName)
                    .HasColumnType("varchar(31)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("InventorySiteLocationRef_FullName");

                entity.Property(e => e.InventorySiteLocationRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("InventorySiteLocationRef_ListID");

                entity.Property(e => e.InventorySiteRefFullName)
                    .HasColumnType("varchar(31)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("InventorySiteRef_FullName");

                entity.Property(e => e.InventorySiteRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("InventorySiteRef_ListID");

                entity.Property(e => e.ItemInventoryAssemblyRefFullName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemInventoryAssemblyRef_FullName");

                entity.Property(e => e.ItemInventoryAssemblyRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemInventoryAssemblyRef_ListID");

                entity.Property(e => e.ItemInventoryRefFullName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemInventoryRef_FullName");

                entity.Property(e => e.ItemInventoryRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemInventoryRef_ListID");

                entity.Property(e => e.QuantityOnHand)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityOnPendingTransfers)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityOnPurchaseOrders)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityOnSalesOrders)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityRequiredByPendingBuildTxns)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.QuantityToBeBuiltByPendingBuildTxns)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReorderLevel)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.InventorySiteRefList)
                    .WithMany(p => p.ItemSites)
                    .HasForeignKey(d => d.InventorySiteRefListId)
                    .HasConstraintName("FK_ItemSites_InventorySiteRef_ListID_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemInventoryAssemblyRefList)
                    .WithMany(p => p.ItemSiteItemInventoryAssemblyRefLists)
                    .HasForeignKey(d => d.ItemInventoryAssemblyRefListId)
                    .HasConstraintName("FK_ItemSites_ItemInventoryAssemblyRef_ListID_REF_Items_ID");

                entity.HasOne(d => d.ItemInventoryRefList)
                    .WithMany(p => p.ItemSiteItemInventoryRefLists)
                    .HasForeignKey(d => d.ItemInventoryRefListId)
                    .HasConstraintName("FK_ItemSites_ItemInventoryRef_ListID_REF_Items_ID");
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.ToTable("JobTypes", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_JOBTYPES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.FullName)
                    .HasColumnType("varchar(1000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.ParentRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentRef_FullName");

                entity.Property(e => e.ParentRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentRef_ListId");

                entity.Property(e => e.Sublevel)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ParentRefList)
                    .WithMany(p => p.InverseParentRefList)
                    .HasForeignKey(d => d.ParentRefListId)
                    .HasConstraintName("FK_JobTypes_ParentRef_ListId_REF_JobTypes_ID");
            });

            modelBuilder.Entity<JournalEntry>(entity =>
            {
                entity.ToTable("JournalEntries", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_JOURNALENTRIES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CreditLineCount).HasColumnType("int");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DebitLineCount).HasColumnType("int");

                entity.Property(e => e.EditSequence).HasColumnType("varchar(16)");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.FirstCreditAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.FirstCreditAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.FirstCreditEntityId).HasColumnType("varchar(2000)");

                entity.Property(e => e.FirstCreditEntityName).HasColumnType("varchar(2000)");

                entity.Property(e => e.FirstCreditMemo).HasColumnType("varchar(2000)");

                entity.Property(e => e.FirstDebitAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.FirstDebitAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.FirstDebitEntityId).HasColumnType("varchar(2000)");

                entity.Property(e => e.FirstDebitEntityName).HasColumnType("varchar(2000)");

                entity.Property(e => e.FirstDebitMemo).HasColumnType("varchar(2000)");

                entity.Property(e => e.IsHomeCurrencyAdjustment).HasColumnType("bool");

                entity.Property(e => e.LineAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_JournalEntries_CurrencyId_REF_Currency_ID");
            });

            modelBuilder.Entity<JournalEntryLine>(entity =>
            {
                entity.ToTable("JournalEntryLines", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_JOURNALENTRYLINES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CreditLineCount).HasColumnType("int");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DebitLineCount).HasColumnType("int");

                entity.Property(e => e.EditSequence).HasColumnType("varchar(16)");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.IsHomeCurrencyAdjustment).HasColumnType("bool");

                entity.Property(e => e.JournalEntryId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("JournalEntryID");

                entity.Property(e => e.LineAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.LineAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.LineAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.LineClass).HasColumnType("varchar(255)");

                entity.Property(e => e.LineClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.LineEntityId).HasColumnType("varchar(255)");

                entity.Property(e => e.LineEntityName).HasColumnType("varchar(1000)");

                entity.Property(e => e.LineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.LineMemo).HasColumnType("varchar(5000)");

                entity.Property(e => e.LineStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.LineTaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.LineTaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.LineType).HasColumnType("varchar(100)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated).HasColumnType("datetime");

                entity.Property(e => e.TimeModified).HasColumnType("datetime");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.JournalEntryLines)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_JournalEntryLines_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.JournalEntry)
                    .WithMany(p => p.JournalEntryLines)
                    .HasForeignKey(d => d.JournalEntryId)
                    .HasConstraintName("FK_JournalEntryLines_JournalEntryID_REF_JournalEntries_ID");

                entity.HasOne(d => d.LineAccountNavigation)
                    .WithMany(p => p.JournalEntryLines)
                    .HasForeignKey(d => d.LineAccountId)
                    .HasConstraintName("FK_JournalEntryLines_LineAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.LineClassNavigation)
                    .WithMany(p => p.JournalEntryLines)
                    .HasForeignKey(d => d.LineClassId)
                    .HasConstraintName("FK_JournalEntryLines_LineClassId_REF_Class_ID");

                entity.HasOne(d => d.LineTaxItemNavigation)
                    .WithMany(p => p.JournalEntryLines)
                    .HasForeignKey(d => d.LineTaxItemId)
                    .HasConstraintName("FK_JournalEntryLines_LineTaxItemId_REF_SalesTaxItems_ID");
            });

            modelBuilder.Entity<OtherName>(entity =>
            {
                entity.ToTable("OtherNames", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_OTHERNAMES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasColumnType("varchar(99)");

                entity.Property(e => e.AltContact).HasColumnType("varchar(41)");

                entity.Property(e => e.AltPhone).HasColumnType("varchar(41)");

                entity.Property(e => e.CompanyName).HasColumnType("varchar(41)");

                entity.Property(e => e.Contact).HasColumnType("varchar(41)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Email).HasColumnType("varchar(1023)");

                entity.Property(e => e.ExternalGuid)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("ExternalGUID");

                entity.Property(e => e.Fax).HasColumnType("varchar(21)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(25)");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.LastName).HasColumnType("varchar(25)");

                entity.Property(e => e.MiddleName).HasColumnType("varchar(25)");

                entity.Property(e => e.Name).HasColumnType("varchar(41)");

                entity.Property(e => e.Notes).HasColumnType("varchar(5000)");

                entity.Property(e => e.OtherNameAddressAddr1)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("OtherNameAddress_Addr1");

                entity.Property(e => e.OtherNameAddressAddr2)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("OtherNameAddress_Addr2");

                entity.Property(e => e.OtherNameAddressAddr3)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("OtherNameAddress_Addr3");

                entity.Property(e => e.OtherNameAddressAddr4)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("OtherNameAddress_Addr4");

                entity.Property(e => e.OtherNameAddressAddr5)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("OtherNameAddress_Addr5");

                entity.Property(e => e.OtherNameAddressCity)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OtherNameAddress_City");

                entity.Property(e => e.OtherNameAddressCountry)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OtherNameAddress_Country");

                entity.Property(e => e.OtherNameAddressNote)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("OtherNameAddress_Note");

                entity.Property(e => e.OtherNameAddressPostalCode)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("OtherNameAddress_PostalCode");

                entity.Property(e => e.OtherNameAddressState)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("OtherNameAddress_State");

                entity.Property(e => e.Phone).HasColumnType("varchar(21)");

                entity.Property(e => e.Salutation).HasColumnType("varchar(15)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("PaymentMethods", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_PAYMENTMETHODS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.PaymentMethodType).HasColumnType("varchar(100)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<PayrollNonWageItem>(entity =>
            {
                entity.ToTable("PayrollNonWageItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_PAYROLLNONWAGEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseAccountRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ExpenseAccountRef_FullName");

                entity.Property(e => e.ExpenseAccountRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ExpenseAccountRef_ListID");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.LiabilityAccountRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("LiabilityAccountRef_FullName");

                entity.Property(e => e.LiabilityAccountRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("LiabilityAccountRef_ListID");

                entity.Property(e => e.Name).HasColumnType("varchar(2000)");

                entity.Property(e => e.NonWageType).HasColumnType("varchar(2000)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ExpenseAccountRefList)
                    .WithMany(p => p.PayrollNonWageItemExpenseAccountRefLists)
                    .HasForeignKey(d => d.ExpenseAccountRefListId)
                    .HasConstraintName("FK_PayrollNonWageItems_ExpenseAccountRef_ListID_REF_Accounts_ID");

                entity.HasOne(d => d.LiabilityAccountRefList)
                    .WithMany(p => p.PayrollNonWageItemLiabilityAccountRefLists)
                    .HasForeignKey(d => d.LiabilityAccountRefListId)
                    .HasConstraintName("FK_PayrollNonWageItems_LiabilityAccountRef_ListID_REF_Accounts_ID");
            });

            modelBuilder.Entity<PayrollWageItem>(entity =>
            {
                entity.ToTable("PayrollWageItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_PAYROLLWAGEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseAccountRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ExpenseAccountRef_FullName");

                entity.Property(e => e.ExpenseAccountRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ExpenseAccountRef_ListID");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(2000)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.WageType).HasColumnType("varchar(2000)");

                entity.HasOne(d => d.ExpenseAccountRefList)
                    .WithMany(p => p.PayrollWageItems)
                    .HasForeignKey(d => d.ExpenseAccountRefListId)
                    .HasConstraintName("FK_PayrollWageItems_ExpenseAccountRef_ListID_REF_Accounts_ID");
            });

            modelBuilder.Entity<Preference>(entity =>
            {
                entity.ToTable("Preferences", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_PREFERENCES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountingPreferencesAssignClassTo)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("AccountingPreferences_AssignClassTo");

                entity.Property(e => e.AccountingPreferencesClosingDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("AccountingPreferences_ClosingDate");

                entity.Property(e => e.AccountingPreferencesIsAssigningJournalEntryNumbers)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("AccountingPreferences_IsAssigningJournalEntryNumbers");

                entity.Property(e => e.AccountingPreferencesIsRequiringAccounts)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("AccountingPreferences_IsRequiringAccounts");

                entity.Property(e => e.AccountingPreferencesIsUsingAccountNumbers)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("AccountingPreferences_IsUsingAccountNumbers");

                entity.Property(e => e.AccountingPreferencesIsUsingAuditTrail)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("AccountingPreferences_IsUsingAuditTrail");

                entity.Property(e => e.AccountingPreferencesIsUsingClassTracking)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("AccountingPreferences_IsUsingClassTracking");

                entity.Property(e => e.CurrentAppAccessRightsAutomaticLoginUserName)
                    .HasColumnType("varchar(29)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("CurrentAppAccessRights_AutomaticLoginUserName");

                entity.Property(e => e.CurrentAppAccessRightsIsAutomaticLoginAllowed)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("CurrentAppAccessRights_IsAutomaticLoginAllowed");

                entity.Property(e => e.CurrentAppAccessRightsIsPersonalDataAccessAllowed)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("CurrentAppAccessRights_IsPersonalDataAccessAllowed");

                entity.Property(e => e.FinanceChargePreferencesAnnualInterestRate)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("FinanceChargePreferences_AnnualInterestRate");

                entity.Property(e => e.FinanceChargePreferencesCalculateChargesFrom)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("FinanceChargePreferences_CalculateChargesFrom");

                entity.Property(e => e.FinanceChargePreferencesFinanceChargeAccountRefFullName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("FinanceChargePreferences_FinanceChargeAccountRef_FullName");

                entity.Property(e => e.FinanceChargePreferencesFinanceChargeAccountRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("FinanceChargePreferences_FinanceChargeAccountRef_ListID");

                entity.Property(e => e.FinanceChargePreferencesGracePeriod)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("FinanceChargePreferences_GracePeriod");

                entity.Property(e => e.FinanceChargePreferencesIsAssessingForOverdueCharges)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("FinanceChargePreferences_IsAssessingForOverdueCharges");

                entity.Property(e => e.FinanceChargePreferencesIsMarkedToBePrinted)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("FinanceChargePreferences_IsMarkedToBePrinted");

                entity.Property(e => e.FinanceChargePreferencesMinFinanceCharge)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("FinanceChargePreferences_MinFinanceCharge");

                entity.Property(e => e.ItemsAndInventoryPreferencesEnhancedInventoryReceivingEnabled)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_EnhancedInventoryReceivingEnabled");

                entity.Property(e => e.ItemsAndInventoryPreferencesFifoeffectiveDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_FIFOEffectiveDate");

                entity.Property(e => e.ItemsAndInventoryPreferencesFifoenabled)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_FIFOEnabled");

                entity.Property(e => e.ItemsAndInventoryPreferencesIsBarcodeEnabled)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_IsBarcodeEnabled");

                entity.Property(e => e.ItemsAndInventoryPreferencesIsRsbenabled)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_IsRSBEnabled");

                entity.Property(e => e.ItemsAndInventoryPreferencesIsTrackingOnBuildAssemblyEnabled)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_IsTrackingOnBuildAssemblyEnabled");

                entity.Property(e => e.ItemsAndInventoryPreferencesIsTrackingOnInventoryAdjustmentEnabled)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_IsTrackingOnInventoryAdjustmentEnabled");

                entity.Property(e => e.ItemsAndInventoryPreferencesIsTrackingOnPurchaseTransactionsEnabled)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_IsTrackingOnPurchaseTransactionsEnabled");

                entity.Property(e => e.ItemsAndInventoryPreferencesIsTrackingOnSalesTransactionsEnabled)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_IsTrackingOnSalesTransactionsEnabled");

                entity.Property(e => e.ItemsAndInventoryPreferencesIsTrackingSerialOrLotNumber)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ItemsAndInventoryPreferences_IsTrackingSerialOrLotNumber");

                entity.Property(e => e.JobsAndEstimatesPreferencesIsPrintingItemsWithZeroAmounts)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("JobsAndEstimatesPreferences_IsPrintingItemsWithZeroAmounts");

                entity.Property(e => e.JobsAndEstimatesPreferencesIsUsingEstimates)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("JobsAndEstimatesPreferences_IsUsingEstimates");

                entity.Property(e => e.JobsAndEstimatesPreferencesIsUsingProgressInvoicing)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("JobsAndEstimatesPreferences_IsUsingProgressInvoicing");

                entity.Property(e => e.MultiCurrencyPreferencesHomeCurrencyRefFullName)
                    .HasColumnType("varchar(64)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("MultiCurrencyPreferences_HomeCurrencyRef_FullName");

                entity.Property(e => e.MultiCurrencyPreferencesHomeCurrencyRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("MultiCurrencyPreferences_HomeCurrencyRef_ListID");

                entity.Property(e => e.MultiCurrencyPreferencesIsMultiCurrencyOn)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("MultiCurrencyPreferences_IsMultiCurrencyOn");

                entity.Property(e => e.MultiLocationInventoryPreferencesIsMultiLocationInventoryAvailable)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("MultiLocationInventoryPreferences_IsMultiLocationInventoryAvailable");

                entity.Property(e => e.MultiLocationInventoryPreferencesIsMultiLocationInventoryEnabled)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("MultiLocationInventoryPreferences_IsMultiLocationInventoryEnabled");

                entity.Property(e => e.PurchasesAndVendorsPreferencesDaysBillsAreDue)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("PurchasesAndVendorsPreferences_DaysBillsAreDue");

                entity.Property(e => e.PurchasesAndVendorsPreferencesDefaultDiscountAccountRefFullName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("PurchasesAndVendorsPreferences_DefaultDiscountAccountRef_FullName");

                entity.Property(e => e.PurchasesAndVendorsPreferencesDefaultDiscountAccountRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("PurchasesAndVendorsPreferences_DefaultDiscountAccountRef_ListID");

                entity.Property(e => e.PurchasesAndVendorsPreferencesIsAutomaticallyUsingDiscounts)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("PurchasesAndVendorsPreferences_IsAutomaticallyUsingDiscounts");

                entity.Property(e => e.PurchasesAndVendorsPreferencesIsUsingInventory)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("PurchasesAndVendorsPreferences_IsUsingInventory");

                entity.Property(e => e.ReportsPreferencesAgingReportBasis)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ReportsPreferences_AgingReportBasis");

                entity.Property(e => e.ReportsPreferencesSummaryReportBasis)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("ReportsPreferences_SummaryReportBasis");

                entity.Property(e => e.SalesAndCustomersPreferencesDefaultFob)
                    .HasColumnType("varchar(13)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesAndCustomersPreferences_DefaultFOB");

                entity.Property(e => e.SalesAndCustomersPreferencesDefaultMarkup)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesAndCustomersPreferences_DefaultMarkup");

                entity.Property(e => e.SalesAndCustomersPreferencesDefaultShipMethodRefFullName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesAndCustomersPreferences_DefaultShipMethodRef_FullName");

                entity.Property(e => e.SalesAndCustomersPreferencesDefaultShipMethodRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesAndCustomersPreferences_DefaultShipMethodRef_ListID");

                entity.Property(e => e.SalesAndCustomersPreferencesIsAutoApplyingPayments)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesAndCustomersPreferences_IsAutoApplyingPayments");

                entity.Property(e => e.SalesAndCustomersPreferencesIsTrackingReimbursedExpensesAsIncome)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesAndCustomersPreferences_IsTrackingReimbursedExpensesAsIncome");

                entity.Property(e => e.SalesAndCustomersPreferencesPriceLevelsIsRoundingSalesPriceUp)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesAndCustomersPreferences_PriceLevels_IsRoundingSalesPriceUp");

                entity.Property(e => e.SalesAndCustomersPreferencesPriceLevelsIsUsingPriceLevels)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesAndCustomersPreferences_PriceLevels_IsUsingPriceLevels");

                entity.Property(e => e.SalesTaxPreferencesDefaultItemSalesTaxRefFullName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_DefaultItemSalesTaxRef_FullName");

                entity.Property(e => e.SalesTaxPreferencesDefaultItemSalesTaxRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_DefaultItemSalesTaxRef_ListID");

                entity.Property(e => e.SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefFullName)
                    .HasColumnType("varchar(3)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_DefaultNonTaxableSalesTaxCodeRef_FullName");

                entity.Property(e => e.SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_DefaultNonTaxableSalesTaxCodeRef_ListID");

                entity.Property(e => e.SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefFullName)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_DefaultTaxableSalesTaxCodeRef_FullName");

                entity.Property(e => e.SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_DefaultTaxableSalesTaxCodeRef_ListID");

                entity.Property(e => e.SalesTaxPreferencesIsUsingAmountsIncludeTax)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_IsUsingAmountsIncludeTax");

                entity.Property(e => e.SalesTaxPreferencesIsUsingCustomerTaxCode)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_IsUsingCustomerTaxCode");

                entity.Property(e => e.SalesTaxPreferencesIsUsingVendorTaxCode)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_IsUsingVendorTaxCode");

                entity.Property(e => e.SalesTaxPreferencesPaySalesTax)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("SalesTaxPreferences_PaySalesTax");

                entity.Property(e => e.TimeTrackingPreferencesFirstDayOfWeek)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("TimeTrackingPreferences_FirstDayOfWeek");

                entity.HasOne(d => d.FinanceChargePreferencesFinanceChargeAccountRefList)
                    .WithMany(p => p.PreferenceFinanceChargePreferencesFinanceChargeAccountRefLists)
                    .HasForeignKey(d => d.FinanceChargePreferencesFinanceChargeAccountRefListId)
                    .HasConstraintName("FK_Preferences_FinanceChargePreferences_FinanceChargeAccountRef_ListID_REF_Accounts_ID");

                entity.HasOne(d => d.MultiCurrencyPreferencesHomeCurrencyRefList)
                    .WithMany(p => p.Preferences)
                    .HasForeignKey(d => d.MultiCurrencyPreferencesHomeCurrencyRefListId)
                    .HasConstraintName("FK_Preferences_MultiCurrencyPreferences_HomeCurrencyRef_ListID_REF_Currency_ID");

                entity.HasOne(d => d.PurchasesAndVendorsPreferencesDefaultDiscountAccountRefList)
                    .WithMany(p => p.PreferencePurchasesAndVendorsPreferencesDefaultDiscountAccountRefLists)
                    .HasForeignKey(d => d.PurchasesAndVendorsPreferencesDefaultDiscountAccountRefListId)
                    .HasConstraintName("FK_Preferences_PurchasesAndVendorsPreferences_DefaultDiscountAccountRef_ListID_REF_Accounts_ID");

                entity.HasOne(d => d.SalesAndCustomersPreferencesDefaultShipMethodRefList)
                    .WithMany(p => p.Preferences)
                    .HasForeignKey(d => d.SalesAndCustomersPreferencesDefaultShipMethodRefListId)
                    .HasConstraintName("FK_Preferences_SalesAndCustomersPreferences_DefaultShipMethodRef_ListID_REF_ShippingMethods_ID");

                entity.HasOne(d => d.SalesTaxPreferencesDefaultItemSalesTaxRefList)
                    .WithMany(p => p.Preferences)
                    .HasForeignKey(d => d.SalesTaxPreferencesDefaultItemSalesTaxRefListId)
                    .HasConstraintName("FK_Preferences_SalesTaxPreferences_DefaultItemSalesTaxRef_ListID_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefList)
                    .WithMany(p => p.PreferenceSalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefLists)
                    .HasForeignKey(d => d.SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefListId)
                    .HasConstraintName("FK_Preferences_SalesTaxPreferences_DefaultNonTaxableSalesTaxCodeRef_ListID_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefList)
                    .WithMany(p => p.PreferenceSalesTaxPreferencesDefaultTaxableSalesTaxCodeRefLists)
                    .HasForeignKey(d => d.SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefListId)
                    .HasConstraintName("FK_Preferences_SalesTaxPreferences_DefaultTaxableSalesTaxCodeRef_ListID_REF_SalesTaxCodes_ID");
            });

            modelBuilder.Entity<PriceLevel>(entity =>
            {
                entity.ToTable("PriceLevels", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_PRICELEVELS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.PriceLevelFixedPercentage).HasColumnType("float");

                entity.Property(e => e.PriceLevelPerItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.PriceLevelPerItemRetCurrencyRefFullName)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("PriceLevelPerItemRet_CurrencyRef_FullName");

                entity.Property(e => e.PriceLevelPerItemRetCurrencyRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PriceLevelPerItemRet_CurrencyRef_ListID");

                entity.Property(e => e.PriceLevelType)
                    .HasColumnType("varchar(15)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.PriceLevelPerItemRetCurrencyRefList)
                    .WithMany(p => p.PriceLevels)
                    .HasForeignKey(d => d.PriceLevelPerItemRetCurrencyRefListId)
                    .HasConstraintName("FK_PriceLevels_PriceLevelPerItemRet_CurrencyRef_ListID_REF_Currency_ID");
            });

            modelBuilder.Entity<PriceLevelPerItem>(entity =>
            {
                entity.ToTable("PriceLevelPerItem", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_PRICELEVELPERITEM_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.PriceLevelId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PriceLevelID");

                entity.Property(e => e.PriceLevelPerItemRetCurrencyRefFullName)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("PriceLevelPerItemRet_CurrencyRef_FullName");

                entity.Property(e => e.PriceLevelPerItemRetCurrencyRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PriceLevelPerItemRet_CurrencyRef_ListID");

                entity.Property(e => e.PriceLevelPerItemRetCustomPrice)
                    .HasColumnType("decimal(28, 6)")
                    .HasColumnName("PriceLevelPerItemRet_CustomPrice");

                entity.Property(e => e.PriceLevelPerItemRetCustomPricePercent)
                    .HasColumnType("float")
                    .HasColumnName("PriceLevelPerItemRet_CustomPricePercent");

                entity.Property(e => e.PriceLevelPerItemRetItemRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PriceLevelPerItemRet_ItemRef_FullName");

                entity.Property(e => e.PriceLevelPerItemRetItemRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PriceLevelPerItemRet_ItemRef_ListID");

                entity.Property(e => e.PriceLevelType)
                    .HasColumnType("varchar(15)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.PriceLevel)
                    .WithMany(p => p.PriceLevelPerItems)
                    .HasForeignKey(d => d.PriceLevelId)
                    .HasConstraintName("FK_PriceLevelPerItem_PriceLevelID_REF_PriceLevels_ID");

                entity.HasOne(d => d.PriceLevelPerItemRetCurrencyRefList)
                    .WithMany(p => p.PriceLevelPerItems)
                    .HasForeignKey(d => d.PriceLevelPerItemRetCurrencyRefListId)
                    .HasConstraintName("FK_PriceLevelPerItem_PriceLevelPerItemRet_CurrencyRef_ListID_REF_Currency_ID");

                entity.HasOne(d => d.PriceLevelPerItemRetItemRefList)
                    .WithMany(p => p.PriceLevelPerItems)
                    .HasForeignKey(d => d.PriceLevelPerItemRetItemRefListId)
                    .HasConstraintName("FK_PriceLevelPerItem_PriceLevelPerItemRet_ItemRef_ListID_REF_Items_ID");
            });

            modelBuilder.Entity<ProfitAndLossDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProfitAndLossDetail", "QuickBooks");

                entity.Property(e => e.Amount)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Balance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Class)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Clr)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Label)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.RowType)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Split)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<ProfitAndLossStandard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProfitAndLossStandard", "QuickBooks");

                entity.Property(e => e.Amount)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Label)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.RowType)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.ToTable("PurchaseOrders", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_PURCHASEORDERS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpectedDate).HasColumnType("date");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsFullyReceived)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsManuallyClosed).HasColumnType("varchar(10)");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Other1).HasColumnType("varchar(25)");

                entity.Property(e => e.Other2).HasColumnType("varchar(29)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.SalesTaxCodeName).HasColumnType("varchar(3)");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipToEntityId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipToEntityName).HasColumnType("varchar(1000)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorCity).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.VendorLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.VendorLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.VendorLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.VendorLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.VendorMessage).HasColumnType("varchar(99)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorNote).HasColumnType("varchar(41)");

                entity.Property(e => e.VendorPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.VendorState).HasColumnType("varchar(255)");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_PurchaseOrders_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_PurchaseOrders_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.SalesTaxCode)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.SalesTaxCodeId)
                    .HasConstraintName("FK_PurchaseOrders_SalesTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_PurchaseOrders_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_PurchaseOrders_TemplateId_REF_Templates_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_PurchaseOrders_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<PurchaseOrderLineItem>(entity =>
            {
                entity.ToTable("PurchaseOrderLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_PURCHASEORDERLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.ExpectedDate).HasColumnType("date");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsFullyReceived)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsManuallyClosed).HasColumnType("varchar(10)");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemIsManuallyClosed).HasColumnType("varchar(10)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemOther1).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemOther2).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemPartNumber).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemRate).HasColumnType("float");

                entity.Property(e => e.ItemReceivedQuantity).HasColumnType("float");

                entity.Property(e => e.ItemServiceDate).HasColumnType("date");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Other1).HasColumnType("varchar(25)");

                entity.Property(e => e.Other2).HasColumnType("varchar(29)");

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("PurchaseOrderID");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.SalesTaxCodeName).HasColumnType("varchar(3)");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipToEntityId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipToEntityName).HasColumnType("varchar(1000)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorCity).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.VendorLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.VendorLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.VendorLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.VendorLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.VendorMessage).HasColumnType("varchar(99)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorNote).HasColumnType("varchar(41)");

                entity.Property(e => e.VendorPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.VendorState).HasColumnType("varchar(255)");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.PurchaseOrderLineItemClassNavigations)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PurchaseOrderLineItems)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.PurchaseOrderLineItemItemClassNavigations)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemCustomerNavigation)
                    .WithMany(p => p.PurchaseOrderLineItems)
                    .HasForeignKey(d => d.ItemCustomerId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_ItemCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.PurchaseOrderLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PurchaseOrderLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderLineItems)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_PurchaseOrderID_REF_PurchaseOrders_ID");

                entity.HasOne(d => d.SalesTaxCode)
                    .WithMany(p => p.PurchaseOrderLineItems)
                    .HasForeignKey(d => d.SalesTaxCodeId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_SalesTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.PurchaseOrderLineItems)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.PurchaseOrderLineItems)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_TemplateId_REF_Templates_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PurchaseOrderLineItems)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_PurchaseOrderLineItems_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<PurchaseOrderLinkedTransaction>(entity =>
            {
                entity.ToTable("PurchaseOrderLinkedTransactions", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_PURCHASEORDERLINKEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionLinkType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorMessage)
                    .HasColumnType("varchar(99)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderLinkedTransactions)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_PurchaseOrderLinkedTransactions_PurchaseOrderId_REF_PurchaseOrders_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PurchaseOrderLinkedTransactions)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_PurchaseOrderLinkedTransactions_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<ReceivePayment>(entity =>
            {
                entity.ToTable("ReceivePayments", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_RECEIVEPAYMENTS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsReceivableId).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsReceivableName).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepositToAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.DepositToAccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PaymentMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.PaymentMethodName).HasColumnType("varchar(100)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmountInHomeCurrency).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UnusedPayment)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountsReceivable)
                    .WithMany(p => p.ReceivePaymentAccountsReceivables)
                    .HasForeignKey(d => d.AccountsReceivableId)
                    .HasConstraintName("FK_ReceivePayments_AccountsReceivableId_REF_Accounts_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ReceivePayments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ReceivePayments_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.DepositToAccount)
                    .WithMany(p => p.ReceivePaymentDepositToAccounts)
                    .HasForeignKey(d => d.DepositToAccountId)
                    .HasConstraintName("FK_ReceivePayments_DepositToAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.ReceivePayments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_ReceivePayments_PaymentMethodId_REF_PaymentMethods_ID");
            });

            modelBuilder.Entity<ReceivePaymentToDeposit>(entity =>
            {
                entity.ToTable("ReceivePaymentToDeposit", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_RECEIVEPAYMENTTODEPOSIT_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AmountInHomeCurrency)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CurrencyName)
                    .HasColumnType("varchar(64)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomerRefFullName)
                    .HasColumnType("varchar(209)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("CustomerRef_FullName");

                entity.Property(e => e.CustomerRefListId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("CustomerRef_ListID");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.RefNumber)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnLineId)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("TxnLineID");

                entity.Property(e => e.TxnType)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.ReceivePaymentToDeposits)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_ReceivePaymentToDeposit_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.CustomerRefList)
                    .WithMany(p => p.ReceivePaymentToDeposits)
                    .HasForeignKey(d => d.CustomerRefListId)
                    .HasConstraintName("FK_ReceivePaymentToDeposit_CustomerRef_ListID_REF_Customers_ID");
            });

            modelBuilder.Entity<ReceivePaymentsAppliedTo>(entity =>
            {
                entity.ToTable("ReceivePaymentsAppliedTo", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_RECEIVEPAYMENTSAPPLIEDTO_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsReceivableId).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsReceivableName).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToBalanceRemaining)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToCreditAppliedAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToCreditMemoId).HasColumnType("varchar(255)");

                entity.Property(e => e.AppliedToDiscountAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.AppliedToDiscountAccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.AppliedToDiscountAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToPaymentAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.AppliedToRefId).HasColumnType("varchar(255)");

                entity.Property(e => e.AppliedToReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToTxnDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AppliedToTxnType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AutoApply).HasColumnType("varchar(20)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepositToAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.DepositToAccountName).HasColumnType("varchar(255)");

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.PaymentMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.PaymentMethodName).HasColumnType("varchar(100)");

                entity.Property(e => e.ReceivePaymentId).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmountInHomeCurrency).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UnusedPayment)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.AccountsReceivable)
                    .WithMany(p => p.ReceivePaymentsAppliedToAccountsReceivables)
                    .HasForeignKey(d => d.AccountsReceivableId)
                    .HasConstraintName("FK_ReceivePaymentsAppliedTo_AccountsReceivableId_REF_Accounts_ID");

                entity.HasOne(d => d.AppliedToCreditMemo)
                    .WithMany(p => p.ReceivePaymentsAppliedTos)
                    .HasForeignKey(d => d.AppliedToCreditMemoId)
                    .HasConstraintName("FK_ReceivePaymentsAppliedTo_AppliedToCreditMemoId_REF_CreditMemos_ID");

                entity.HasOne(d => d.AppliedToDiscountAccount)
                    .WithMany(p => p.ReceivePaymentsAppliedToAppliedToDiscountAccounts)
                    .HasForeignKey(d => d.AppliedToDiscountAccountId)
                    .HasConstraintName("FK_ReceivePaymentsAppliedTo_AppliedToDiscountAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ReceivePaymentsAppliedTos)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ReceivePaymentsAppliedTo_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.DepositToAccount)
                    .WithMany(p => p.ReceivePaymentsAppliedToDepositToAccounts)
                    .HasForeignKey(d => d.DepositToAccountId)
                    .HasConstraintName("FK_ReceivePaymentsAppliedTo_DepositToAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.ReceivePaymentsAppliedTos)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_ReceivePaymentsAppliedTo_PaymentMethodId_REF_PaymentMethods_ID");

                entity.HasOne(d => d.ReceivePayment)
                    .WithMany(p => p.ReceivePaymentsAppliedTos)
                    .HasForeignKey(d => d.ReceivePaymentId)
                    .HasConstraintName("FK_ReceivePaymentsAppliedTo_ReceivePaymentId_REF_ReceivePayments_ID");
            });

            modelBuilder.Entity<SalesOrder>(entity =>
            {
                entity.ToTable("SalesOrders", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_SALESORDERS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.CustomerTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsFullyInvoiced)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsManuallyClosed).HasColumnType("varchar(10)");

                entity.Property(e => e.IsPrinted)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.Other).HasColumnType("varchar(29)");

                entity.Property(e => e.Ponumber)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("PONumber");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipDate).HasColumnType("date");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Tax)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.TotalAmountInHomeCurrency).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.TransactionAggregate)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_SalesOrders_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_SalesOrders_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SalesOrders_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerTaxCodeNavigation)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.CustomerTaxCodeId)
                    .HasConstraintName("FK_SalesOrders_CustomerTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_SalesOrders_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_SalesOrders_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_SalesOrders_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_SalesOrders_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.SalesOrders)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_SalesOrders_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<SalesOrderLineItem>(entity =>
            {
                entity.ToTable("SalesOrderLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_SALESORDERLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.CustomerTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsFullyInvoiced)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsManuallyClosed).HasColumnType("varchar(10)");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInvoicedAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemIsGetPrintItemsInGroup).HasColumnType("varchar(1000)");

                entity.Property(e => e.ItemIsManuallyClosed).HasColumnType("varchar(10)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLotNumber).HasColumnType("varchar(40)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemOther1).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemOther2).HasColumnType("varchar(29)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemRate).HasColumnType("float");

                entity.Property(e => e.ItemRatePercent).HasColumnType("float");

                entity.Property(e => e.ItemSerialNumber).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemUomsetFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetFullName");

                entity.Property(e => e.ItemUomsetListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetListID");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.Ponumber)
                    .HasColumnType("varchar(41)")
                    .HasColumnName("PONumber");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesOrderId).HasColumnType("varchar(255)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipDate).HasColumnType("date");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Tax)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.TotalAmountInHomeCurrency).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.SalesOrderLineItemClassNavigations)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_SalesOrderLineItems_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_SalesOrderLineItems_CurrencyId_REF_Currency_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SalesOrderLineItems_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerTaxCodeNavigation)
                    .WithMany(p => p.SalesOrderLineItemCustomerTaxCodeNavigations)
                    .HasForeignKey(d => d.CustomerTaxCodeId)
                    .HasConstraintName("FK_SalesOrderLineItems_CustomerTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.SalesOrderLineItemItemClassNavigations)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_SalesOrderLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.SalesOrderLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_SalesOrderLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SalesOrderLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_SalesOrderLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySite)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteId)
                    .HasConstraintName("FK_SalesOrderLineItems_ItemInventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.SalesOrderLineItemItemTaxCodeNavigations)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_SalesOrderLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.ItemUomsetList)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.ItemUomsetListId)
                    .HasConstraintName("FK_SalesOrderLineItems_ItemUOMSetListID_REF_UnitOfMeasure_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_SalesOrderLineItems_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_SalesOrderLineItems_SalesOrderId_REF_SalesOrders_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_SalesOrderLineItems_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_SalesOrderLineItems_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_SalesOrderLineItems_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.SalesOrderLineItems)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_SalesOrderLineItems_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<SalesOrderLinkedTransaction>(entity =>
            {
                entity.ToTable("SalesOrderLinkedTransactions", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_SALESORDERLINKEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomerName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SalesOrderId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionLinkType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOrderLinkedTransactions)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SalesOrderLinkedTransactions_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderLinkedTransactions)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_SalesOrderLinkedTransactions_SalesOrderId_REF_SalesOrders_ID");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.SalesOrderLinkedTransactions)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_SalesOrderLinkedTransactions_TransactionId_REF_Invoices_ID");
            });

            modelBuilder.Entity<SalesReceipt>(entity =>
            {
                entity.ToTable("SalesReceipts", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_SALESRECEIPTS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.CheckNumber).HasColumnType("varchar(25)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerTaxCode)
                    .HasColumnType("varchar(3)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomerTaxCodeId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepositAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.DepositAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsPending).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.PaymentMethod).HasColumnType("varchar(100)");

                entity.Property(e => e.PaymentMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipDate).HasColumnType("date");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Tax)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_SalesReceipts_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SalesReceipts_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerTaxCodeNavigation)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.CustomerTaxCodeId)
                    .HasConstraintName("FK_SalesReceipts_CustomerTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.DepositAccountNavigation)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.DepositAccountId)
                    .HasConstraintName("FK_SalesReceipts_DepositAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_SalesReceipts_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.PaymentMethodNavigation)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_SalesReceipts_PaymentMethodId_REF_PaymentMethods_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_SalesReceipts_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_SalesReceipts_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_SalesReceipts_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.SalesReceipts)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_SalesReceipts_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<SalesReceiptLineItem>(entity =>
            {
                entity.ToTable("SalesReceiptLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_SALESRECEIPTLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BillingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BillingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.BillingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.BillingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.BillingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.BillingState).HasColumnType("varchar(255)");

                entity.Property(e => e.CheckNumber).HasColumnType("varchar(25)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerTaxCode)
                    .HasColumnType("varchar(3)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomerTaxCodeId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DepositAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.DepositAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Fob)
                    .HasColumnType("varchar(13)")
                    .HasColumnName("FOB");

                entity.Property(e => e.IsPending).HasColumnType("bool");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.IsToBeEmailed).HasColumnType("bool");

                entity.Property(e => e.IsToBePrinted).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemIsGetPrintItemsInGroup).HasColumnType("varchar(1000)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLotNumber).HasColumnType("varchar(40)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemRate).HasColumnType("float");

                entity.Property(e => e.ItemRatePercent).HasColumnType("float");

                entity.Property(e => e.ItemSerialNumber).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemUomsetFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetFullName");

                entity.Property(e => e.ItemUomsetListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemUOMSetListID");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.Message).HasColumnType("varchar(101)");

                entity.Property(e => e.MessageId).HasColumnType("varchar(255)");

                entity.Property(e => e.PaymentMethod).HasColumnType("varchar(100)");

                entity.Property(e => e.PaymentMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.SalesReceiptId).HasColumnType("varchar(255)");

                entity.Property(e => e.SalesRep).HasColumnType("varchar(5)");

                entity.Property(e => e.SalesRepId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipDate).HasColumnType("date");

                entity.Property(e => e.ShipMethod).HasColumnType("varchar(255)");

                entity.Property(e => e.ShipMethodId).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Tax)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaxItem).HasColumnType("varchar(100)");

                entity.Property(e => e.TaxItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxPercent)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Template).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.SalesReceiptLineItemClassNavigations)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_SalesReceiptLineItems_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_SalesReceiptLineItems_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.CustomerTaxCodeNavigation)
                    .WithMany(p => p.SalesReceiptLineItemCustomerTaxCodeNavigations)
                    .HasForeignKey(d => d.CustomerTaxCodeId)
                    .HasConstraintName("FK_SalesReceiptLineItems_CustomerTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.DepositAccountNavigation)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.DepositAccountId)
                    .HasConstraintName("FK_SalesReceiptLineItems_DepositAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.SalesReceiptLineItemItemClassNavigations)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_SalesReceiptLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.SalesReceiptLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_SalesReceiptLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SalesReceiptLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_SalesReceiptLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySite)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteId)
                    .HasConstraintName("FK_SalesReceiptLineItems_ItemInventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.SalesReceiptLineItemItemTaxCodeNavigations)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_SalesReceiptLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.ItemUomsetList)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.ItemUomsetListId)
                    .HasConstraintName("FK_SalesReceiptLineItems_ItemUOMSetListID_REF_UnitOfMeasure_ID");

                entity.HasOne(d => d.MessageNavigation)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_SalesReceiptLineItems_MessageId_REF_CustomerMessages_ID");

                entity.HasOne(d => d.PaymentMethodNavigation)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_SalesReceiptLineItems_PaymentMethodId_REF_PaymentMethods_ID");

                entity.HasOne(d => d.SalesReceipt)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.SalesReceiptId)
                    .HasConstraintName("FK_SalesReceiptLineItems_SalesReceiptId_REF_SalesReceipts_ID");

                entity.HasOne(d => d.SalesRepNavigation)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.SalesRepId)
                    .HasConstraintName("FK_SalesReceiptLineItems_SalesRepId_REF_SalesReps_ID");

                entity.HasOne(d => d.ShipMethodNavigation)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.ShipMethodId)
                    .HasConstraintName("FK_SalesReceiptLineItems_ShipMethodId_REF_ShippingMethods_ID");

                entity.HasOne(d => d.TaxItemNavigation)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.TaxItemId)
                    .HasConstraintName("FK_SalesReceiptLineItems_TaxItemId_REF_SalesTaxItems_ID");

                entity.HasOne(d => d.TemplateNavigation)
                    .WithMany(p => p.SalesReceiptLineItems)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_SalesReceiptLineItems_TemplateId_REF_Templates_ID");
            });

            modelBuilder.Entity<SalesRep>(entity =>
            {
                entity.ToTable("SalesReps", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_SALESREPS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Initial).HasColumnType("varchar(5)");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.SalesRepEntityRefFullName)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("SalesRepEntityRef_FullName");

                entity.Property(e => e.SalesRepEntityRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("SalesRepEntityRef_ListId");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<SalesTaxCode>(entity =>
            {
                entity.ToTable("SalesTaxCodes", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_SALESTAXCODES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("varchar(31)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.IsTaxable).HasColumnType("bool");

                entity.Property(e => e.ItemPurchaseTaxRefFullName)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("ItemPurchaseTaxRef_FullName");

                entity.Property(e => e.ItemPurchaseTaxRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemPurchaseTaxRef_ListId");

                entity.Property(e => e.ItemSalesTaxRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemSalesTaxRef_FullName");

                entity.Property(e => e.ItemSalesTaxRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemSalesTaxRef_ListId");

                entity.Property(e => e.Name).HasColumnType("varchar(3)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ItemSalesTaxRefList)
                    .WithMany(p => p.SalesTaxCodes)
                    .HasForeignKey(d => d.ItemSalesTaxRefListId)
                    .HasConstraintName("FK_SalesTaxCodes_ItemSalesTaxRef_ListId_REF_SalesTaxItems_ID");
            });

            modelBuilder.Entity<SalesTaxItem>(entity =>
            {
                entity.ToTable("SalesTaxItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_SALESTAXITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ClassRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClassRef_FullName");

                entity.Property(e => e.ClassRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClassRef_ListID");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.ItemDesc).HasColumnType("varchar(4096)");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.TaxRate).HasColumnType("float");

                entity.Property(e => e.TaxVendorRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TaxVendorRef_FullName");

                entity.Property(e => e.TaxVendorRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TaxVendorRef_ListID");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ClassRefList)
                    .WithMany(p => p.SalesTaxItems)
                    .HasForeignKey(d => d.ClassRefListId)
                    .HasConstraintName("FK_SalesTaxItems_ClassRef_ListID_REF_Class_ID");

                entity.HasOne(d => d.TaxVendorRefList)
                    .WithMany(p => p.SalesTaxItems)
                    .HasForeignKey(d => d.TaxVendorRefListId)
                    .HasConstraintName("FK_SalesTaxItems_TaxVendorRef_ListID_REF_Vendors_ID");
            });

            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.ToTable("ShippingMethods", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_SHIPPINGMETHODS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(15)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<StandardTerm>(entity =>
            {
                entity.ToTable("StandardTerms", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_STANDARDTERMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.DiscountPct).HasColumnType("float");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.StdDiscountDays).HasColumnType("int");

                entity.Property(e => e.StdDueDays).HasColumnType("int");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<StatementCharge>(entity =>
            {
                entity.ToTable("StatementCharges", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_STATEMENTCHARGES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsReceivable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsReceivableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.Balance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BilledDate).HasColumnType("date");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description).HasColumnType("varchar(2000)");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsPaid)
                    .HasColumnType("bool")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.OverrideUnitOfMeasure).HasColumnType("varchar(100)");

                entity.Property(e => e.OverrideUnitOfMeasureId).HasColumnType("varchar(255)");

                entity.Property(e => e.Quantity).HasColumnType("float");

                entity.Property(e => e.Rate).HasColumnType("float");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(2000)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UnitOfMeasure).HasColumnType("varchar(31)");

                entity.HasOne(d => d.AccountsReceivableNavigation)
                    .WithMany(p => p.StatementCharges)
                    .HasForeignKey(d => d.AccountsReceivableId)
                    .HasConstraintName("FK_StatementCharges_AccountsReceivableId_REF_Accounts_ID");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.StatementCharges)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_StatementCharges_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.StatementCharges)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_StatementCharges_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StatementCharges)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_StatementCharges_ItemId_REF_Items_ID");

                entity.HasOne(d => d.OverrideUnitOfMeasureNavigation)
                    .WithMany(p => p.StatementCharges)
                    .HasForeignKey(d => d.OverrideUnitOfMeasureId)
                    .HasConstraintName("FK_StatementCharges_OverrideUnitOfMeasureId_REF_UnitOfMeasure_ID");
            });

            modelBuilder.Entity<StatementChargeLinkedTransaction>(entity =>
            {
                entity.ToTable("StatementChargeLinkedTransactions", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_STATEMENTCHARGELINKEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomerName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.StatementChargeId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionLinkType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.StatementChargeLinkedTransactions)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_StatementChargeLinkedTransactions_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.StatementCharge)
                    .WithMany(p => p.StatementChargeLinkedTransactions)
                    .HasForeignKey(d => d.StatementChargeId)
                    .HasConstraintName("FK_StatementChargeLinkedTransactions_StatementChargeId_REF_StatementCharges_ID");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("Templates", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_TEMPLATES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.TemplateType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TimeTracking>(entity =>
            {
                entity.ToTable("TimeTracking", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_TIMETRACKING_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BillableStatus).HasColumnType("varchar(15)");

                entity.Property(e => e.Class).HasColumnType("varchar(255)");

                entity.Property(e => e.ClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.CustomerName).HasColumnType("varchar(255)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Duration).HasColumnType("varchar(50)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EmployeeId).HasColumnType("varchar(255)");

                entity.Property(e => e.EmployeeName).HasColumnType("varchar(255)");

                entity.Property(e => e.Notes).HasColumnType("varchar(5000)");

                entity.Property(e => e.PayrollWageItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.PayrollWageItemName).HasColumnType("varchar(100)");

                entity.Property(e => e.ServiceItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ServiceItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.TimeTrackings)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_TimeTracking_ClassId_REF_Class_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TimeTrackings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_TimeTracking_CustomerId_REF_Customers_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TimeTrackings)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_TimeTracking_EmployeeId_REF_Employees_ID");

                entity.HasOne(d => d.PayrollWageItem)
                    .WithMany(p => p.TimeTrackings)
                    .HasForeignKey(d => d.PayrollWageItemId)
                    .HasConstraintName("FK_TimeTracking_PayrollWageItemId_REF_PayrollWageItems_ID");

                entity.HasOne(d => d.ServiceItem)
                    .WithMany(p => p.TimeTrackings)
                    .HasForeignKey(d => d.ServiceItemId)
                    .HasConstraintName("FK_TimeTracking_ServiceItemId_REF_Items_ID");
            });

            modelBuilder.Entity<ToDo>(entity =>
            {
                entity.ToTable("ToDo", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_TODO_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.IsDone).HasColumnType("bool");

                entity.Property(e => e.Notes).HasColumnType("varchar(2000)");

                entity.Property(e => e.Priority).HasColumnType("varchar(2000)");

                entity.Property(e => e.ReminderDate).HasColumnType("datetime");

                entity.Property(e => e.ReminderTime).HasColumnType("varchar(2000)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type).HasColumnType("varchar(2000)");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TxnLineId })
                    .HasName("Transactions_PRIMARYKEY");

                entity.ToTable("Transactions", "QuickBooks");

                entity.HasIndex(e => new { e.Id, e.TxnLineId }, "CDATA_QUICKBOOKS_TRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TxnLineId)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccountId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AccountName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AmountInHomeCurrency)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Entity)
                    .HasColumnType("varchar(1000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EntityId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("float");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Transactions_AccountId_REF_Accounts_ID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Transactions_CurrencyId_REF_Currency_ID");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.ToTable("Transfers", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_TRANSFERS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ClassRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClassRef_FullName");

                entity.Property(e => e.ClassRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClassRef_ListID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.FromAccountBalance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ToAccountBalance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransferFromAccountRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TransferFromAccountRef_FullName");

                entity.Property(e => e.TransferFromAccountRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TransferFromAccountRef_ListID");

                entity.Property(e => e.TransferToAccountRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TransferToAccountRef_FullName");

                entity.Property(e => e.TransferToAccountRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TransferToAccountRef_ListID");

                entity.Property(e => e.TxnDate).HasColumnType("date");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ClassRefList)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.ClassRefListId)
                    .HasConstraintName("FK_Transfers_ClassRef_ListID_REF_Class_ID");

                entity.HasOne(d => d.TransferFromAccountRefList)
                    .WithMany(p => p.TransferTransferFromAccountRefLists)
                    .HasForeignKey(d => d.TransferFromAccountRefListId)
                    .HasConstraintName("FK_Transfers_TransferFromAccountRef_ListID_REF_Accounts_ID");

                entity.HasOne(d => d.TransferToAccountRefList)
                    .WithMany(p => p.TransferTransferToAccountRefLists)
                    .HasForeignKey(d => d.TransferToAccountRefListId)
                    .HasConstraintName("FK_Transfers_TransferToAccountRef_ListID_REF_Accounts_ID");
            });

            modelBuilder.Entity<TransferInventory>(entity =>
            {
                entity.ToTable("TransferInventory", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_TRANSFERINVENTORY_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExternalGuid)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("ExternalGUID");

                entity.Property(e => e.FromInventorySiteRefFullName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("FromInventorySiteRef_FullName");

                entity.Property(e => e.FromInventorySiteRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FromInventorySiteRef_ListID");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.RefNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ToInventorySiteRefFullName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("ToInventorySiteRef_FullName");

                entity.Property(e => e.ToInventorySiteRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ToInventorySiteRef_ListID");

                entity.Property(e => e.TransferInventoryLineAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.TxnDate).HasColumnType("date");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.FromInventorySiteRefList)
                    .WithMany(p => p.TransferInventoryFromInventorySiteRefLists)
                    .HasForeignKey(d => d.FromInventorySiteRefListId)
                    .HasConstraintName("FK_TransferInventory_FromInventorySiteRef_ListID_REF_InventorySites_ID");

                entity.HasOne(d => d.ToInventorySiteRefList)
                    .WithMany(p => p.TransferInventoryToInventorySiteRefLists)
                    .HasForeignKey(d => d.ToInventorySiteRefListId)
                    .HasConstraintName("FK_TransferInventory_ToInventorySiteRef_ListID_REF_InventorySites_ID");
            });

            modelBuilder.Entity<TransferInventoryLineItem>(entity =>
            {
                entity.ToTable("TransferInventoryLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_TRANSFERINVENTORYLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExternalGuid)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("ExternalGUID");

                entity.Property(e => e.FromInventorySiteRefFullName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("FromInventorySiteRef_FullName");

                entity.Property(e => e.FromInventorySiteRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("FromInventorySiteRef_ListID");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.RefNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ToInventorySiteRefFullName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("ToInventorySiteRef_FullName");

                entity.Property(e => e.ToInventorySiteRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ToInventorySiteRef_ListID");

                entity.Property(e => e.TransferInventoryId).HasColumnType("varchar(255)");

                entity.Property(e => e.TransferInventoryLineRetFromInventorySiteLocationRefFullName)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("TransferInventoryLineRet_FromInventorySiteLocationRef_FullName");

                entity.Property(e => e.TransferInventoryLineRetFromInventorySiteLocationRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TransferInventoryLineRet_FromInventorySiteLocationRef_ListID");

                entity.Property(e => e.TransferInventoryLineRetItemRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TransferInventoryLineRet_ItemRef_FullName");

                entity.Property(e => e.TransferInventoryLineRetItemRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TransferInventoryLineRet_ItemRef_ListID");

                entity.Property(e => e.TransferInventoryLineRetLotNumber)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("TransferInventoryLineRet_LotNumber");

                entity.Property(e => e.TransferInventoryLineRetQuantityToTransfer)
                    .HasColumnType("float")
                    .HasColumnName("TransferInventoryLineRet_QuantityToTransfer");

                entity.Property(e => e.TransferInventoryLineRetQuantityTransferred)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("TransferInventoryLineRet_QuantityTransferred");

                entity.Property(e => e.TransferInventoryLineRetSerialNumber)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("TransferInventoryLineRet_SerialNumber");

                entity.Property(e => e.TransferInventoryLineRetToInventorySiteLocationRefFullName)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("TransferInventoryLineRet_ToInventorySiteLocationRef_FullName");

                entity.Property(e => e.TransferInventoryLineRetToInventorySiteLocationRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("TransferInventoryLineRet_ToInventorySiteLocationRef_ListID");

                entity.Property(e => e.TransferInventoryLineRetTxnLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("TransferInventoryLineRet_TxnLineID");

                entity.Property(e => e.TxnDate).HasColumnType("date");

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.FromInventorySiteRefList)
                    .WithMany(p => p.TransferInventoryLineItemFromInventorySiteRefLists)
                    .HasForeignKey(d => d.FromInventorySiteRefListId)
                    .HasConstraintName("FK_TransferInventoryLineItems_FromInventorySiteRef_ListID_REF_InventorySites_ID");

                entity.HasOne(d => d.ToInventorySiteRefList)
                    .WithMany(p => p.TransferInventoryLineItemToInventorySiteRefLists)
                    .HasForeignKey(d => d.ToInventorySiteRefListId)
                    .HasConstraintName("FK_TransferInventoryLineItems_ToInventorySiteRef_ListID_REF_InventorySites_ID");

                entity.HasOne(d => d.TransferInventoryLineRetItemRefList)
                    .WithMany(p => p.TransferInventoryLineItems)
                    .HasForeignKey(d => d.TransferInventoryLineRetItemRefListId)
                    .HasConstraintName("FK_TransferInventoryLineItems_TransferInventoryLineRet_ItemRef_ListID_REF_Items_ID");
            });

            modelBuilder.Entity<UnitOfMeasure>(entity =>
            {
                entity.ToTable("UnitOfMeasure", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_UNITOFMEASURE_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BaseUnitAbbreviation)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("BaseUnit_Abbreviation");

                entity.Property(e => e.BaseUnitName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("BaseUnit_Name");

                entity.Property(e => e.DefaultUnitAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.RelatedUnitAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UnitOfMeasureType).HasColumnType("varchar(1000)");
            });

            modelBuilder.Entity<UnitOfMeasureDefaultUnit>(entity =>
            {
                entity.ToTable("UnitOfMeasureDefaultUnits", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_UNITOFMEASUREDEFAULTUNITS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BaseUnitAbbreviation)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("BaseUnit_Abbreviation");

                entity.Property(e => e.BaseUnitName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("BaseUnit_Name");

                entity.Property(e => e.DefaultUnitUnit)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("DefaultUnit_Unit");

                entity.Property(e => e.DefaultUnitUnitUsedFor)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("DefaultUnit_UnitUsedFor");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UnitOfMeasureSetId).HasColumnType("varchar(255)");

                entity.Property(e => e.UnitOfMeasureType).HasColumnType("varchar(1000)");

                entity.HasOne(d => d.UnitOfMeasureSet)
                    .WithMany(p => p.UnitOfMeasureDefaultUnits)
                    .HasForeignKey(d => d.UnitOfMeasureSetId)
                    .HasConstraintName("FK_UnitOfMeasureDefaultUnits_UnitOfMeasureSetId_REF_UnitOfMeasure_ID");
            });

            modelBuilder.Entity<UnitOfMeasureRelatedUnit>(entity =>
            {
                entity.ToTable("UnitOfMeasureRelatedUnits", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_UNITOFMEASURERELATEDUNITS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BaseUnitAbbreviation)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("BaseUnit_Abbreviation");

                entity.Property(e => e.BaseUnitName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("BaseUnit_Name");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.RelatedUnitAbbreviation)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("RelatedUnit_Abbreviation");

                entity.Property(e => e.RelatedUnitConversionRatio)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("RelatedUnit_ConversionRatio");

                entity.Property(e => e.RelatedUnitName)
                    .HasColumnType("varchar(31)")
                    .HasColumnName("RelatedUnit_Name");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UnitOfMeasureSetId).HasColumnType("varchar(255)");

                entity.Property(e => e.UnitOfMeasureType).HasColumnType("varchar(1000)");

                entity.HasOne(d => d.UnitOfMeasureSet)
                    .WithMany(p => p.UnitOfMeasureRelatedUnits)
                    .HasForeignKey(d => d.UnitOfMeasureSetId)
                    .HasConstraintName("FK_UnitOfMeasureRelatedUnits_UnitOfMeasureSetId_REF_UnitOfMeasure_ID");
            });

            modelBuilder.Entity<VehicleMileage>(entity =>
            {
                entity.ToTable("VehicleMileage", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_VEHICLEMILEAGE_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.BillableAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.BillableRate).HasColumnType("float");

                entity.Property(e => e.BillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ClassRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClassRef_FullName");

                entity.Property(e => e.ClassRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ClassRef_ListID");

                entity.Property(e => e.CustomerRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CustomerRef_FullName");

                entity.Property(e => e.CustomerRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("CustomerRef_ListID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemRef_FullName");

                entity.Property(e => e.ItemRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ItemRef_ListID");

                entity.Property(e => e.Notes).HasColumnType("varchar(5000)");

                entity.Property(e => e.OdometerEnd).HasColumnType("int");

                entity.Property(e => e.OdometerStart).HasColumnType("int");

                entity.Property(e => e.StandardMileageRate).HasColumnType("float");

                entity.Property(e => e.StandardMileageTotalAmount).HasColumnType("float");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TotalMiles).HasColumnType("float");

                entity.Property(e => e.TripEndDate).HasColumnType("varchar(2000)");

                entity.Property(e => e.TripStartDate).HasColumnType("varchar(2000)");

                entity.Property(e => e.VehicleRefFullName)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("VehicleRef_FullName");

                entity.Property(e => e.VehicleRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("VehicleRef_ListID");

                entity.HasOne(d => d.ClassRefList)
                    .WithMany(p => p.VehicleMileages)
                    .HasForeignKey(d => d.ClassRefListId)
                    .HasConstraintName("FK_VehicleMileage_ClassRef_ListID_REF_Class_ID");

                entity.HasOne(d => d.CustomerRefList)
                    .WithMany(p => p.VehicleMileages)
                    .HasForeignKey(d => d.CustomerRefListId)
                    .HasConstraintName("FK_VehicleMileage_CustomerRef_ListID_REF_Customers_ID");

                entity.HasOne(d => d.ItemRefList)
                    .WithMany(p => p.VehicleMileages)
                    .HasForeignKey(d => d.ItemRefListId)
                    .HasConstraintName("FK_VehicleMileage_ItemRef_ListID_REF_Items_ID");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendors", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_VENDORS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasColumnType("varchar(99)");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.AlternateContact).HasColumnType("varchar(41)");

                entity.Property(e => e.AlternatePhone).HasColumnType("varchar(21)");

                entity.Property(e => e.Balance)
                    .HasColumnType("float")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Cc).HasColumnType("varchar(1023)");

                entity.Property(e => e.City).HasColumnType("varchar(255)");

                entity.Property(e => e.Company).HasColumnType("varchar(50)");

                entity.Property(e => e.Contact).HasColumnType("varchar(1023)");

                entity.Property(e => e.Country).HasColumnType("varchar(255)");

                entity.Property(e => e.CreditLimit).HasColumnType("float");

                entity.Property(e => e.CurrencyId).HasColumnType("varchar(255)");

                entity.Property(e => e.CurrencyName).HasColumnType("varchar(64)");

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EligibleFor1099).HasColumnType("bool");

                entity.Property(e => e.Email).HasColumnType("varchar(1023)");

                entity.Property(e => e.Fax).HasColumnType("varchar(21)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(25)");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.LastName).HasColumnType("varchar(25)");

                entity.Property(e => e.Line1).HasColumnType("varchar(500)");

                entity.Property(e => e.Line2).HasColumnType("varchar(500)");

                entity.Property(e => e.Line3).HasColumnType("varchar(500)");

                entity.Property(e => e.Line4).HasColumnType("varchar(500)");

                entity.Property(e => e.Line5).HasColumnType("varchar(41)");

                entity.Property(e => e.MiddleInitial).HasColumnType("varchar(25)");

                entity.Property(e => e.Name).HasColumnType("varchar(100)");

                entity.Property(e => e.NameOnCheck).HasColumnType("varchar(110)");

                entity.Property(e => e.Note).HasColumnType("varchar(41)");

                entity.Property(e => e.Notes).HasColumnType("varchar(5000)");

                entity.Property(e => e.Phone).HasColumnType("varchar(21)");

                entity.Property(e => e.PostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.PrefillAccountId1).HasColumnType("varchar(2000)");

                entity.Property(e => e.PrefillAccountId2).HasColumnType("varchar(2000)");

                entity.Property(e => e.PrefillAccountId3).HasColumnType("varchar(2000)");

                entity.Property(e => e.PrefillAccountName1).HasColumnType("varchar(2000)");

                entity.Property(e => e.PrefillAccountName2).HasColumnType("varchar(2000)");

                entity.Property(e => e.PrefillAccountName3).HasColumnType("varchar(2000)");

                entity.Property(e => e.SalesTaxCountry).HasColumnType("varchar(100)");

                entity.Property(e => e.Salutation).HasColumnType("varchar(15)");

                entity.Property(e => e.ShippingAddress)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShippingCity).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingCountry).HasColumnType("varchar(255)");

                entity.Property(e => e.ShippingLine1).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine2).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine3).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine4).HasColumnType("varchar(500)");

                entity.Property(e => e.ShippingLine5).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingNote).HasColumnType("varchar(41)");

                entity.Property(e => e.ShippingPostalCode).HasColumnType("varchar(30)");

                entity.Property(e => e.ShippingState).HasColumnType("varchar(255)");

                entity.Property(e => e.State).HasColumnType("varchar(255)");

                entity.Property(e => e.TaxIdentity).HasColumnType("varchar(20)");

                entity.Property(e => e.Terms).HasColumnType("varchar(100)");

                entity.Property(e => e.TermsId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type).HasColumnType("varchar(1000)");

                entity.Property(e => e.TypeId).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Vendors_CurrencyId_REF_Currency_ID");
            });

            modelBuilder.Entity<VendorCredit>(entity =>
            {
                entity.ToTable("VendorCredits", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_VENDORCREDITS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("varchar(2000)");

                entity.Property(e => e.ExpenseItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAggregate).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.TaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAggregate)
                    .HasColumnType("varchar(5000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionCount)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.VendorCredits)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_VendorCredits_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.TaxCodeNavigation)
                    .WithMany(p => p.VendorCredits)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_VendorCredits_TaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorCredits)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorCredits_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<VendorCreditExpenseItem>(entity =>
            {
                entity.ToTable("VendorCreditExpenseItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_VENDORCREDITEXPENSEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ExchangeRate).HasColumnType("varchar(2000)");

                entity.Property(e => e.ExpenseAccount).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAccountId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ExpenseBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ExpenseClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ExpenseLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExpenseMemo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ExpenseTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ExpenseTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.TaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorCreditId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.VendorCreditExpenseItemAccountsPayableNavigations)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_VendorCreditExpenseItems_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.ExpenseAccountNavigation)
                    .WithMany(p => p.VendorCreditExpenseItemExpenseAccountNavigations)
                    .HasForeignKey(d => d.ExpenseAccountId)
                    .HasConstraintName("FK_VendorCreditExpenseItems_ExpenseAccountId_REF_Accounts_ID");

                entity.HasOne(d => d.ExpenseClassNavigation)
                    .WithMany(p => p.VendorCreditExpenseItems)
                    .HasForeignKey(d => d.ExpenseClassId)
                    .HasConstraintName("FK_VendorCreditExpenseItems_ExpenseClassId_REF_Class_ID");

                entity.HasOne(d => d.ExpenseCustomerNavigation)
                    .WithMany(p => p.VendorCreditExpenseItems)
                    .HasForeignKey(d => d.ExpenseCustomerId)
                    .HasConstraintName("FK_VendorCreditExpenseItems_ExpenseCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ExpenseTaxCodeNavigation)
                    .WithMany(p => p.VendorCreditExpenseItemExpenseTaxCodeNavigations)
                    .HasForeignKey(d => d.ExpenseTaxCodeId)
                    .HasConstraintName("FK_VendorCreditExpenseItems_ExpenseTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.TaxCodeNavigation)
                    .WithMany(p => p.VendorCreditExpenseItemTaxCodeNavigations)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_VendorCreditExpenseItems_TaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.VendorCredit)
                    .WithMany(p => p.VendorCreditExpenseItems)
                    .HasForeignKey(d => d.VendorCreditId)
                    .HasConstraintName("FK_VendorCreditExpenseItems_VendorCreditId_REF_VendorCredits_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorCreditExpenseItems)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorCreditExpenseItems_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<VendorCreditLineItem>(entity =>
            {
                entity.ToTable("VendorCreditLineItems", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_VENDORCREDITLINEITEMS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountsPayable).HasColumnType("varchar(255)");

                entity.Property(e => e.AccountsPayableId).HasColumnType("varchar(255)");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.CustomFields).HasColumnType("varchar(2000)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ExchangeRate).HasColumnType("varchar(2000)");

                entity.Property(e => e.IsTaxIncluded).HasColumnType("bool");

                entity.Property(e => e.ItemAmount).HasColumnType("decimal(28, 6)");

                entity.Property(e => e.ItemBillableStatus).HasColumnType("varchar(13)");

                entity.Property(e => e.ItemClass).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemClassId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCost).HasColumnType("float");

                entity.Property(e => e.ItemCustomer).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemCustomerId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemDescription).HasColumnType("varchar(5000)");

                entity.Property(e => e.ItemGroup).HasColumnType("varchar(100)");

                entity.Property(e => e.ItemGroupId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationId).HasColumnType("varchar(31)");

                entity.Property(e => e.ItemInventorySiteLocationName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemInventorySiteName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemLineId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemLineNumber)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemQuantity).HasColumnType("float");

                entity.Property(e => e.ItemTaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.ItemTaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.ItemUnitOfMeasure).HasColumnType("varchar(31)");

                entity.Property(e => e.Memo).HasColumnType("varchar(5000)");

                entity.Property(e => e.ReferenceNumber).HasColumnType("varchar(21)");

                entity.Property(e => e.TaxCode).HasColumnType("varchar(3)");

                entity.Property(e => e.TaxCodeId).HasColumnType("varchar(255)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorCreditId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorId).HasColumnType("varchar(255)");

                entity.Property(e => e.VendorName).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AccountsPayableNavigation)
                    .WithMany(p => p.VendorCreditLineItems)
                    .HasForeignKey(d => d.AccountsPayableId)
                    .HasConstraintName("FK_VendorCreditLineItems_AccountsPayableId_REF_Accounts_ID");

                entity.HasOne(d => d.ItemClassNavigation)
                    .WithMany(p => p.VendorCreditLineItems)
                    .HasForeignKey(d => d.ItemClassId)
                    .HasConstraintName("FK_VendorCreditLineItems_ItemClassId_REF_Class_ID");

                entity.HasOne(d => d.ItemCustomerNavigation)
                    .WithMany(p => p.VendorCreditLineItems)
                    .HasForeignKey(d => d.ItemCustomerId)
                    .HasConstraintName("FK_VendorCreditLineItems_ItemCustomerId_REF_Customers_ID");

                entity.HasOne(d => d.ItemGroupNavigation)
                    .WithMany(p => p.VendorCreditLineItemItemGroupNavigations)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("FK_VendorCreditLineItems_ItemGroupId_REF_Items_ID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.VendorCreditLineItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_VendorCreditLineItems_ItemId_REF_Items_ID");

                entity.HasOne(d => d.ItemInventorySite)
                    .WithMany(p => p.VendorCreditLineItems)
                    .HasForeignKey(d => d.ItemInventorySiteId)
                    .HasConstraintName("FK_VendorCreditLineItems_ItemInventorySiteId_REF_InventorySites_ID");

                entity.HasOne(d => d.ItemTaxCodeNavigation)
                    .WithMany(p => p.VendorCreditLineItemItemTaxCodeNavigations)
                    .HasForeignKey(d => d.ItemTaxCodeId)
                    .HasConstraintName("FK_VendorCreditLineItems_ItemTaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.TaxCodeNavigation)
                    .WithMany(p => p.VendorCreditLineItemTaxCodeNavigations)
                    .HasForeignKey(d => d.TaxCodeId)
                    .HasConstraintName("FK_VendorCreditLineItems_TaxCodeId_REF_SalesTaxCodes_ID");

                entity.HasOne(d => d.VendorCredit)
                    .WithMany(p => p.VendorCreditLineItems)
                    .HasForeignKey(d => d.VendorCreditId)
                    .HasConstraintName("FK_VendorCreditLineItems_VendorCreditId_REF_VendorCredits_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorCreditLineItems)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorCreditLineItems_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<VendorCreditLinkedTransaction>(entity =>
            {
                entity.ToTable("VendorCreditLinkedTransactions", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_VENDORCREDITLINKEDTRANSACTIONS_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionAmount)
                    .HasColumnType("decimal(28, 6)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionLinkType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionReferenceNumber)
                    .HasColumnType("varchar(21)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TransactionType)
                    .HasColumnType("varchar(100)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TxnNumber)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorCreditId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorId)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VendorName)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.VendorCreditLinkedTransactions)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_VendorCreditLinkedTransactions_TransactionId_REF_Bills_ID");

                entity.HasOne(d => d.VendorCredit)
                    .WithMany(p => p.VendorCreditLinkedTransactions)
                    .HasForeignKey(d => d.VendorCreditId)
                    .HasConstraintName("FK_VendorCreditLinkedTransactions_VendorCreditId_REF_VendorCredits_ID");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorCreditLinkedTransactions)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorCreditLinkedTransactions_VendorId_REF_Vendors_ID");
            });

            modelBuilder.Entity<VendorType>(entity =>
            {
                entity.ToTable("VendorTypes", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_VENDORTYPES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(16)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.FullName).HasColumnType("varchar(159)");

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(31)");

                entity.Property(e => e.ParentRefFullName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentRef_FullName");

                entity.Property(e => e.ParentRefListId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ParentRef_ListId");

                entity.Property(e => e.Sublevel)
                    .HasColumnType("int")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.ParentRefList)
                    .WithMany(p => p.InverseParentRefList)
                    .HasForeignKey(d => d.ParentRefListId)
                    .HasConstraintName("FK_VendorTypes_ParentRef_ListId_REF_VendorTypes_ID");
            });

            modelBuilder.Entity<WorkersCompCode>(entity =>
            {
                entity.ToTable("WorkersCompCodes", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_WORKERSCOMPCODES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CurrentEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentRate).HasColumnType("float");

                entity.Property(e => e.Desc).HasColumnType("varchar(31)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(13)");

                entity.Property(e => e.NextEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.NextRate).HasColumnType("float");

                entity.Property(e => e.RateHistory).HasColumnType("varchar(2000)");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<WorkersCompCodeLine>(entity =>
            {
                entity.ToTable("WorkersCompCodeLines", "QuickBooks");

                entity.HasIndex(e => e.Id, "CDATA_QUICKBOOKS_WORKERSCOMPCODELINES_PRIMARYKEY_INDEX")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("varchar(255)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CurrentEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentRate).HasColumnType("float");

                entity.Property(e => e.Desc).HasColumnType("varchar(31)");

                entity.Property(e => e.EditSequence)
                    .HasColumnType("varchar(2000)")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IsActive).HasColumnType("bool");

                entity.Property(e => e.Name).HasColumnType("varchar(13)");

                entity.Property(e => e.NextEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.NextRate).HasColumnType("float");

                entity.Property(e => e.RateHistoryEffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("RateHistory_EffectiveDate");

                entity.Property(e => e.RateHistoryRate)
                    .HasColumnType("float")
                    .HasColumnName("RateHistory_Rate");

                entity.Property(e => e.TimeCreated)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TimeModified)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.WorkersCompCodeId).HasColumnType("varchar(255)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
