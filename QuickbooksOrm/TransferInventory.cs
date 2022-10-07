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
    public class TransferInventory : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public TransferInventory(Session session)
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
        private DateTime? _TxnDate;
        public DateTime? TxnDate
        {
            get => _TxnDate;
            set => SetPropertyValue(nameof(TxnDate), ref _TxnDate, value);
        }  
        private Int32? _TxnNumber;
        public Int32? TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private String _RefNumber;
        [Size(300)]
        public String RefNumber
        {
            get => _RefNumber;
            set => SetPropertyValue(nameof(RefNumber), ref _RefNumber, value);
        }  
        private String _FromInventorySiteRefListId;
        [Size(300)]
        public String FromInventorySiteRefListId
        {
            get => _FromInventorySiteRefListId;
            set => SetPropertyValue(nameof(FromInventorySiteRefListId), ref _FromInventorySiteRefListId, value);
        }  
        private String _FromInventorySiteRefFullName;
        [Size(300)]
        public String FromInventorySiteRefFullName
        {
            get => _FromInventorySiteRefFullName;
            set => SetPropertyValue(nameof(FromInventorySiteRefFullName), ref _FromInventorySiteRefFullName, value);
        }  
        private String _ToInventorySiteRefListId;
        [Size(300)]
        public String ToInventorySiteRefListId
        {
            get => _ToInventorySiteRefListId;
            set => SetPropertyValue(nameof(ToInventorySiteRefListId), ref _ToInventorySiteRefListId, value);
        }  
        private String _ToInventorySiteRefFullName;
        [Size(300)]
        public String ToInventorySiteRefFullName
        {
            get => _ToInventorySiteRefFullName;
            set => SetPropertyValue(nameof(ToInventorySiteRefFullName), ref _ToInventorySiteRefFullName, value);
        }  
        private String _Memo;
        [Size(300)]
        public String Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
        }  
        private String _ExternalGuid;
        [Size(300)]
        public String ExternalGuid
        {
            get => _ExternalGuid;
            set => SetPropertyValue(nameof(ExternalGuid), ref _ExternalGuid, value);
        }  
        private String _TransferInventoryLineAggregate;
        [Size(300)]
        public String TransferInventoryLineAggregate
        {
            get => _TransferInventoryLineAggregate;
            set => SetPropertyValue(nameof(TransferInventoryLineAggregate), ref _TransferInventoryLineAggregate, value);
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
        public const string QueryableProperties="Id,TxnDate,TxnNumber,RefNumber,FromInventorySiteRefListId,FromInventorySiteRefFullName,ToInventorySiteRefListId,ToInventorySiteRefFullName,Memo,ExternalGuid,TransferInventoryLineAggregate,TimeCreated,TimeModified,EditSequence";
    }
}