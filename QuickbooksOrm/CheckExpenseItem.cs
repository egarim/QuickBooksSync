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
    public class CheckExpenseItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CheckExpenseItem(Session session)
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
        private String? _CheckId;
        public String? CheckId
        {
            get => _CheckId;
            set => SetPropertyValue(nameof(CheckId), ref _CheckId, value);
        }  
        private String? _ReferenceNumber;
        public String? ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
        }  
        private Int32 _TxnNumber;
        public Int32 TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private String? _Account;
        public String? Account
        {
            get => _Account;
            set => SetPropertyValue(nameof(Account), ref _Account, value);
        }  
        private String? _AccountId;
        public String? AccountId
        {
            get => _AccountId;
            set => SetPropertyValue(nameof(AccountId), ref _AccountId, value);
        }  
        private String? _Payee;
        public String? Payee
        {
            get => _Payee;
            set => SetPropertyValue(nameof(Payee), ref _Payee, value);
        }  
        private String? _PayeeId;
        public String? PayeeId
        {
            get => _PayeeId;
            set => SetPropertyValue(nameof(PayeeId), ref _PayeeId, value);
        }  
        private DateTime _Date;
        public DateTime Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
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
        private String? _Address;
        public String? Address
        {
            get => _Address;
            set => SetPropertyValue(nameof(Address), ref _Address, value);
        }  
        private String? _Line1;
        public String? Line1
        {
            get => _Line1;
            set => SetPropertyValue(nameof(Line1), ref _Line1, value);
        }  
        private String? _Line2;
        public String? Line2
        {
            get => _Line2;
            set => SetPropertyValue(nameof(Line2), ref _Line2, value);
        }  
        private String? _Line3;
        public String? Line3
        {
            get => _Line3;
            set => SetPropertyValue(nameof(Line3), ref _Line3, value);
        }  
        private String? _Line4;
        public String? Line4
        {
            get => _Line4;
            set => SetPropertyValue(nameof(Line4), ref _Line4, value);
        }  
        private String? _Line5;
        public String? Line5
        {
            get => _Line5;
            set => SetPropertyValue(nameof(Line5), ref _Line5, value);
        }  
        private String? _City;
        public String? City
        {
            get => _City;
            set => SetPropertyValue(nameof(City), ref _City, value);
        }  
        private String? _State;
        public String? State
        {
            get => _State;
            set => SetPropertyValue(nameof(State), ref _State, value);
        }  
        private String? _PostalCode;
        public String? PostalCode
        {
            get => _PostalCode;
            set => SetPropertyValue(nameof(PostalCode), ref _PostalCode, value);
        }  
        private String? _Country;
        public String? Country
        {
            get => _Country;
            set => SetPropertyValue(nameof(Country), ref _Country, value);
        }  
        private String? _Note;
        public String? Note
        {
            get => _Note;
            set => SetPropertyValue(nameof(Note), ref _Note, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
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
        private String? _ExpenseCustomFields;
        public String? ExpenseCustomFields
        {
            get => _ExpenseCustomFields;
            set => SetPropertyValue(nameof(ExpenseCustomFields), ref _ExpenseCustomFields, value);
        }  
        private Boolean _IsToBePrinted;
        public Boolean IsToBePrinted
        {
            get => _IsToBePrinted;
            set => SetPropertyValue(nameof(IsToBePrinted), ref _IsToBePrinted, value);
        }  
        private Boolean _IsTaxIncluded;
        public Boolean IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
        }  
        private String? _CurrencyName;
        public String? CurrencyName
        {
            get => _CurrencyName;
            set => SetPropertyValue(nameof(CurrencyName), ref _CurrencyName, value);
        }  
        private String? _CurrencyId;
        public String? CurrencyId
        {
            get => _CurrencyId;
            set => SetPropertyValue(nameof(CurrencyId), ref _CurrencyId, value);
        }  
        private Single _ExchangeRate;
        public Single ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
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
        private string _AccountNavigation;
        public string AccountNavigation
        {
            get => _AccountNavigation;
            set => SetPropertyValue(nameof(AccountNavigation), ref _AccountNavigation, value);
        }  
        private string _Check;
        public string Check
        {
            get => _Check;
            set => SetPropertyValue(nameof(Check), ref _Check, value);
        }  
        private string _Currency;
        public string Currency
        {
            get => _Currency;
            set => SetPropertyValue(nameof(Currency), ref _Currency, value);
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
        private string _PayeeNavigation;
        public string PayeeNavigation
        {
            get => _PayeeNavigation;
            set => SetPropertyValue(nameof(PayeeNavigation), ref _PayeeNavigation, value);
        }
       
    }
}