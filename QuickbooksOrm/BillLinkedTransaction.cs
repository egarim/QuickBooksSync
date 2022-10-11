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
    [NavigationItem("Quickbooks Data")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class BillLinkedTransaction : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public BillLinkedTransaction(Session session)
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
        private String _BillId;
        [Size(300)]
        public String BillId
        {
            get => _BillId;
            set => SetPropertyValue(nameof(BillId), ref _BillId, value);
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
        public const string QueryableProperties="Id,BillId,TransactionId,TransactionAmount,TransactionDate,TransactionReferenceNumber,TransactionType,TransactionLinkType,TimeModified,TimeCreated";
        public const string QuickbooksTableName="BillLinkedTransactions";
    }
}