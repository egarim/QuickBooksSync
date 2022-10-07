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
        private String _CheckId;
        [Size(300)]
        public String CheckId
        {
            get => _CheckId;
            set => SetPropertyValue(nameof(CheckId), ref _CheckId, value);
        }  
        private String _ReferenceNumber;
        [Size(300)]
        public String ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
        }  
        private Int32? _TxnNumber;
        public Int32? TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private String _Account;
        [Size(300)]
        public String Account
        {
            get => _Account;
            set => SetPropertyValue(nameof(Account), ref _Account, value);
        }  
        private String _AccountId;
        [Size(300)]
        public String AccountId
        {
            get => _AccountId;
            set => SetPropertyValue(nameof(AccountId), ref _AccountId, value);
        }  
        private String _Payee;
        [Size(300)]
        public String Payee
        {
            get => _Payee;
            set => SetPropertyValue(nameof(Payee), ref _Payee, value);
        }  
        private String _PayeeId;
        [Size(300)]
        public String PayeeId
        {
            get => _PayeeId;
            set => SetPropertyValue(nameof(PayeeId), ref _PayeeId, value);
        }  
        private DateTime? _Date;
        public DateTime? Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private Decimal? _Amount;
        public Decimal? Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private String _Memo;
        [Size(300)]
        public String Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private String _Address;
        [Size(300)]
        public String Address
        {
            get => _Address;
            set => SetPropertyValue(nameof(Address), ref _Address, value);
        }  
        private String _Line1;
        [Size(300)]
        public String Line1
        {
            get => _Line1;
            set => SetPropertyValue(nameof(Line1), ref _Line1, value);
        }  
        private String _Line2;
        [Size(300)]
        public String Line2
        {
            get => _Line2;
            set => SetPropertyValue(nameof(Line2), ref _Line2, value);
        }  
        private String _Line3;
        [Size(300)]
        public String Line3
        {
            get => _Line3;
            set => SetPropertyValue(nameof(Line3), ref _Line3, value);
        }  
        private String _Line4;
        [Size(300)]
        public String Line4
        {
            get => _Line4;
            set => SetPropertyValue(nameof(Line4), ref _Line4, value);
        }  
        private String _Line5;
        [Size(300)]
        public String Line5
        {
            get => _Line5;
            set => SetPropertyValue(nameof(Line5), ref _Line5, value);
        }  
        private String _City;
        [Size(300)]
        public String City
        {
            get => _City;
            set => SetPropertyValue(nameof(City), ref _City, value);
        }  
        private String _State;
        [Size(300)]
        public String State
        {
            get => _State;
            set => SetPropertyValue(nameof(State), ref _State, value);
        }  
        private String _PostalCode;
        [Size(300)]
        public String PostalCode
        {
            get => _PostalCode;
            set => SetPropertyValue(nameof(PostalCode), ref _PostalCode, value);
        }  
        private String _Country;
        [Size(300)]
        public String Country
        {
            get => _Country;
            set => SetPropertyValue(nameof(Country), ref _Country, value);
        }  
        private String _Note;
        [Size(300)]
        public String Note
        {
            get => _Note;
            set => SetPropertyValue(nameof(Note), ref _Note, value);
        }  
        private String _CustomFields;
        [Size(300)]
        public String CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String _ExpenseLineId;
        [Size(300)]
        public String ExpenseLineId
        {
            get => _ExpenseLineId;
            set => SetPropertyValue(nameof(ExpenseLineId), ref _ExpenseLineId, value);
        }  
        private String _ExpenseLineNumber;
        [Size(300)]
        public String ExpenseLineNumber
        {
            get => _ExpenseLineNumber;
            set => SetPropertyValue(nameof(ExpenseLineNumber), ref _ExpenseLineNumber, value);
        }  
        private String _ExpenseAccount;
        [Size(300)]
        public String ExpenseAccount
        {
            get => _ExpenseAccount;
            set => SetPropertyValue(nameof(ExpenseAccount), ref _ExpenseAccount, value);
        }  
        private String _ExpenseAccountId;
        [Size(300)]
        public String ExpenseAccountId
        {
            get => _ExpenseAccountId;
            set => SetPropertyValue(nameof(ExpenseAccountId), ref _ExpenseAccountId, value);
        }  
        private Decimal? _ExpenseAmount;
        public Decimal? ExpenseAmount
        {
            get => _ExpenseAmount;
            set => SetPropertyValue(nameof(ExpenseAmount), ref _ExpenseAmount, value);
        }  
        private String _ExpenseBillableStatus;
        [Size(300)]
        public String ExpenseBillableStatus
        {
            get => _ExpenseBillableStatus;
            set => SetPropertyValue(nameof(ExpenseBillableStatus), ref _ExpenseBillableStatus, value);
        }  
        private String _ExpenseCustomer;
        [Size(300)]
        public String ExpenseCustomer
        {
            get => _ExpenseCustomer;
            set => SetPropertyValue(nameof(ExpenseCustomer), ref _ExpenseCustomer, value);
        }  
        private String _ExpenseCustomerId;
        [Size(300)]
        public String ExpenseCustomerId
        {
            get => _ExpenseCustomerId;
            set => SetPropertyValue(nameof(ExpenseCustomerId), ref _ExpenseCustomerId, value);
        }  
        private String _ExpenseClass;
        [Size(300)]
        public String ExpenseClass
        {
            get => _ExpenseClass;
            set => SetPropertyValue(nameof(ExpenseClass), ref _ExpenseClass, value);
        }  
        private String _ExpenseClassId;
        [Size(300)]
        public String ExpenseClassId
        {
            get => _ExpenseClassId;
            set => SetPropertyValue(nameof(ExpenseClassId), ref _ExpenseClassId, value);
        }  
        private String _ExpenseTaxCode;
        [Size(300)]
        public String ExpenseTaxCode
        {
            get => _ExpenseTaxCode;
            set => SetPropertyValue(nameof(ExpenseTaxCode), ref _ExpenseTaxCode, value);
        }  
        private String _ExpenseTaxCodeId;
        [Size(300)]
        public String ExpenseTaxCodeId
        {
            get => _ExpenseTaxCodeId;
            set => SetPropertyValue(nameof(ExpenseTaxCodeId), ref _ExpenseTaxCodeId, value);
        }  
        private String _ExpenseMemo;
        [Size(300)]
        public String ExpenseMemo
        {
            get => _ExpenseMemo;
            set => SetPropertyValue(nameof(ExpenseMemo), ref _ExpenseMemo, value);
        }  
        private String _ExpenseCustomFields;
        [Size(300)]
        public String ExpenseCustomFields
        {
            get => _ExpenseCustomFields;
            set => SetPropertyValue(nameof(ExpenseCustomFields), ref _ExpenseCustomFields, value);
        }  
        private Boolean? _IsToBePrinted;
        public Boolean? IsToBePrinted
        {
            get => _IsToBePrinted;
            set => SetPropertyValue(nameof(IsToBePrinted), ref _IsToBePrinted, value);
        }  
        private Boolean? _IsTaxIncluded;
        public Boolean? IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
        }  
        private String _CurrencyName;
        [Size(300)]
        public String CurrencyName
        {
            get => _CurrencyName;
            set => SetPropertyValue(nameof(CurrencyName), ref _CurrencyName, value);
        }  
        private String _CurrencyId;
        [Size(300)]
        public String CurrencyId
        {
            get => _CurrencyId;
            set => SetPropertyValue(nameof(CurrencyId), ref _CurrencyId, value);
        }  
        private Single? _ExchangeRate;
        public Single? ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private DateTime? _TimeModified;
        public DateTime? TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private DateTime? _TimeCreated;
        public DateTime? TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }
        public const string QueryableProperties="Id,CheckId,ReferenceNumber,TxnNumber,Account,AccountId,Payee,PayeeId,Date,Amount,Memo,Address,Line1,Line2,Line3,Line4,Line5,City,State,PostalCode,Country,Note,CustomFields,ExpenseLineId,ExpenseLineNumber,ExpenseAccount,ExpenseAccountId,ExpenseAmount,ExpenseBillableStatus,ExpenseCustomer,ExpenseCustomerId,ExpenseClass,ExpenseClassId,ExpenseTaxCode,ExpenseTaxCodeId,ExpenseMemo,ExpenseCustomFields,IsToBePrinted,IsTaxIncluded,CurrencyName,CurrencyId,ExchangeRate,TimeModified,TimeCreated";
    }
}