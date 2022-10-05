using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Preference
    {
        public string Id { get; set; } = null!;
        public bool? AccountingPreferencesIsUsingAccountNumbers { get; set; }
        public bool? AccountingPreferencesIsRequiringAccounts { get; set; }
        public bool? AccountingPreferencesIsUsingClassTracking { get; set; }
        public string? AccountingPreferencesAssignClassTo { get; set; }
        public bool? AccountingPreferencesIsUsingAuditTrail { get; set; }
        public bool? AccountingPreferencesIsAssigningJournalEntryNumbers { get; set; }
        public DateTime? AccountingPreferencesClosingDate { get; set; }
        public float? FinanceChargePreferencesAnnualInterestRate { get; set; }
        public decimal? FinanceChargePreferencesMinFinanceCharge { get; set; }
        public int? FinanceChargePreferencesGracePeriod { get; set; }
        public string? FinanceChargePreferencesFinanceChargeAccountRefListId { get; set; }
        public string? FinanceChargePreferencesFinanceChargeAccountRefFullName { get; set; }
        public bool? FinanceChargePreferencesIsAssessingForOverdueCharges { get; set; }
        public string? FinanceChargePreferencesCalculateChargesFrom { get; set; }
        public bool? FinanceChargePreferencesIsMarkedToBePrinted { get; set; }
        public bool? JobsAndEstimatesPreferencesIsUsingEstimates { get; set; }
        public bool? JobsAndEstimatesPreferencesIsUsingProgressInvoicing { get; set; }
        public bool? JobsAndEstimatesPreferencesIsPrintingItemsWithZeroAmounts { get; set; }
        public bool? MultiCurrencyPreferencesIsMultiCurrencyOn { get; set; }
        public string? MultiCurrencyPreferencesHomeCurrencyRefListId { get; set; }
        public string? MultiCurrencyPreferencesHomeCurrencyRefFullName { get; set; }
        public bool? MultiLocationInventoryPreferencesIsMultiLocationInventoryAvailable { get; set; }
        public bool? MultiLocationInventoryPreferencesIsMultiLocationInventoryEnabled { get; set; }
        public bool? PurchasesAndVendorsPreferencesIsUsingInventory { get; set; }
        public int? PurchasesAndVendorsPreferencesDaysBillsAreDue { get; set; }
        public bool? PurchasesAndVendorsPreferencesIsAutomaticallyUsingDiscounts { get; set; }
        public string? PurchasesAndVendorsPreferencesDefaultDiscountAccountRefListId { get; set; }
        public string? PurchasesAndVendorsPreferencesDefaultDiscountAccountRefFullName { get; set; }
        public string? ReportsPreferencesAgingReportBasis { get; set; }
        public string? ReportsPreferencesSummaryReportBasis { get; set; }
        public string? SalesAndCustomersPreferencesDefaultShipMethodRefListId { get; set; }
        public string? SalesAndCustomersPreferencesDefaultShipMethodRefFullName { get; set; }
        public string? SalesAndCustomersPreferencesDefaultFob { get; set; }
        public float? SalesAndCustomersPreferencesDefaultMarkup { get; set; }
        public bool? SalesAndCustomersPreferencesIsTrackingReimbursedExpensesAsIncome { get; set; }
        public bool? SalesAndCustomersPreferencesIsAutoApplyingPayments { get; set; }
        public bool? SalesAndCustomersPreferencesPriceLevelsIsUsingPriceLevels { get; set; }
        public bool? SalesAndCustomersPreferencesPriceLevelsIsRoundingSalesPriceUp { get; set; }
        public string? SalesTaxPreferencesDefaultItemSalesTaxRefListId { get; set; }
        public string? SalesTaxPreferencesDefaultItemSalesTaxRefFullName { get; set; }
        public string? SalesTaxPreferencesPaySalesTax { get; set; }
        public string? SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefListId { get; set; }
        public string? SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefFullName { get; set; }
        public string? SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefListId { get; set; }
        public string? SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefFullName { get; set; }
        public bool? SalesTaxPreferencesIsUsingVendorTaxCode { get; set; }
        public bool? SalesTaxPreferencesIsUsingCustomerTaxCode { get; set; }
        public bool? SalesTaxPreferencesIsUsingAmountsIncludeTax { get; set; }
        public string? TimeTrackingPreferencesFirstDayOfWeek { get; set; }
        public bool? CurrentAppAccessRightsIsAutomaticLoginAllowed { get; set; }
        public string? CurrentAppAccessRightsAutomaticLoginUserName { get; set; }
        public bool? CurrentAppAccessRightsIsPersonalDataAccessAllowed { get; set; }
        public bool? ItemsAndInventoryPreferencesEnhancedInventoryReceivingEnabled { get; set; }
        public string? ItemsAndInventoryPreferencesIsTrackingSerialOrLotNumber { get; set; }
        public bool? ItemsAndInventoryPreferencesIsTrackingOnSalesTransactionsEnabled { get; set; }
        public bool? ItemsAndInventoryPreferencesIsTrackingOnPurchaseTransactionsEnabled { get; set; }
        public bool? ItemsAndInventoryPreferencesIsTrackingOnInventoryAdjustmentEnabled { get; set; }
        public bool? ItemsAndInventoryPreferencesIsTrackingOnBuildAssemblyEnabled { get; set; }
        public bool? ItemsAndInventoryPreferencesFifoenabled { get; set; }
        public DateTime? ItemsAndInventoryPreferencesFifoeffectiveDate { get; set; }
        public bool? ItemsAndInventoryPreferencesIsRsbenabled { get; set; }
        public bool? ItemsAndInventoryPreferencesIsBarcodeEnabled { get; set; }

        public virtual Account? FinanceChargePreferencesFinanceChargeAccountRefList { get; set; }
        public virtual Currency? MultiCurrencyPreferencesHomeCurrencyRefList { get; set; }
        public virtual Account? PurchasesAndVendorsPreferencesDefaultDiscountAccountRefList { get; set; }
        public virtual ShippingMethod? SalesAndCustomersPreferencesDefaultShipMethodRefList { get; set; }
        public virtual SalesTaxItem? SalesTaxPreferencesDefaultItemSalesTaxRefList { get; set; }
        public virtual SalesTaxCode? SalesTaxPreferencesDefaultNonTaxableSalesTaxCodeRefList { get; set; }
        public virtual SalesTaxCode? SalesTaxPreferencesDefaultTaxableSalesTaxCodeRefList { get; set; }
    }
}
