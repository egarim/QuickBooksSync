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
    public class VendorCreditExpenseItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public VendorCreditExpenseItem(Session session)
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
        private String? _VendorCreditId;
        public String? VendorCreditId
        {
            get => _VendorCreditId;
            set => SetPropertyValue(nameof(VendorCreditId), ref _VendorCreditId, value);
        }  
        private String? _VendorName;
        public String? VendorName
        {
            get => _VendorName;
            set => SetPropertyValue(nameof(VendorName), ref _VendorName, value);
        }  
        private String? _VendorId;
        public String? VendorId
        {
            get => _VendorId;
            set => SetPropertyValue(nameof(VendorId), ref _VendorId, value);
        }  
        private DateTime _Date;
        public DateTime Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private Int32 _TxnNumber;
        public Int32 TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private String? _ReferenceNumber;
        public String? ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
        }  
        private String? _AccountsPayable;
        public String? AccountsPayable
        {
            get => _AccountsPayable;
            set => SetPropertyValue(nameof(AccountsPayable), ref _AccountsPayable, value);
        }  
        private String? _AccountsPayableId;
        public String? AccountsPayableId
        {
            get => _AccountsPayableId;
            set => SetPropertyValue(nameof(AccountsPayableId), ref _AccountsPayableId, value);
        }  
        private Decimal _Amount;
        public Decimal Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private String? _Memo;
        public String? Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private Boolean _IsTaxIncluded;
        public Boolean IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
        }  
        private String? _TaxCode;
        public String? TaxCode
        {
            get => _TaxCode;
            set => SetPropertyValue(nameof(TaxCode), ref _TaxCode, value);
        }  
        private String? _TaxCodeId;
        public String? TaxCodeId
        {
            get => _TaxCodeId;
            set => SetPropertyValue(nameof(TaxCodeId), ref _TaxCodeId, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String? _ExchangeRate;
        public String? ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private String? _ExpenseLineId;
        public String? ExpenseLineId
        {
            get => _ExpenseLineId;
            set => SetPropertyValue(nameof(ExpenseLineId), ref _ExpenseLineId, value);
        }  
        private String? _ExpenseLineNumber;
        public String? ExpenseLineNumber
        {
            get => _ExpenseLineNumber;
            set => SetPropertyValue(nameof(ExpenseLineNumber), ref _ExpenseLineNumber, value);
        }  
        private String? _ExpenseAccount;
        public String? ExpenseAccount
        {
            get => _ExpenseAccount;
            set => SetPropertyValue(nameof(ExpenseAccount), ref _ExpenseAccount, value);
        }  
        private String? _ExpenseAccountId;
        public String? ExpenseAccountId
        {
            get => _ExpenseAccountId;
            set => SetPropertyValue(nameof(ExpenseAccountId), ref _ExpenseAccountId, value);
        }  
        private Decimal _ExpenseAmount;
        public Decimal ExpenseAmount
        {
            get => _ExpenseAmount;
            set => SetPropertyValue(nameof(ExpenseAmount), ref _ExpenseAmount, value);
        }  
        private String? _ExpenseBillableStatus;
        public String? ExpenseBillableStatus
        {
            get => _ExpenseBillableStatus;
            set => SetPropertyValue(nameof(ExpenseBillableStatus), ref _ExpenseBillableStatus, value);
        }  
        private String? _ExpenseCustomer;
        public String? ExpenseCustomer
        {
            get => _ExpenseCustomer;
            set => SetPropertyValue(nameof(ExpenseCustomer), ref _ExpenseCustomer, value);
        }  
        private String? _ExpenseCustomerId;
        public String? ExpenseCustomerId
        {
            get => _ExpenseCustomerId;
            set => SetPropertyValue(nameof(ExpenseCustomerId), ref _ExpenseCustomerId, value);
        }  
        private String? _ExpenseClass;
        public String? ExpenseClass
        {
            get => _ExpenseClass;
            set => SetPropertyValue(nameof(ExpenseClass), ref _ExpenseClass, value);
        }  
        private String? _ExpenseClassId;
        public String? ExpenseClassId
        {
            get => _ExpenseClassId;
            set => SetPropertyValue(nameof(ExpenseClassId), ref _ExpenseClassId, value);
        }  
        private String? _ExpenseTaxCode;
        public String? ExpenseTaxCode
        {
            get => _ExpenseTaxCode;
            set => SetPropertyValue(nameof(ExpenseTaxCode), ref _ExpenseTaxCode, value);
        }  
        private String? _ExpenseTaxCodeId;
        public String? ExpenseTaxCodeId
        {
            get => _ExpenseTaxCodeId;
            set => SetPropertyValue(nameof(ExpenseTaxCodeId), ref _ExpenseTaxCodeId, value);
        }  
        private String? _ExpenseMemo;
        public String? ExpenseMemo
        {
            get => _ExpenseMemo;
            set => SetPropertyValue(nameof(ExpenseMemo), ref _ExpenseMemo, value);
        }  
        private DateTime _TimeModified;
        public DateTime TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private DateTime _TimeCreated;
        public DateTime TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private string _AccountsPayableNavigation;
        public string AccountsPayableNavigation
        {
            get => _AccountsPayableNavigation;
            set => SetPropertyValue(nameof(AccountsPayableNavigation), ref _AccountsPayableNavigation, value);
        }  
        private string _ExpenseAccountNavigation;
        public string ExpenseAccountNavigation
        {
            get => _ExpenseAccountNavigation;
            set => SetPropertyValue(nameof(ExpenseAccountNavigation), ref _ExpenseAccountNavigation, value);
        }  
        private string _ExpenseClassNavigation;
        public string ExpenseClassNavigation
        {
            get => _ExpenseClassNavigation;
            set => SetPropertyValue(nameof(ExpenseClassNavigation), ref _ExpenseClassNavigation, value);
        }  
        private string _ExpenseCustomerNavigation;
        public string ExpenseCustomerNavigation
        {
            get => _ExpenseCustomerNavigation;
            set => SetPropertyValue(nameof(ExpenseCustomerNavigation), ref _ExpenseCustomerNavigation, value);
        }  
        private string _ExpenseTaxCodeNavigation;
        public string ExpenseTaxCodeNavigation
        {
            get => _ExpenseTaxCodeNavigation;
            set => SetPropertyValue(nameof(ExpenseTaxCodeNavigation), ref _ExpenseTaxCodeNavigation, value);
        }  
        private string _TaxCodeNavigation;
        public string TaxCodeNavigation
        {
            get => _TaxCodeNavigation;
            set => SetPropertyValue(nameof(TaxCodeNavigation), ref _TaxCodeNavigation, value);
        }  
        private string _Vendor;
        public string Vendor
        {
            get => _Vendor;
            set => SetPropertyValue(nameof(Vendor), ref _Vendor, value);
        }  
        private string _VendorCredit;
        public string VendorCredit
        {
            get => _VendorCredit;
            set => SetPropertyValue(nameof(VendorCredit), ref _VendorCredit, value);
        }
        public const string QueriableProperties="Id,VendorCreditId,VendorName,VendorId,Date,TxnNumber,ReferenceNumber,AccountsPayable,AccountsPayableId,Amount,Memo,IsTaxIncluded,TaxCode,TaxCodeId,CustomFields,ExchangeRate,ExpenseLineId,ExpenseLineNumber,ExpenseAccount,ExpenseAccountId,ExpenseAmount,ExpenseBillableStatus,ExpenseCustomer,ExpenseCustomerId,ExpenseClass,ExpenseClassId,ExpenseTaxCode,ExpenseTaxCodeId,ExpenseMemo,TimeModified,TimeCreated,AccountsPayableNavigation,ExpenseAccountNavigation,ExpenseClassNavigation,ExpenseCustomerNavigation,ExpenseTaxCodeNavigation,TaxCodeNavigation,Vendor,VendorCredit";
    }
}