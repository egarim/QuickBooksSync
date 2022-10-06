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
    public class ItemReceiptLinkedTransaction : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ItemReceiptLinkedTransaction(Session session)
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
        private Single _ExchangeRate;
        public Single ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private String? _TransactionId;
        public String? TransactionId
        {
            get => _TransactionId;
            set => SetPropertyValue(nameof(TransactionId), ref _TransactionId, value);
        }  
        private Decimal _TransactionAmount;
        public Decimal TransactionAmount
        {
            get => _TransactionAmount;
            set => SetPropertyValue(nameof(TransactionAmount), ref _TransactionAmount, value);
        }  
        private DateTime _TransactionDate;
        public DateTime TransactionDate
        {
            get => _TransactionDate;
            set => SetPropertyValue(nameof(TransactionDate), ref _TransactionDate, value);
        }  
        private String? _TransactionReferenceNumber;
        public String? TransactionReferenceNumber
        {
            get => _TransactionReferenceNumber;
            set => SetPropertyValue(nameof(TransactionReferenceNumber), ref _TransactionReferenceNumber, value);
        }  
        private String? _TransactionType;
        public String? TransactionType
        {
            get => _TransactionType;
            set => SetPropertyValue(nameof(TransactionType), ref _TransactionType, value);
        }  
        private String? _TransactionLinkType;
        public String? TransactionLinkType
        {
            get => _TransactionLinkType;
            set => SetPropertyValue(nameof(TransactionLinkType), ref _TransactionLinkType, value);
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
        private string _ItemReceipt;
        public string ItemReceipt
        {
            get => _ItemReceipt;
            set => SetPropertyValue(nameof(ItemReceipt), ref _ItemReceipt, value);
        }  
        private string _Transaction;
        public string Transaction
        {
            get => _Transaction;
            set => SetPropertyValue(nameof(Transaction), ref _Transaction, value);
        }  
        private string _Vendor;
        public string Vendor
        {
            get => _Vendor;
            set => SetPropertyValue(nameof(Vendor), ref _Vendor, value);
        }
        public const string QueriableProperties="Id,ItemReceiptId,VendorName,VendorId,Date,ReferenceNumber,AccountsPayable,AccountsPayableId,Memo,Amount,TxnNumber,ExchangeRate,TransactionId,TransactionAmount,TransactionDate,TransactionReferenceNumber,TransactionType,TransactionLinkType,CustomFields,EditSequence,TimeModified,TimeCreated,AccountsPayableNavigation,ItemReceipt,Transaction,Vendor";
    }
}