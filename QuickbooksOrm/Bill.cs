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
    public class Bill : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Bill(Session session)
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
        private String? _ReferenceNumber;
        public String? ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
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
        private Int32 _TxnNumber;
        public Int32 TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private DateTime _DueDate;
        public DateTime DueDate
        {
            get => _DueDate;
            set => SetPropertyValue(nameof(DueDate), ref _DueDate, value);
        }  
        private String? _Terms;
        public String? Terms
        {
            get => _Terms;
            set => SetPropertyValue(nameof(Terms), ref _Terms, value);
        }  
        private String? _TermsId;
        public String? TermsId
        {
            get => _TermsId;
            set => SetPropertyValue(nameof(TermsId), ref _TermsId, value);
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
        private Boolean _IsPaid;
        public Boolean IsPaid
        {
            get => _IsPaid;
            set => SetPropertyValue(nameof(IsPaid), ref _IsPaid, value);
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
        private Int32 _ItemCount;
        public Int32 ItemCount
        {
            get => _ItemCount;
            set => SetPropertyValue(nameof(ItemCount), ref _ItemCount, value);
        }  
        private String? _ItemAggregate;
        public String? ItemAggregate
        {
            get => _ItemAggregate;
            set => SetPropertyValue(nameof(ItemAggregate), ref _ItemAggregate, value);
        }  
        private Int32 _ExpenseItemCount;
        public Int32 ExpenseItemCount
        {
            get => _ExpenseItemCount;
            set => SetPropertyValue(nameof(ExpenseItemCount), ref _ExpenseItemCount, value);
        }  
        private String? _ExpenseItemAggregate;
        public String? ExpenseItemAggregate
        {
            get => _ExpenseItemAggregate;
            set => SetPropertyValue(nameof(ExpenseItemAggregate), ref _ExpenseItemAggregate, value);
        }  
        private Int32 _TransactionCount;
        public Int32 TransactionCount
        {
            get => _TransactionCount;
            set => SetPropertyValue(nameof(TransactionCount), ref _TransactionCount, value);
        }  
        private String? _TransactionAggregate;
        public String? TransactionAggregate
        {
            get => _TransactionAggregate;
            set => SetPropertyValue(nameof(TransactionAggregate), ref _TransactionAggregate, value);
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
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
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
        private Decimal _OpenAmount;
        public Decimal OpenAmount
        {
            get => _OpenAmount;
            set => SetPropertyValue(nameof(OpenAmount), ref _OpenAmount, value);
        }  
        private string _AccountsPayableNavigation;
        public string AccountsPayableNavigation
        {
            get => _AccountsPayableNavigation;
            set => SetPropertyValue(nameof(AccountsPayableNavigation), ref _AccountsPayableNavigation, value);
        }  
        private string _Currency;
        public string Currency
        {
            get => _Currency;
            set => SetPropertyValue(nameof(Currency), ref _Currency, value);
        }  
        private string _Vendor;
        public string Vendor
        {
            get => _Vendor;
            set => SetPropertyValue(nameof(Vendor), ref _Vendor, value);
        }
        public const string QueriableProperties="Id,VendorName,VendorId,ReferenceNumber,Date,Amount,TxnNumber,DueDate,Terms,TermsId,AccountsPayable,AccountsPayableId,Memo,IsPaid,ExchangeRate,IsTaxIncluded,ItemCount,ItemAggregate,ExpenseItemCount,ExpenseItemAggregate,TransactionCount,TransactionAggregate,CurrencyName,CurrencyId,CustomFields,TimeModified,TimeCreated,OpenAmount,AccountsPayableNavigation,Currency,Vendor";
    }
}