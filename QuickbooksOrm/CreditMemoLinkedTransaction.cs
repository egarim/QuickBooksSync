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
    public class CreditMemoLinkedTransaction : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CreditMemoLinkedTransaction(Session session)
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
        private String _CreditMemoId;
        [Size(300)]
        public String CreditMemoId
        {
            get => _CreditMemoId;
            set => SetPropertyValue(nameof(CreditMemoId), ref _CreditMemoId, value);
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
        private DateTime? _Date;
        public DateTime? Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private String _CustomerId;
        [Size(300)]
        public String CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
        }  
        private String _CustomerName;
        [Size(300)]
        public String CustomerName
        {
            get => _CustomerName;
            set => SetPropertyValue(nameof(CustomerName), ref _CustomerName, value);
        }  
        private String _TransactionId;
        [Size(300)]
        public String TransactionId
        {
            get => _TransactionId;
            set => SetPropertyValue(nameof(TransactionId), ref _TransactionId, value);
        }  
        private Decimal? _TransactionAmount;
        public Decimal? TransactionAmount
        {
            get => _TransactionAmount;
            set => SetPropertyValue(nameof(TransactionAmount), ref _TransactionAmount, value);
        }  
        private DateTime? _TransactionDate;
        public DateTime? TransactionDate
        {
            get => _TransactionDate;
            set => SetPropertyValue(nameof(TransactionDate), ref _TransactionDate, value);
        }  
        private String _TransactionReferenceNumber;
        [Size(300)]
        public String TransactionReferenceNumber
        {
            get => _TransactionReferenceNumber;
            set => SetPropertyValue(nameof(TransactionReferenceNumber), ref _TransactionReferenceNumber, value);
        }  
        private String _TransactionType;
        [Size(300)]
        public String TransactionType
        {
            get => _TransactionType;
            set => SetPropertyValue(nameof(TransactionType), ref _TransactionType, value);
        }  
        private String _TransactionLinkType;
        [Size(300)]
        public String TransactionLinkType
        {
            get => _TransactionLinkType;
            set => SetPropertyValue(nameof(TransactionLinkType), ref _TransactionLinkType, value);
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
        public const string QueryableProperties="Id,CreditMemoId,ReferenceNumber,TxnNumber,Date,CustomerId,CustomerName,TransactionId,TransactionAmount,TransactionDate,TransactionReferenceNumber,TransactionType,TransactionLinkType,TimeModified,TimeCreated";
    }
}