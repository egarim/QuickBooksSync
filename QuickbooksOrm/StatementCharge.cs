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
    public class StatementCharge : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public StatementCharge(Session session)
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
        private Int32? _TxnNumber;
        public Int32? TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private String _ReferenceNumber;
        [Size(300)]
        public String ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
        }  
        private String _CustomerName;
        [Size(300)]
        public String CustomerName
        {
            get => _CustomerName;
            set => SetPropertyValue(nameof(CustomerName), ref _CustomerName, value);
        }  
        private String _CustomerId;
        [Size(300)]
        public String CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
        }  
        private DateTime? _Date;
        public DateTime? Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private String _ItemName;
        [Size(300)]
        public String ItemName
        {
            get => _ItemName;
            set => SetPropertyValue(nameof(ItemName), ref _ItemName, value);
        }  
        private String _ItemId;
        [Size(300)]
        public String ItemId
        {
            get => _ItemId;
            set => SetPropertyValue(nameof(ItemId), ref _ItemId, value);
        }  
        private Single? _Quantity;
        public Single? Quantity
        {
            get => _Quantity;
            set => SetPropertyValue(nameof(Quantity), ref _Quantity, value);
        }  
        private String _UnitOfMeasure;
        [Size(300)]
        public String UnitOfMeasure
        {
            get => _UnitOfMeasure;
            set => SetPropertyValue(nameof(UnitOfMeasure), ref _UnitOfMeasure, value);
        }  
        private String _OverrideUnitOfMeasure;
        [Size(300)]
        public String OverrideUnitOfMeasure
        {
            get => _OverrideUnitOfMeasure;
            set => SetPropertyValue(nameof(OverrideUnitOfMeasure), ref _OverrideUnitOfMeasure, value);
        }  
        private String _OverrideUnitOfMeasureId;
        [Size(300)]
        public String OverrideUnitOfMeasureId
        {
            get => _OverrideUnitOfMeasureId;
            set => SetPropertyValue(nameof(OverrideUnitOfMeasureId), ref _OverrideUnitOfMeasureId, value);
        }  
        private Single? _Rate;
        public Single? Rate
        {
            get => _Rate;
            set => SetPropertyValue(nameof(Rate), ref _Rate, value);
        }  
        private Decimal? _Amount;
        public Decimal? Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private Single? _Balance;
        public Single? Balance
        {
            get => _Balance;
            set => SetPropertyValue(nameof(Balance), ref _Balance, value);
        }  
        private String _Description;
        [Size(300)]
        public String Description
        {
            get => _Description;
            set => SetPropertyValue(nameof(Description), ref _Description, value);
        }  
        private String _AccountsReceivable;
        [Size(300)]
        public String AccountsReceivable
        {
            get => _AccountsReceivable;
            set => SetPropertyValue(nameof(AccountsReceivable), ref _AccountsReceivable, value);
        }  
        private String _AccountsReceivableId;
        [Size(300)]
        public String AccountsReceivableId
        {
            get => _AccountsReceivableId;
            set => SetPropertyValue(nameof(AccountsReceivableId), ref _AccountsReceivableId, value);
        }  
        private String _Class;
        [Size(300)]
        public String Class
        {
            get => _Class;
            set => SetPropertyValue(nameof(Class), ref _Class, value);
        }  
        private String _ClassId;
        [Size(300)]
        public String ClassId
        {
            get => _ClassId;
            set => SetPropertyValue(nameof(ClassId), ref _ClassId, value);
        }  
        private DateTime? _BilledDate;
        public DateTime? BilledDate
        {
            get => _BilledDate;
            set => SetPropertyValue(nameof(BilledDate), ref _BilledDate, value);
        }  
        private DateTime? _DueDate;
        public DateTime? DueDate
        {
            get => _DueDate;
            set => SetPropertyValue(nameof(DueDate), ref _DueDate, value);
        }  
        private Boolean? _IsPaid;
        public Boolean? IsPaid
        {
            get => _IsPaid;
            set => SetPropertyValue(nameof(IsPaid), ref _IsPaid, value);
        }  
        private String _CustomFields;
        [Size(300)]
        public String CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String _EditSequence;
        [Size(300)]
        public String EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
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
        public const string QueryableProperties="Id,TxnNumber,ReferenceNumber,CustomerName,CustomerId,Date,ItemName,ItemId,Quantity,UnitOfMeasure,OverrideUnitOfMeasure,OverrideUnitOfMeasureId,Rate,Amount,Balance,Description,AccountsReceivable,AccountsReceivableId,Class,ClassId,BilledDate,DueDate,IsPaid,CustomFields,EditSequence,TimeModified,TimeCreated";
    }
}