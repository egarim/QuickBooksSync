using BitFwks.Scheduler.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace QuickBooksSync.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Preference : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Preference(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
         
        private string _Id;
        [Key(false)]
        public string Id
        {
            get => _Id;
            set => SetPropertyValue(nameof(Id), ref _Id, value);
        }  
        private Boolean? _AccountingPreferencesIsUsingAccountNumbers;
        public Boolean? AccountingPreferencesIsUsingAccountNumbers
        {
            get => _AccountingPreferencesIsUsingAccountNumbers;
            set => SetPropertyValue(nameof(AccountingPreferencesIsUsingAccountNumbers), ref _AccountingPreferencesIsUsingAccountNumbers, value);
        }  
        private Boolean? _AccountingPreferencesIsRequiringAccounts;
        public Boolean? AccountingPreferencesIsRequiringAccounts
        {
            get => _AccountingPreferencesIsRequiringAccounts;
            set => SetPropertyValue(nameof(AccountingPreferencesIsRequiringAccounts), ref _AccountingPreferencesIsRequiringAccounts, value);
        }  
        private Boolean? _AccountingPreferencesIsUsingClassTracking;
        public Boolean? AccountingPreferencesIsUsingClassTracking
        {
            get => _AccountingPreferencesIsUsingClassTracking;
            set => SetPropertyValue(nameof(AccountingPreferencesIsUsingClassTracking), ref _AccountingPreferencesIsUsingClassTracking, value);
        }  
        private String _AccountingPreferencesAssignClassTo;
        [Size(300)]
        public String AccountingPreferencesAssignClassTo
        {
            get => _AccountingPreferencesAssignClassTo;
            set => SetPropertyValue(nameof(AccountingPreferencesAssignClassTo), ref _AccountingPreferencesAssignClassTo, value);
        }  
        private Boolean? _AccountingPreferencesIsUsingAuditTrail;
        public Boolean? AccountingPreferencesIsUsingAuditTrail
        {
            get => _AccountingPreferencesIsUsingAuditTrail;
            set => SetPropertyValue(nameof(AccountingPreferencesIsUsingAuditTrail), ref _AccountingPreferencesIsUsingAuditTrail, value);
        }  
        private Boolean? _AccountingPreferencesIsAssigningJournalEntryNumbers;
        public Boolean? AccountingPreferencesIsAssigningJournalEntryNumbers
        {
            get => _AccountingPreferencesIsAssigningJournalEntryNumbers;
            set => SetPropertyValue(nameof(AccountingPreferencesIsAssigningJournalEntryNumbers), ref _AccountingPreferencesIsAssigningJournalEntryNumbers, value);
        }  
        private DateTime? _AccountingPreferencesClosingDate;
        public DateTime? AccountingPreferencesClosingDate
        {
            get => _AccountingPreferencesClosingDate;
            set => SetPropertyValue(nameof(AccountingPreferencesClosingDate), ref _AccountingPreferencesClosingDate, value);
        }  
        private Single? _FinanceChargePreferencesAnnualInterestRate;
        public Single? FinanceChargePreferencesAnnualInterestRate
        {
            get => _FinanceChargePreferencesAnnualInterestRate;
            set => SetPropertyValue(nameof(FinanceChargePreferencesAnnualInterestRate), ref _FinanceChargePreferencesAnnualInterestRate, value);
        }  
        private Decimal? _FinanceChargePreferencesMinFinanceCharge;
        public Decimal? FinanceChargePreferencesMinFinanceCharge
        {
            get => _FinanceChargePreferencesMinFinanceCharge;
            set => SetPropertyValue(nameof(FinanceChargePreferencesMinFinanceCharge), ref _FinanceChargePreferencesMinFinanceCharge, value);
        }  
        private Int32? _FinanceChargePreferencesGracePeriod;
        public Int32? FinanceChargePreferencesGracePeriod
        {
            get => _FinanceChargePreferencesGracePeriod;
            set => SetPropertyValue(nameof(FinanceChargePreferencesGracePeriod), ref _FinanceChargePreferencesGracePeriod, value);
        }  
        private String _FinanceChargePreferencesFinanceChargeAccountRefListId;
        [Size(300)]
        public String FinanceChargePreferencesFinanceChargeAccountRefListId
        {
            get => _FinanceChargePreferencesFinanceChargeAccountRefListId;
            set => SetPropertyValue(nameof(FinanceChargePreferencesFinanceChargeAccountRefListId), ref _FinanceChargePreferencesFinanceChargeAccountRefListId, value);
        }  
        private String _FinanceChargePreferencesFinanceChargeAccountRefFullName;
        [Size(300)]
        public String FinanceChargePreferencesFinanceChargeAccountRefFullName
        {
            get => _FinanceChargePreferencesFinanceChargeAccountRefFullName;
            set => SetPropertyValue(nameof(FinanceChargePreferencesFinanceChargeAccountRefFullName), ref _FinanceChargePreferencesFinanceChargeAccountRefFullName, value);
        }  
        private Boolean? _FinanceChargePreferencesIsAssessingForOverdueCharges;
        public Boolean? FinanceChargePreferencesIsAssessingForOverdueCharges
        {
            get => _FinanceChargePreferencesIsAssessingForOverdueCharges;
            set => SetPropertyValue(nameof(FinanceChargePreferencesIsAssessingForOverdueCharges), ref _FinanceChargePreferencesIsAssessingForOverdueCharges, value);
        }  
        private String _FinanceChargePreferencesCalculateChargesFrom;
        [Size(300)]
        public String FinanceChargePreferencesCalculateChargesFrom
        {
            get => _FinanceChargePreferencesCalculateChargesFrom;
            set => SetPropertyValue(nameof(FinanceChargePreferencesCalculateChargesFrom), ref _FinanceChargePreferencesCalculateChargesFrom, value);
        }  
        private Boolean? _FinanceChargePreferencesIsMarkedToBePrinted;
        public Boolean? FinanceChargePreferencesIsMarkedToBePrinted
        {
            get => _FinanceChargePreferencesIsMarkedToBePrinted;
            set => SetPropertyValue(nameof(FinanceChargePreferencesIsMarkedToBePrinted), ref _FinanceChargePreferencesIsMarkedToBePrinted, value);
        }  
        private Boolean? _JobsAndEstimatesPreferencesIsUsingEstimates;
        public Boolean? JobsAndEstimatesPreferencesIsUsingEstimates
        {
            get => _JobsAndEstimatesPreferencesIsUsingEstimates;
            set => SetPropertyValue(nameof(JobsAndEstimatesPreferencesIsUsingEstimates), ref _JobsAndEstimatesPreferencesIsUsingEstimates, value);
        }  
        private Boolean? _JobsAndEstimatesPreferencesIsUsingProgressInvoicing;
        public Boolean? JobsAndEstimatesPreferencesIsUsingProgressInvoicing
        {
            get => _JobsAndEstimatesPreferencesIsUsingProgressInvoicing;
            set => SetPropertyValue(nameof(JobsAndEstimatesPreferencesIsUsingProgressInvoicing), ref _JobsAndEstimatesPreferencesIsUsingProgressInvoicing, value);
        }  
        private Boolean? _JobsAndEstimatesPreferencesIsPrintingItemsWithZeroAmounts;
        public Boolean? JobsAndEstimatesPreferencesIsPrintingItemsWithZeroAmounts
        {
            get => _JobsAndEstimatesPreferencesIsPrintingItemsWithZeroAmounts;
            set => SetPropertyValue(nameof(JobsAndEstimatesPreferencesIsPrintingItemsWithZeroAmounts), ref _JobsAndEstimatesPreferencesIsPrintingItemsWithZeroAmounts, value);
        }  
        private Boolean? _MultiCurrencyPreferencesIsMultiCurrencyOn;
        public Boolean? MultiCurrencyPreferencesIsMultiCurrencyOn
        {
            get => _MultiCurrencyPreferencesIsMultiCurrencyOn;
            set => SetPropertyValue(nameof(MultiCurrencyPreferencesIsMultiCurrencyOn), ref _MultiCurrencyPreferencesIsMultiCurrencyOn, value);
        }  
        private String _MultiCurrencyPreferencesHomeCurrencyRefListId;
        [Size(300)]
        public String MultiCurrencyPreferencesHomeCurrencyRefListId
        {
            get => _MultiCurrencyPreferencesHomeCurrencyRefListId;
            set => SetPropertyValue(nameof(MultiCurrencyPreferencesHomeCurrencyRefListId), ref _MultiCurrencyPreferencesHomeCurrencyRefListId, value);
        }  
        private String _MultiCurrencyPreferencesHomeCurrencyRefFullName;
        [Size(300)]
        public String MultiCurrencyPreferencesHomeCurrencyRefFullName
        {
            get => _MultiCurrencyPreferencesHomeCurrencyRefFullName;
            set => SetPropertyValue(nameof(MultiCurrencyPreferencesHomeCurrencyRefFullName), ref _MultiCurrencyPreferencesHomeCurrencyRefFullName, value);
        }  
        private Boolean? _MultiLocationInventoryPreferencesIsMultiLocationInventoryAvailable;
        public Boolean? MultiLocationInventoryPreferencesIsMultiLocationInventoryAvailable
        {
            get => _MultiLocationInventoryPreferencesIsMultiLocationInventoryAvailable;
            set => SetPropertyValue(nameof(MultiLocationInventoryPreferencesIsMultiLocationInventoryAvailable), ref _MultiLocationInventoryPreferencesIsMultiLocationInventoryAvailable, value);
        }  
        private Boolean? _MultiLocationInventoryPreferencesIsMultiLocationInventoryEnabled;
        public Boolean? MultiLocationInventoryPreferencesIsMultiLocationInventoryEnabled
        {
            get => _MultiLocationInventoryPreferencesIsMultiLocationInventoryEnabled;
            set => SetPropertyValue(nameof(MultiLocationInventoryPreferencesIsMultiLocationInventoryEnabled), ref _MultiLocationInventoryPreferencesIsMultiLocationInventoryEnabled, value);
        }  
        private Boolean? _PurchasesAndVendorsPreferencesIsUsingInventory;
        public Boolean? PurchasesAndVendorsPreferencesIsUsingInventory
        {
            get => _PurchasesAndVendorsPreferencesIsUsingInventory;
            set => SetPropertyValue(nameof(PurchasesAndVendorsPreferencesIsUsingInventory), ref _PurchasesAndVendorsPreferencesIsUsingInventory, value);
        }  
        private Int32? _PurchasesAndVendorsPreferencesDaysBillsAreDue;
        public Int32? PurchasesAndVendorsPreferencesDaysBillsAreDue
        {
            get => _PurchasesAndVendorsPreferencesDaysBillsAreDue;
            set => SetPropertyValue(nameof(PurchasesAndVendorsPreferencesDaysBillsAreDue), ref _PurchasesAndVendorsPreferencesDaysBillsAreDue, value);
        }  
        private Boolean? _PurchasesAndVendorsPreferencesIsAutomaticallyUsingDiscounts;
        public Boolean? PurchasesAndVendorsPreferencesIsAutomaticallyUsingDiscounts
        {
            get => _PurchasesAndVendorsPreferencesIsAutomaticallyUsingDiscounts;
            set => SetPropertyValue(nameof(PurchasesAndVendorsPreferencesIsAutomaticallyUsingDiscounts), ref _PurchasesAndVendorsPreferencesIsAutomaticallyUsingDiscounts, value);
        }  
        private String _PurchasesAndVendorsPreferencesDefaultDiscountAccountRefListId;
        [Size(300)]
        public String PurchasesAndVendorsPreferencesDefaultDiscountAccountRefListId
        {
            get => _PurchasesAndVendorsPreferencesDefaultDiscountAccountRefListId;
            set => SetPropertyValue(nameof(PurchasesAndVendorsPreferencesDefaultDiscountAccountRefListId), ref _PurchasesAndVendorsPreferencesDefaultDiscountAccountRefListId, value);
        }  
        private String _PurchasesAndVendorsPreferencesDefaultDiscountAccountRefFullName;
        [Size(300)]
        public String PurchasesAndVendorsPreferencesDefaultDiscountAccountRefFullName
        {
            get => _PurchasesAndVendorsPreferencesDefaultDiscountAccountRefFullName;
            set => SetPropertyValue(nameof(PurchasesAndVendorsPreferencesDefaultDiscountAccountRefFullName), ref _PurchasesAndVendorsPreferencesDefaultDiscountAccountRefFullName, value);
        }  
        private String _ReportsPreferencesAgingReportBasis;
        [Size(300)]
        public String ReportsPreferencesAgingReportBasis
        {
            get => _ReportsPreferencesAgingReportBasis;
            set => SetPropertyValue(nameof(ReportsPreferencesAgingReportBasis), ref _ReportsPreferencesAgingReportBasis, value);
        }  
        private String _ReportsPreferencesSummaryReportBasis;
        [Size(300)]
        public String ReportsPreferencesSummaryReportBasis
        {
            get => _ReportsPreferencesSummaryReportBasis;
            set => SetPropertyValue(nameof(ReportsPreferencesSummaryReportBasis), ref _ReportsPreferencesSummaryReportBasis, value);
        }  
        private String _SalesAndCustomersPreferencesDefaultShipMethodRefListId;
        [Size(300)]
        public String SalesAndCustomersPreferencesDefaultShipMethodRefListId
        {
            get => _SalesAndCustomersPreferencesDefaultShipMethodRefListId;
            set => SetPropertyValue(nameof(SalesAndCustomersPreferencesDefaultShipMethodRefListId), ref _SalesAndCustomersPreferencesDefaultShipMethodRefListId, value);
        }  
        private String _SalesAndCustomersPreferencesDefaultShipMethodRefFullName;
        [Size(300)]
        public String SalesAndCustomersPreferencesDefaultShipMethodRefFullName
        {
            get => _SalesAndCustomersPreferencesDefaultShipMethodRefFullName;
            set => SetPropertyValue(nameof(SalesAndCustomersPreferencesDefaultShipMethodRefFullName), ref _SalesAndCustomersPreferencesDefaultShipMethodRefFullName, value);
        }  
        private String _SalesAndCustomersPreferencesDefaultFob;
        [Size(300)]
        public String SalesAndCustomersPreferencesDefaultFob
        {
            get => _SalesAndCustomersPreferencesDefaultFob;
            set => SetPropertyValue(nameof(SalesAndCustomersPreferencesDefaultFob), ref _SalesAndCustomersPreferencesDefaultFob, value);
        }  
        private Single? _SalesAndCustomersPreferencesDefaultMarkup;
        public Single? SalesAndCustomersPreferencesDefaultMarkup
        {
            get => _SalesAndCustomersPreferencesDefaultMarkup;
            set => SetPropertyValue(nameof(SalesAndCustomersPreferencesDefaultMarkup), ref _SalesAndCustomersPreferencesDefaultMarkup, value);
        }  
        private Boolean? _SalesAndCustomersPreferencesIsTrackingReimbursedExpensesAsIncome;
        public Boolean? SalesAndCustomersPreferencesIsTrackingReimbursedExpensesAsIncome
        {
            get => _SalesAndCustomersPreferencesIsTrackingReimbursedExpensesAsIncome;
            set => SetPropertyValue(nameof(SalesAndCustomersPreferencesIsTrackingReimbursedExpensesAsIncome), ref _SalesAndCustomersPreferencesIsTrackingReimbursedExpensesAsIncome, value);
        }  
        private Boolean? _SalesAndCustomersPreferencesIsAutoApplyingPayments;
        public Boolean? SalesAndCustomersPreferencesIsAutoApplyingPayments
        {
            get => _SalesAndCustomersPreferencesIsAutoApplyingPayments;
            set => SetPropertyValue(nameof(SalesAndCustomersPreferencesIsAutoApplyingPayments), ref _SalesAndCustomersPreferencesIsAutoApplyingPayments, value);
        }  
        private Boolean? _SalesAndCustomersPreferencesPriceLevelsIsUsingPriceLevels;
        public Boolean? SalesAndCustomersPreferencesPriceLevelsIsUsingPriceLevels
        {
            get => _SalesAndCustomersPreferencesPriceLevelsIsUsingPriceLevels;
            set => SetPropertyValue(nameof(SalesAndCustomersPreferencesPriceLevelsIsUsingPriceLevels), ref _SalesAndCustomersPreferencesPriceLevelsIsUsingPriceLevels, value);
        }  
        private Boolean? _SalesAndCustomersPreferencesPriceLevelsIsRoundingSalesPriceUp;
        public Boolean? SalesAndCustomersPreferencesPriceLevelsIsRoundingSalesPriceUp
        {
            get => _SalesAndCustomersPreferencesPriceLevelsIsRoundingSalesPriceUp;
            set => SetPropertyValue(nameof(SalesAndCustomersPreferencesPriceLevelsIsRoundingSalesPriceUp), ref _SalesAndCustomersPreferencesPriceLevelsIsRoundingSalesPriceUp, value);
        }  
        private String _SalesTaxPreferencesDefaultItemSalesTaxRefListId;
        [Size(300)]
        public String SalesTaxPreferencesDefaultItemSalesTaxRefListId
        {
            get => _SalesTaxPreferencesDefaultItemSalesTaxRefListId;
            set => SetPropertyValue(nameof(SalesTaxPreferencesDefaultItemSalesTaxRefListId), ref _SalesTaxPreferencesDefaultItemSalesTaxRefListId, value);
        }  
        private String _SalesTaxPreferencesDefaultItemSalesTaxRefFullName;
        [Size(300)]
        public String SalesTaxPreferencesDefaultItemSalesTaxRefFullName
        {
            get => _SalesTaxPreferencesDefaultItemSalesTaxRefFullName;
            set => SetPropertyValue(nameof(SalesTaxPreferencesDefaultItemSalesTaxRefFullName), ref _SalesTaxPreferencesDefaultItemSalesTaxRefFullName, value);
        }  
        private String _SalesTaxPreferencesPaySalesTax;
        [Size(300)]
        public String SalesTaxPreferencesPaySalesTax
        {
            get => _SalesTaxPreferencesPaySalesTax;
            set => SetPropertyValue(nameof(SalesTaxPreferencesPaySalesTax), ref _SalesTaxPreferencesPaySalesTax, value);
        }  
        private String _SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefListId;
        [Size(300)]
        public String SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefListId
        {
            get => _SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefListId;
            set => SetPropertyValue(nameof(SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefListId), ref _SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefListId, value);
        }  
        private String _SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefFullName;
        [Size(300)]
        public String SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefFullName
        {
            get => _SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefFullName;
            set => SetPropertyValue(nameof(SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefFullName), ref _SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefFullName, value);
        }  
        private String _SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefListId;
        [Size(300)]
        public String SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefListId
        {
            get => _SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefListId;
            set => SetPropertyValue(nameof(SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefListId), ref _SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefListId, value);
        }  
        private String _SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefFullName;
        [Size(300)]
        public String SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefFullName
        {
            get => _SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefFullName;
            set => SetPropertyValue(nameof(SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefFullName), ref _SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefFullName, value);
        }  
        private Boolean? _SalesTaxPreferencesIsUsingVendorTaxCode;
        public Boolean? SalesTaxPreferencesIsUsingVendorTaxCode
        {
            get => _SalesTaxPreferencesIsUsingVendorTaxCode;
            set => SetPropertyValue(nameof(SalesTaxPreferencesIsUsingVendorTaxCode), ref _SalesTaxPreferencesIsUsingVendorTaxCode, value);
        }  
        private Boolean? _SalesTaxPreferencesIsUsingCustomerTaxCode;
        public Boolean? SalesTaxPreferencesIsUsingCustomerTaxCode
        {
            get => _SalesTaxPreferencesIsUsingCustomerTaxCode;
            set => SetPropertyValue(nameof(SalesTaxPreferencesIsUsingCustomerTaxCode), ref _SalesTaxPreferencesIsUsingCustomerTaxCode, value);
        }  
        private Boolean? _SalesTaxPreferencesIsUsingAmountsIncludeTax;
        public Boolean? SalesTaxPreferencesIsUsingAmountsIncludeTax
        {
            get => _SalesTaxPreferencesIsUsingAmountsIncludeTax;
            set => SetPropertyValue(nameof(SalesTaxPreferencesIsUsingAmountsIncludeTax), ref _SalesTaxPreferencesIsUsingAmountsIncludeTax, value);
        }  
        private String _TimeTrackingPreferencesFirstDayOfWeek;
        [Size(300)]
        public String TimeTrackingPreferencesFirstDayOfWeek
        {
            get => _TimeTrackingPreferencesFirstDayOfWeek;
            set => SetPropertyValue(nameof(TimeTrackingPreferencesFirstDayOfWeek), ref _TimeTrackingPreferencesFirstDayOfWeek, value);
        }  
        private Boolean? _CurrentAppAccessRightsIsAutomaticLoginAllowed;
        public Boolean? CurrentAppAccessRightsIsAutomaticLoginAllowed
        {
            get => _CurrentAppAccessRightsIsAutomaticLoginAllowed;
            set => SetPropertyValue(nameof(CurrentAppAccessRightsIsAutomaticLoginAllowed), ref _CurrentAppAccessRightsIsAutomaticLoginAllowed, value);
        }  
        private String _CurrentAppAccessRightsAutomaticLoginUserName;
        [Size(300)]
        public String CurrentAppAccessRightsAutomaticLoginUserName
        {
            get => _CurrentAppAccessRightsAutomaticLoginUserName;
            set => SetPropertyValue(nameof(CurrentAppAccessRightsAutomaticLoginUserName), ref _CurrentAppAccessRightsAutomaticLoginUserName, value);
        }  
        private Boolean? _CurrentAppAccessRightsIsPersonalDataAccessAllowed;
        public Boolean? CurrentAppAccessRightsIsPersonalDataAccessAllowed
        {
            get => _CurrentAppAccessRightsIsPersonalDataAccessAllowed;
            set => SetPropertyValue(nameof(CurrentAppAccessRightsIsPersonalDataAccessAllowed), ref _CurrentAppAccessRightsIsPersonalDataAccessAllowed, value);
        }  
        private Boolean? _ItemsAndInventoryPreferencesEnhancedInventoryReceivingEnabled;
        public Boolean? ItemsAndInventoryPreferencesEnhancedInventoryReceivingEnabled
        {
            get => _ItemsAndInventoryPreferencesEnhancedInventoryReceivingEnabled;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesEnhancedInventoryReceivingEnabled), ref _ItemsAndInventoryPreferencesEnhancedInventoryReceivingEnabled, value);
        }  
        private String _ItemsAndInventoryPreferencesIsTrackingSerialOrLotNumber;
        [Size(300)]
        public String ItemsAndInventoryPreferencesIsTrackingSerialOrLotNumber
        {
            get => _ItemsAndInventoryPreferencesIsTrackingSerialOrLotNumber;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesIsTrackingSerialOrLotNumber), ref _ItemsAndInventoryPreferencesIsTrackingSerialOrLotNumber, value);
        }  
        private Boolean? _ItemsAndInventoryPreferencesIsTrackingOnSalesTransactionsEnabled;
        public Boolean? ItemsAndInventoryPreferencesIsTrackingOnSalesTransactionsEnabled
        {
            get => _ItemsAndInventoryPreferencesIsTrackingOnSalesTransactionsEnabled;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesIsTrackingOnSalesTransactionsEnabled), ref _ItemsAndInventoryPreferencesIsTrackingOnSalesTransactionsEnabled, value);
        }  
        private Boolean? _ItemsAndInventoryPreferencesIsTrackingOnPurchaseTransactionsEnabled;
        public Boolean? ItemsAndInventoryPreferencesIsTrackingOnPurchaseTransactionsEnabled
        {
            get => _ItemsAndInventoryPreferencesIsTrackingOnPurchaseTransactionsEnabled;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesIsTrackingOnPurchaseTransactionsEnabled), ref _ItemsAndInventoryPreferencesIsTrackingOnPurchaseTransactionsEnabled, value);
        }  
        private Boolean? _ItemsAndInventoryPreferencesIsTrackingOnInventoryAdjustmentEnabled;
        public Boolean? ItemsAndInventoryPreferencesIsTrackingOnInventoryAdjustmentEnabled
        {
            get => _ItemsAndInventoryPreferencesIsTrackingOnInventoryAdjustmentEnabled;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesIsTrackingOnInventoryAdjustmentEnabled), ref _ItemsAndInventoryPreferencesIsTrackingOnInventoryAdjustmentEnabled, value);
        }  
        private Boolean? _ItemsAndInventoryPreferencesIsTrackingOnBuildAssemblyEnabled;
        public Boolean? ItemsAndInventoryPreferencesIsTrackingOnBuildAssemblyEnabled
        {
            get => _ItemsAndInventoryPreferencesIsTrackingOnBuildAssemblyEnabled;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesIsTrackingOnBuildAssemblyEnabled), ref _ItemsAndInventoryPreferencesIsTrackingOnBuildAssemblyEnabled, value);
        }  
        private Boolean? _ItemsAndInventoryPreferencesFifoenabled;
        public Boolean? ItemsAndInventoryPreferencesFifoenabled
        {
            get => _ItemsAndInventoryPreferencesFifoenabled;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesFifoenabled), ref _ItemsAndInventoryPreferencesFifoenabled, value);
        }  
        private DateTime? _ItemsAndInventoryPreferencesFifoeffectiveDate;
        public DateTime? ItemsAndInventoryPreferencesFifoeffectiveDate
        {
            get => _ItemsAndInventoryPreferencesFifoeffectiveDate;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesFifoeffectiveDate), ref _ItemsAndInventoryPreferencesFifoeffectiveDate, value);
        }  
        private Boolean? _ItemsAndInventoryPreferencesIsRsbenabled;
        public Boolean? ItemsAndInventoryPreferencesIsRsbenabled
        {
            get => _ItemsAndInventoryPreferencesIsRsbenabled;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesIsRsbenabled), ref _ItemsAndInventoryPreferencesIsRsbenabled, value);
        }  
        private Boolean? _ItemsAndInventoryPreferencesIsBarcodeEnabled;
        public Boolean? ItemsAndInventoryPreferencesIsBarcodeEnabled
        {
            get => _ItemsAndInventoryPreferencesIsBarcodeEnabled;
            set => SetPropertyValue(nameof(ItemsAndInventoryPreferencesIsBarcodeEnabled), ref _ItemsAndInventoryPreferencesIsBarcodeEnabled, value);
        }
        public const string QueryableProperties="Id,AccountingPreferencesIsUsingAccountNumbers,AccountingPreferencesIsRequiringAccounts,AccountingPreferencesIsUsingClassTracking,AccountingPreferencesAssignClassTo,AccountingPreferencesIsUsingAuditTrail,AccountingPreferencesIsAssigningJournalEntryNumbers,AccountingPreferencesClosingDate,FinanceChargePreferencesAnnualInterestRate,FinanceChargePreferencesMinFinanceCharge,FinanceChargePreferencesGracePeriod,FinanceChargePreferencesFinanceChargeAccountRefListId,FinanceChargePreferencesFinanceChargeAccountRefFullName,FinanceChargePreferencesIsAssessingForOverdueCharges,FinanceChargePreferencesCalculateChargesFrom,FinanceChargePreferencesIsMarkedToBePrinted,JobsAndEstimatesPreferencesIsUsingEstimates,JobsAndEstimatesPreferencesIsUsingProgressInvoicing,JobsAndEstimatesPreferencesIsPrintingItemsWithZeroAmounts,MultiCurrencyPreferencesIsMultiCurrencyOn,MultiCurrencyPreferencesHomeCurrencyRefListId,MultiCurrencyPreferencesHomeCurrencyRefFullName,MultiLocationInventoryPreferencesIsMultiLocationInventoryAvailable,MultiLocationInventoryPreferencesIsMultiLocationInventoryEnabled,PurchasesAndVendorsPreferencesIsUsingInventory,PurchasesAndVendorsPreferencesDaysBillsAreDue,PurchasesAndVendorsPreferencesIsAutomaticallyUsingDiscounts,PurchasesAndVendorsPreferencesDefaultDiscountAccountRefListId,PurchasesAndVendorsPreferencesDefaultDiscountAccountRefFullName,ReportsPreferencesAgingReportBasis,ReportsPreferencesSummaryReportBasis,SalesAndCustomersPreferencesDefaultShipMethodRefListId,SalesAndCustomersPreferencesDefaultShipMethodRefFullName,SalesAndCustomersPreferencesDefaultFob,SalesAndCustomersPreferencesDefaultMarkup,SalesAndCustomersPreferencesIsTrackingReimbursedExpensesAsIncome,SalesAndCustomersPreferencesIsAutoApplyingPayments,SalesAndCustomersPreferencesPriceLevelsIsUsingPriceLevels,SalesAndCustomersPreferencesPriceLevelsIsRoundingSalesPriceUp,SalesTaxPreferencesDefaultItemSalesTaxRefListId,SalesTaxPreferencesDefaultItemSalesTaxRefFullName,SalesTaxPreferencesPaySalesTax,SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefListId,SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefFullName,SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefListId,SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefFullName,SalesTaxPreferencesIsUsingVendorTaxCode,SalesTaxPreferencesIsUsingCustomerTaxCode,SalesTaxPreferencesIsUsingAmountsIncludeTax,TimeTrackingPreferencesFirstDayOfWeek,CurrentAppAccessRightsIsAutomaticLoginAllowed,CurrentAppAccessRightsAutomaticLoginUserName,CurrentAppAccessRightsIsPersonalDataAccessAllowed,ItemsAndInventoryPreferencesEnhancedInventoryReceivingEnabled,ItemsAndInventoryPreferencesIsTrackingSerialOrLotNumber,ItemsAndInventoryPreferencesIsTrackingOnSalesTransactionsEnabled,ItemsAndInventoryPreferencesIsTrackingOnPurchaseTransactionsEnabled,ItemsAndInventoryPreferencesIsTrackingOnInventoryAdjustmentEnabled,ItemsAndInventoryPreferencesIsTrackingOnBuildAssemblyEnabled,ItemsAndInventoryPreferencesFifoenabled,ItemsAndInventoryPreferencesFifoeffectiveDate,ItemsAndInventoryPreferencesIsRsbenabled,ItemsAndInventoryPreferencesIsBarcodeEnabled";
    }
}