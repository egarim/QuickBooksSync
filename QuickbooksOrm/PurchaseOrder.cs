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
    public class PurchaseOrder : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public PurchaseOrder(Session session)
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
        private String _VendorName;
        [Size(300)]
        public String VendorName
        {
            get => _VendorName;
            set => SetPropertyValue(nameof(VendorName), ref _VendorName, value);
        }  
        private String _VendorId;
        [Size(300)]
        public String VendorId
        {
            get => _VendorId;
            set => SetPropertyValue(nameof(VendorId), ref _VendorId, value);
        }  
        private String _VendorMessage;
        [Size(300)]
        public String VendorMessage
        {
            get => _VendorMessage;
            set => SetPropertyValue(nameof(VendorMessage), ref _VendorMessage, value);
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
        private DateTime? _DueDate;
        public DateTime? DueDate
        {
            get => _DueDate;
            set => SetPropertyValue(nameof(DueDate), ref _DueDate, value);
        }  
        private String _ShipMethod;
        [Size(300)]
        public String ShipMethod
        {
            get => _ShipMethod;
            set => SetPropertyValue(nameof(ShipMethod), ref _ShipMethod, value);
        }  
        private String _ShipMethodId;
        [Size(300)]
        public String ShipMethodId
        {
            get => _ShipMethodId;
            set => SetPropertyValue(nameof(ShipMethodId), ref _ShipMethodId, value);
        }  
        private DateTime? _ExpectedDate;
        public DateTime? ExpectedDate
        {
            get => _ExpectedDate;
            set => SetPropertyValue(nameof(ExpectedDate), ref _ExpectedDate, value);
        }  
        private String _Memo;
        [Size(300)]
        public String Memo
        {
            get => _Memo;
            set => SetPropertyValue(nameof(Memo), ref _Memo, value);
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
        private String _Terms;
        [Size(300)]
        public String Terms
        {
            get => _Terms;
            set => SetPropertyValue(nameof(Terms), ref _Terms, value);
        }  
        private String _TermsId;
        [Size(300)]
        public String TermsId
        {
            get => _TermsId;
            set => SetPropertyValue(nameof(TermsId), ref _TermsId, value);
        }  
        private Decimal? _TotalAmount;
        public Decimal? TotalAmount
        {
            get => _TotalAmount;
            set => SetPropertyValue(nameof(TotalAmount), ref _TotalAmount, value);
        }  
        private String _Template;
        [Size(300)]
        public String Template
        {
            get => _Template;
            set => SetPropertyValue(nameof(Template), ref _Template, value);
        }  
        private String _TemplateId;
        [Size(300)]
        public String TemplateId
        {
            get => _TemplateId;
            set => SetPropertyValue(nameof(TemplateId), ref _TemplateId, value);
        }  
        private String _CurrencyName;
        [Size(300)]
        public String CurrencyName
        {
            get => _CurrencyName;
            set => SetPropertyValue(nameof(CurrencyName), ref _CurrencyName, value);
        }  
        private String _CurrencyId;
        [Size(300)]
        public String CurrencyId
        {
            get => _CurrencyId;
            set => SetPropertyValue(nameof(CurrencyId), ref _CurrencyId, value);
        }  
        private Int32? _ItemCount;
        public Int32? ItemCount
        {
            get => _ItemCount;
            set => SetPropertyValue(nameof(ItemCount), ref _ItemCount, value);
        }  
        private String _ItemAggregate;
        [Size(300)]
        public String ItemAggregate
        {
            get => _ItemAggregate;
            set => SetPropertyValue(nameof(ItemAggregate), ref _ItemAggregate, value);
        }  
        private Boolean? _IsFullyReceived;
        public Boolean? IsFullyReceived
        {
            get => _IsFullyReceived;
            set => SetPropertyValue(nameof(IsFullyReceived), ref _IsFullyReceived, value);
        }  
        private String _IsManuallyClosed;
        [Size(300)]
        public String IsManuallyClosed
        {
            get => _IsManuallyClosed;
            set => SetPropertyValue(nameof(IsManuallyClosed), ref _IsManuallyClosed, value);
        }  
        private Boolean? _IsToBePrinted;
        public Boolean? IsToBePrinted
        {
            get => _IsToBePrinted;
            set => SetPropertyValue(nameof(IsToBePrinted), ref _IsToBePrinted, value);
        }  
        private Boolean? _IsToBeEmailed;
        public Boolean? IsToBeEmailed
        {
            get => _IsToBeEmailed;
            set => SetPropertyValue(nameof(IsToBeEmailed), ref _IsToBeEmailed, value);
        }  
        private Boolean? _IsTaxIncluded;
        public Boolean? IsTaxIncluded
        {
            get => _IsTaxIncluded;
            set => SetPropertyValue(nameof(IsTaxIncluded), ref _IsTaxIncluded, value);
        }  
        private String _SalesTaxCodeName;
        [Size(300)]
        public String SalesTaxCodeName
        {
            get => _SalesTaxCodeName;
            set => SetPropertyValue(nameof(SalesTaxCodeName), ref _SalesTaxCodeName, value);
        }  
        private String _SalesTaxCodeId;
        [Size(300)]
        public String SalesTaxCodeId
        {
            get => _SalesTaxCodeId;
            set => SetPropertyValue(nameof(SalesTaxCodeId), ref _SalesTaxCodeId, value);
        }  
        private String _Fob;
        [Size(300)]
        public String Fob
        {
            get => _Fob;
            set => SetPropertyValue(nameof(Fob), ref _Fob, value);
        }  
        private String _VendorAddress;
        [Size(300)]
        public String VendorAddress
        {
            get => _VendorAddress;
            set => SetPropertyValue(nameof(VendorAddress), ref _VendorAddress, value);
        }  
        private String _VendorLine1;
        [Size(300)]
        public String VendorLine1
        {
            get => _VendorLine1;
            set => SetPropertyValue(nameof(VendorLine1), ref _VendorLine1, value);
        }  
        private String _VendorLine2;
        [Size(300)]
        public String VendorLine2
        {
            get => _VendorLine2;
            set => SetPropertyValue(nameof(VendorLine2), ref _VendorLine2, value);
        }  
        private String _VendorLine3;
        [Size(300)]
        public String VendorLine3
        {
            get => _VendorLine3;
            set => SetPropertyValue(nameof(VendorLine3), ref _VendorLine3, value);
        }  
        private String _VendorLine4;
        [Size(300)]
        public String VendorLine4
        {
            get => _VendorLine4;
            set => SetPropertyValue(nameof(VendorLine4), ref _VendorLine4, value);
        }  
        private String _VendorLine5;
        [Size(300)]
        public String VendorLine5
        {
            get => _VendorLine5;
            set => SetPropertyValue(nameof(VendorLine5), ref _VendorLine5, value);
        }  
        private String _VendorCity;
        [Size(300)]
        public String VendorCity
        {
            get => _VendorCity;
            set => SetPropertyValue(nameof(VendorCity), ref _VendorCity, value);
        }  
        private String _VendorState;
        [Size(300)]
        public String VendorState
        {
            get => _VendorState;
            set => SetPropertyValue(nameof(VendorState), ref _VendorState, value);
        }  
        private String _VendorPostalCode;
        [Size(300)]
        public String VendorPostalCode
        {
            get => _VendorPostalCode;
            set => SetPropertyValue(nameof(VendorPostalCode), ref _VendorPostalCode, value);
        }  
        private String _VendorCountry;
        [Size(300)]
        public String VendorCountry
        {
            get => _VendorCountry;
            set => SetPropertyValue(nameof(VendorCountry), ref _VendorCountry, value);
        }  
        private String _VendorNote;
        [Size(300)]
        public String VendorNote
        {
            get => _VendorNote;
            set => SetPropertyValue(nameof(VendorNote), ref _VendorNote, value);
        }  
        private String _ShipToEntityName;
        [Size(300)]
        public String ShipToEntityName
        {
            get => _ShipToEntityName;
            set => SetPropertyValue(nameof(ShipToEntityName), ref _ShipToEntityName, value);
        }  
        private String _ShipToEntityId;
        [Size(300)]
        public String ShipToEntityId
        {
            get => _ShipToEntityId;
            set => SetPropertyValue(nameof(ShipToEntityId), ref _ShipToEntityId, value);
        }  
        private String _ShippingAddress;
        [Size(300)]
        public String ShippingAddress
        {
            get => _ShippingAddress;
            set => SetPropertyValue(nameof(ShippingAddress), ref _ShippingAddress, value);
        }  
        private String _ShippingLine1;
        [Size(300)]
        public String ShippingLine1
        {
            get => _ShippingLine1;
            set => SetPropertyValue(nameof(ShippingLine1), ref _ShippingLine1, value);
        }  
        private String _ShippingLine2;
        [Size(300)]
        public String ShippingLine2
        {
            get => _ShippingLine2;
            set => SetPropertyValue(nameof(ShippingLine2), ref _ShippingLine2, value);
        }  
        private String _ShippingLine3;
        [Size(300)]
        public String ShippingLine3
        {
            get => _ShippingLine3;
            set => SetPropertyValue(nameof(ShippingLine3), ref _ShippingLine3, value);
        }  
        private String _ShippingLine4;
        [Size(300)]
        public String ShippingLine4
        {
            get => _ShippingLine4;
            set => SetPropertyValue(nameof(ShippingLine4), ref _ShippingLine4, value);
        }  
        private String _ShippingLine5;
        [Size(300)]
        public String ShippingLine5
        {
            get => _ShippingLine5;
            set => SetPropertyValue(nameof(ShippingLine5), ref _ShippingLine5, value);
        }  
        private String _ShippingCity;
        [Size(300)]
        public String ShippingCity
        {
            get => _ShippingCity;
            set => SetPropertyValue(nameof(ShippingCity), ref _ShippingCity, value);
        }  
        private String _ShippingState;
        [Size(300)]
        public String ShippingState
        {
            get => _ShippingState;
            set => SetPropertyValue(nameof(ShippingState), ref _ShippingState, value);
        }  
        private String _ShippingPostalCode;
        [Size(300)]
        public String ShippingPostalCode
        {
            get => _ShippingPostalCode;
            set => SetPropertyValue(nameof(ShippingPostalCode), ref _ShippingPostalCode, value);
        }  
        private String _ShippingCountry;
        [Size(300)]
        public String ShippingCountry
        {
            get => _ShippingCountry;
            set => SetPropertyValue(nameof(ShippingCountry), ref _ShippingCountry, value);
        }  
        private String _ShippingNote;
        [Size(300)]
        public String ShippingNote
        {
            get => _ShippingNote;
            set => SetPropertyValue(nameof(ShippingNote), ref _ShippingNote, value);
        }  
        private Single? _ExchangeRate;
        public Single? ExchangeRate
        {
            get => _ExchangeRate;
            set => SetPropertyValue(nameof(ExchangeRate), ref _ExchangeRate, value);
        }  
        private String _Other1;
        [Size(300)]
        public String Other1
        {
            get => _Other1;
            set => SetPropertyValue(nameof(Other1), ref _Other1, value);
        }  
        private String _Other2;
        [Size(300)]
        public String Other2
        {
            get => _Other2;
            set => SetPropertyValue(nameof(Other2), ref _Other2, value);
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
        public const string QueryableProperties="Id,VendorName,VendorId,VendorMessage,ReferenceNumber,TxnNumber,Date,DueDate,ShipMethod,ShipMethodId,ExpectedDate,Memo,Class,ClassId,Terms,TermsId,TotalAmount,Template,TemplateId,CurrencyName,CurrencyId,ItemCount,ItemAggregate,IsFullyReceived,IsManuallyClosed,IsToBePrinted,IsToBeEmailed,IsTaxIncluded,SalesTaxCodeName,SalesTaxCodeId,Fob,VendorAddress,VendorLine1,VendorLine2,VendorLine3,VendorLine4,VendorLine5,VendorCity,VendorState,VendorPostalCode,VendorCountry,VendorNote,ShipToEntityName,ShipToEntityId,ShippingAddress,ShippingLine1,ShippingLine2,ShippingLine3,ShippingLine4,ShippingLine5,ShippingCity,ShippingState,ShippingPostalCode,ShippingCountry,ShippingNote,ExchangeRate,Other1,Other2,CustomFields,EditSequence,TimeModified,TimeCreated";
    }
}