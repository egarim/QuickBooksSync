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
    public class ItemReceiptExpenseItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ItemReceiptExpenseItem(Session session)
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
        private String? _ItemReceiptId;
        public String? ItemReceiptId
        {
            get => _ItemReceiptId;
            set => SetPropertyValue(nameof(ItemReceiptId), ref _ItemReceiptId, value);
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
        private String? _Memo;
        public String? Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private String? _Amount;
        public String? Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private Int32 _TxnNumber;
        public Int32 TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private Single _ExchangeRate;
        public Single ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private Boolean _IsTaxIncluded;
        public Boolean IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
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
        private String? _ExpenseCustomFields;
        public String? ExpenseCustomFields
        {
            get => _ExpenseCustomFields;
            set => SetPropertyValue(nameof(ExpenseCustomFields), ref _ExpenseCustomFields, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String? _EditSequence;
        public String? EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
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
        private string _ItemReceipt;
        public string ItemReceipt
        {
            get => _ItemReceipt;
            set => SetPropertyValue(nameof(ItemReceipt), ref _ItemReceipt, value);
        }  
        private string _Vendor;
        public string Vendor
        {
            get => _Vendor;
            set => SetPropertyValue(nameof(Vendor), ref _Vendor, value);
        }
        public const string QueriableProperties="Id,ItemReceiptId,VendorName,VendorId,Date,ReferenceNumber,AccountsPayable,AccountsPayableId,Memo,Amount,TxnNumber,ExchangeRate,IsTaxIncluded,ExpenseLineId,ExpenseLineNumber,ExpenseAccount,ExpenseAccountId,ExpenseAmount,ExpenseBillableStatus,ExpenseCustomer,ExpenseCustomerId,ExpenseClass,ExpenseClassId,ExpenseTaxCode,ExpenseTaxCodeId,ExpenseCustomFields,CustomFields,EditSequence,TimeModified,TimeCreated,AccountsPayableNavigation,ExpenseAccountNavigation,ExpenseClassNavigation,ExpenseCustomerNavigation,ExpenseTaxCodeNavigation,ItemReceipt,Vendor";
    }
}