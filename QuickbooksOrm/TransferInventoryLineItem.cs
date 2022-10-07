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
    public class TransferInventoryLineItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public TransferInventoryLineItem(Session session)
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
        private String _TransferInventoryId;
        [Size(300)]
        public String TransferInventoryId
        {
            get => _TransferInventoryId;
            set => SetPropertyValue(nameof(TransferInventoryId), ref _TransferInventoryId, value);
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
        private String _TransferInventoryLineRetTxnLineId;
        [Size(300)]
        public String TransferInventoryLineRetTxnLineId
        {
            get => _TransferInventoryLineRetTxnLineId;
            set => SetPropertyValue(nameof(TransferInventoryLineRetTxnLineId), ref _TransferInventoryLineRetTxnLineId, value);
        }  
        private String _TransferInventoryLineRetItemRefListId;
        [Size(300)]
        public String TransferInventoryLineRetItemRefListId
        {
            get => _TransferInventoryLineRetItemRefListId;
            set => SetPropertyValue(nameof(TransferInventoryLineRetItemRefListId), ref _TransferInventoryLineRetItemRefListId, value);
        }  
        private String _TransferInventoryLineRetItemRefFullName;
        [Size(300)]
        public String TransferInventoryLineRetItemRefFullName
        {
            get => _TransferInventoryLineRetItemRefFullName;
            set => SetPropertyValue(nameof(TransferInventoryLineRetItemRefFullName), ref _TransferInventoryLineRetItemRefFullName, value);
        }  
        private String _TransferInventoryLineRetFromInventorySiteLocationRefListId;
        [Size(300)]
        public String TransferInventoryLineRetFromInventorySiteLocationRefListId
        {
            get => _TransferInventoryLineRetFromInventorySiteLocationRefListId;
            set => SetPropertyValue(nameof(TransferInventoryLineRetFromInventorySiteLocationRefListId), ref _TransferInventoryLineRetFromInventorySiteLocationRefListId, value);
        }  
        private String _TransferInventoryLineRetFromInventorySiteLocationRefFullName;
        [Size(300)]
        public String TransferInventoryLineRetFromInventorySiteLocationRefFullName
        {
            get => _TransferInventoryLineRetFromInventorySiteLocationRefFullName;
            set => SetPropertyValue(nameof(TransferInventoryLineRetFromInventorySiteLocationRefFullName), ref _TransferInventoryLineRetFromInventorySiteLocationRefFullName, value);
        }  
        private String _TransferInventoryLineRetToInventorySiteLocationRefListId;
        [Size(300)]
        public String TransferInventoryLineRetToInventorySiteLocationRefListId
        {
            get => _TransferInventoryLineRetToInventorySiteLocationRefListId;
            set => SetPropertyValue(nameof(TransferInventoryLineRetToInventorySiteLocationRefListId), ref _TransferInventoryLineRetToInventorySiteLocationRefListId, value);
        }  
        private String _TransferInventoryLineRetToInventorySiteLocationRefFullName;
        [Size(300)]
        public String TransferInventoryLineRetToInventorySiteLocationRefFullName
        {
            get => _TransferInventoryLineRetToInventorySiteLocationRefFullName;
            set => SetPropertyValue(nameof(TransferInventoryLineRetToInventorySiteLocationRefFullName), ref _TransferInventoryLineRetToInventorySiteLocationRefFullName, value);
        }  
        private Single? _TransferInventoryLineRetQuantityToTransfer;
        public Single? TransferInventoryLineRetQuantityToTransfer
        {
            get => _TransferInventoryLineRetQuantityToTransfer;
            set => SetPropertyValue(nameof(TransferInventoryLineRetQuantityToTransfer), ref _TransferInventoryLineRetQuantityToTransfer, value);
        }  
        private Single? _TransferInventoryLineRetQuantityTransferred;
        public Single? TransferInventoryLineRetQuantityTransferred
        {
            get => _TransferInventoryLineRetQuantityTransferred;
            set => SetPropertyValue(nameof(TransferInventoryLineRetQuantityTransferred), ref _TransferInventoryLineRetQuantityTransferred, value);
        }  
        private String _TransferInventoryLineRetSerialNumber;
        [Size(300)]
        public String TransferInventoryLineRetSerialNumber
        {
            get => _TransferInventoryLineRetSerialNumber;
            set => SetPropertyValue(nameof(TransferInventoryLineRetSerialNumber), ref _TransferInventoryLineRetSerialNumber, value);
        }  
        private String _TransferInventoryLineRetLotNumber;
        [Size(300)]
        public String TransferInventoryLineRetLotNumber
        {
            get => _TransferInventoryLineRetLotNumber;
            set => SetPropertyValue(nameof(TransferInventoryLineRetLotNumber), ref _TransferInventoryLineRetLotNumber, value);
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
        public const string QueryableProperties="Id,TransferInventoryId,TxnDate,TxnNumber,RefNumber,FromInventorySiteRefListId,FromInventorySiteRefFullName,ToInventorySiteRefListId,ToInventorySiteRefFullName,Memo,ExternalGuid,TransferInventoryLineRetTxnLineId,TransferInventoryLineRetItemRefListId,TransferInventoryLineRetItemRefFullName,TransferInventoryLineRetFromInventorySiteLocationRefListId,TransferInventoryLineRetFromInventorySiteLocationRefFullName,TransferInventoryLineRetToInventorySiteLocationRefListId,TransferInventoryLineRetToInventorySiteLocationRefFullName,TransferInventoryLineRetQuantityToTransfer,TransferInventoryLineRetQuantityTransferred,TransferInventoryLineRetSerialNumber,TransferInventoryLineRetLotNumber,TimeCreated,TimeModified,EditSequence";
    }
}