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
    public class SalesOrderLinkedTransaction : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public SalesOrderLinkedTransaction(Session session)
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
        private String? _SalesOrderId;
        public String? SalesOrderId
        {
            get => _SalesOrderId;
            set => SetPropertyValue(nameof(SalesOrderId), ref _SalesOrderId, value);
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
        private String? _CustomerName;
        public String? CustomerName
        {
            get => _CustomerName;
            set => SetPropertyValue(nameof(CustomerName), ref _CustomerName, value);
        }  
        private String? _CustomerId;
        public String? CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
        }  
        private DateTime _Date;
        public DateTime Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
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
        private string _Customer;
        public string Customer
        {
            get => _Customer;
            set => SetPropertyValue(nameof(Customer), ref _Customer, value);
        }  
        private string _SalesOrder;
        public string SalesOrder
        {
            get => _SalesOrder;
            set => SetPropertyValue(nameof(SalesOrder), ref _SalesOrder, value);
        }  
        private string _Transaction;
        public string Transaction
        {
            get => _Transaction;
            set => SetPropertyValue(nameof(Transaction), ref _Transaction, value);
        }
       
    }
}