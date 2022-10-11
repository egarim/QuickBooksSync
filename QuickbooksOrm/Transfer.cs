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
    public class Transfer : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Transfer(Session session)
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
        private String _TxnNumber;
        [Size(300)]
        public String TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private DateTime? _TxnDate;
        public DateTime? TxnDate
        {
            get => _TxnDate;
            set => SetPropertyValue(nameof(TxnDate), ref _TxnDate, value);
        }  
        private String _TransferFromAccountRefListId;
        [Size(300)]
        public String TransferFromAccountRefListId
        {
            get => _TransferFromAccountRefListId;
            set => SetPropertyValue(nameof(TransferFromAccountRefListId), ref _TransferFromAccountRefListId, value);
        }  
        private String _TransferFromAccountRefFullName;
        [Size(300)]
        public String TransferFromAccountRefFullName
        {
            get => _TransferFromAccountRefFullName;
            set => SetPropertyValue(nameof(TransferFromAccountRefFullName), ref _TransferFromAccountRefFullName, value);
        }  
        private Single? _FromAccountBalance;
        public Single? FromAccountBalance
        {
            get => _FromAccountBalance;
            set => SetPropertyValue(nameof(FromAccountBalance), ref _FromAccountBalance, value);
        }  
        private String _TransferToAccountRefListId;
        [Size(300)]
        public String TransferToAccountRefListId
        {
            get => _TransferToAccountRefListId;
            set => SetPropertyValue(nameof(TransferToAccountRefListId), ref _TransferToAccountRefListId, value);
        }  
        private String _TransferToAccountRefFullName;
        [Size(300)]
        public String TransferToAccountRefFullName
        {
            get => _TransferToAccountRefFullName;
            set => SetPropertyValue(nameof(TransferToAccountRefFullName), ref _TransferToAccountRefFullName, value);
        }  
        private Single? _ToAccountBalance;
        public Single? ToAccountBalance
        {
            get => _ToAccountBalance;
            set => SetPropertyValue(nameof(ToAccountBalance), ref _ToAccountBalance, value);
        }  
        private String _ClassRefListId;
        [Size(300)]
        public String ClassRefListId
        {
            get => _ClassRefListId;
            set => SetPropertyValue(nameof(ClassRefListId), ref _ClassRefListId, value);
        }  
        private String _ClassRefFullName;
        [Size(300)]
        public String ClassRefFullName
        {
            get => _ClassRefFullName;
            set => SetPropertyValue(nameof(ClassRefFullName), ref _ClassRefFullName, value);
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
        private DateTime? _TimeCreated;
        public DateTime? TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private DateTime? _TimeModified;
        public DateTime? TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private String _EditSequence;
        [Size(300)]
        public String EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }
        public const string QueryableProperties="Id,TxnNumber,TxnDate,TransferFromAccountRefListId,TransferFromAccountRefFullName,FromAccountBalance,TransferToAccountRefListId,TransferToAccountRefFullName,ToAccountBalance,ClassRefListId,ClassRefFullName,Amount,Memo,TimeCreated,TimeModified,EditSequence";
        public const string QuickbooksTableName="Transfers";
    }
}