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
        private Int32 _TxnNumber;
        public Int32 TxnNumber
        {
            get => _TxnNumber;
            set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
        }  
        private String? _ReferenceNumber;
        public String? ReferenceNumber
        {
            get => _ReferenceNumber;
            set => SetPropertyValue(nameof(ReferenceNumber), ref _ReferenceNumber, value);
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
        private String? _ItemName;
        public String? ItemName
        {
            get => _ItemName;
            set => SetPropertyValue(nameof(ItemName), ref _ItemName, value);
        }  
        private String? _ItemId;
        public String? ItemId
        {
            get => _ItemId;
            set => SetPropertyValue(nameof(ItemId), ref _ItemId, value);
        }  
        private Single _Quantity;
        public Single Quantity
        {
            get => _Quantity;
            set => SetPropertyValue(nameof(Quantity), ref _Quantity, value);
        }  
        private String? _UnitOfMeasure;
        public String? UnitOfMeasure
        {
            get => _UnitOfMeasure;
            set => SetPropertyValue(nameof(UnitOfMeasure), ref _UnitOfMeasure, value);
        }  
        private String? _OverrideUnitOfMeasure;
        public String? OverrideUnitOfMeasure
        {
            get => _OverrideUnitOfMeasure;
            set => SetPropertyValue(nameof(OverrideUnitOfMeasure), ref _OverrideUnitOfMeasure, value);
        }  
        private String? _OverrideUnitOfMeasureId;
        public String? OverrideUnitOfMeasureId
        {
            get => _OverrideUnitOfMeasureId;
            set => SetPropertyValue(nameof(OverrideUnitOfMeasureId), ref _OverrideUnitOfMeasureId, value);
        }  
        private Single _Rate;
        public Single Rate
        {
            get => _Rate;
            set => SetPropertyValue(nameof(Rate), ref _Rate, value);
        }  
        private Decimal _Amount;
        public Decimal Amount
        {
            get => _Amount;
            set => SetPropertyValue(nameof(Amount), ref _Amount, value);
        }  
        private Single _Balance;
        public Single Balance
        {
            get => _Balance;
            set => SetPropertyValue(nameof(Balance), ref _Balance, value);
        }  
        private String? _Description;
        public String? Description
        {
            get => _Description;
            set => SetPropertyValue(nameof(Description), ref _Description, value);
        }  
        private String? _AccountsReceivable;
        public String? AccountsReceivable
        {
            get => _AccountsReceivable;
            set => SetPropertyValue(nameof(AccountsReceivable), ref _AccountsReceivable, value);
        }  
        private String? _AccountsReceivableId;
        public String? AccountsReceivableId
        {
            get => _AccountsReceivableId;
            set => SetPropertyValue(nameof(AccountsReceivableId), ref _AccountsReceivableId, value);
        }  
        private String? _Class;
        public String? Class
        {
            get => _Class;
            set => SetPropertyValue(nameof(Class), ref _Class, value);
        }  
        private String? _ClassId;
        public String? ClassId
        {
            get => _ClassId;
            set => SetPropertyValue(nameof(ClassId), ref _ClassId, value);
        }  
        private DateTime _BilledDate;
        public DateTime BilledDate
        {
            get => _BilledDate;
            set => SetPropertyValue(nameof(BilledDate), ref _BilledDate, value);
        }  
        private DateTime _DueDate;
        public DateTime DueDate
        {
            get => _DueDate;
            set => SetPropertyValue(nameof(DueDate), ref _DueDate, value);
        }  
        private Boolean _IsPaid;
        public Boolean IsPaid
        {
            get => _IsPaid;
            set => SetPropertyValue(nameof(IsPaid), ref _IsPaid, value);
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
        private string _AccountsReceivableNavigation;
        public string AccountsReceivableNavigation
        {
            get => _AccountsReceivableNavigation;
            set => SetPropertyValue(nameof(AccountsReceivableNavigation), ref _AccountsReceivableNavigation, value);
        }  
        private string _ClassNavigation;
        public string ClassNavigation
        {
            get => _ClassNavigation;
            set => SetPropertyValue(nameof(ClassNavigation), ref _ClassNavigation, value);
        }  
        private string _Customer;
        public string Customer
        {
            get => _Customer;
            set => SetPropertyValue(nameof(Customer), ref _Customer, value);
        }  
        private string _Item;
        public string Item
        {
            get => _Item;
            set => SetPropertyValue(nameof(Item), ref _Item, value);
        }  
        private string _OverrideUnitOfMeasureNavigation;
        public string OverrideUnitOfMeasureNavigation
        {
            get => _OverrideUnitOfMeasureNavigation;
            set => SetPropertyValue(nameof(OverrideUnitOfMeasureNavigation), ref _OverrideUnitOfMeasureNavigation, value);
        }
        public const string QueriableProperties="Id,TxnNumber,ReferenceNumber,CustomerName,CustomerId,Date,ItemName,ItemId,Quantity,UnitOfMeasure,OverrideUnitOfMeasure,OverrideUnitOfMeasureId,Rate,Amount,Balance,Description,AccountsReceivable,AccountsReceivableId,Class,ClassId,BilledDate,DueDate,IsPaid,CustomFields,EditSequence,TimeModified,TimeCreated,AccountsReceivableNavigation,ClassNavigation,Customer,Item,OverrideUnitOfMeasureNavigation";
    }
}