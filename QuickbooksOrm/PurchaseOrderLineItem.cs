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
    public class PurchaseOrderLineItem : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public PurchaseOrderLineItem(Session session)
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
        private String _PurchaseOrderId;
        [Size(300)]
        public String PurchaseOrderId
        {
            get => _PurchaseOrderId;
            set => SetPropertyValue(nameof(PurchaseOrderId), ref _PurchaseOrderId, value);
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
        private String _CustomFields;
        [Size(300)]
        public String CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private String _ItemLineId;
        [Size(300)]
        public String ItemLineId
        {
            get => _ItemLineId;
            set => SetPropertyValue(nameof(ItemLineId), ref _ItemLineId, value);
        }  
        private String _ItemLineNumber;
        [Size(300)]
        public String ItemLineNumber
        {
            get => _ItemLineNumber;
            set => SetPropertyValue(nameof(ItemLineNumber), ref _ItemLineNumber, value);
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
        private String _ItemGroup;
        [Size(300)]
        public String ItemGroup
        {
            get => _ItemGroup;
            set => SetPropertyValue(nameof(ItemGroup), ref _ItemGroup, value);
        }  
        private String _ItemGroupId;
        [Size(300)]
        public String ItemGroupId
        {
            get => _ItemGroupId;
            set => SetPropertyValue(nameof(ItemGroupId), ref _ItemGroupId, value);
        }  
        private String _ItemDescription;
        [Size(300)]
        public String ItemDescription
        {
            get => _ItemDescription;
            set => SetPropertyValue(nameof(ItemDescription), ref _ItemDescription, value);
        }  
        private String _ItemCustomer;
        [Size(300)]
        public String ItemCustomer
        {
            get => _ItemCustomer;
            set => SetPropertyValue(nameof(ItemCustomer), ref _ItemCustomer, value);
        }  
        private String _ItemCustomerId;
        [Size(300)]
        public String ItemCustomerId
        {
            get => _ItemCustomerId;
            set => SetPropertyValue(nameof(ItemCustomerId), ref _ItemCustomerId, value);
        }  
        private String _ItemUnitOfMeasure;
        [Size(300)]
        public String ItemUnitOfMeasure
        {
            get => _ItemUnitOfMeasure;
            set => SetPropertyValue(nameof(ItemUnitOfMeasure), ref _ItemUnitOfMeasure, value);
        }  
        private Single? _ItemQuantity;
        public Single? ItemQuantity
        {
            get => _ItemQuantity;
            set => SetPropertyValue(nameof(ItemQuantity), ref _ItemQuantity, value);
        }  
        private Single? _ItemRate;
        public Single? ItemRate
        {
            get => _ItemRate;
            set => SetPropertyValue(nameof(ItemRate), ref _ItemRate, value);
        }  
        private Decimal? _ItemAmount;
        public Decimal? ItemAmount
        {
            get => _ItemAmount;
            set => SetPropertyValue(nameof(ItemAmount), ref _ItemAmount, value);
        }  
        private Single? _ItemReceivedQuantity;
        public Single? ItemReceivedQuantity
        {
            get => _ItemReceivedQuantity;
            set => SetPropertyValue(nameof(ItemReceivedQuantity), ref _ItemReceivedQuantity, value);
        }  
        private String _ItemClass;
        [Size(300)]
        public String ItemClass
        {
            get => _ItemClass;
            set => SetPropertyValue(nameof(ItemClass), ref _ItemClass, value);
        }  
        private String _ItemClassId;
        [Size(300)]
        public String ItemClassId
        {
            get => _ItemClassId;
            set => SetPropertyValue(nameof(ItemClassId), ref _ItemClassId, value);
        }  
        private String _ItemInventorySiteLocationId;
        [Size(300)]
        public String ItemInventorySiteLocationId
        {
            get => _ItemInventorySiteLocationId;
            set => SetPropertyValue(nameof(ItemInventorySiteLocationId), ref _ItemInventorySiteLocationId, value);
        }  
        private String _ItemInventorySiteLocationName;
        [Size(300)]
        public String ItemInventorySiteLocationName
        {
            get => _ItemInventorySiteLocationName;
            set => SetPropertyValue(nameof(ItemInventorySiteLocationName), ref _ItemInventorySiteLocationName, value);
        }  
        private String _ItemIsManuallyClosed;
        [Size(300)]
        public String ItemIsManuallyClosed
        {
            get => _ItemIsManuallyClosed;
            set => SetPropertyValue(nameof(ItemIsManuallyClosed), ref _ItemIsManuallyClosed, value);
        }  
        private String _ItemPartNumber;
        [Size(300)]
        public String ItemPartNumber
        {
            get => _ItemPartNumber;
            set => SetPropertyValue(nameof(ItemPartNumber), ref _ItemPartNumber, value);
        }  
        private DateTime? _ItemServiceDate;
        public DateTime? ItemServiceDate
        {
            get => _ItemServiceDate;
            set => SetPropertyValue(nameof(ItemServiceDate), ref _ItemServiceDate, value);
        }  
        private String _ItemOther1;
        [Size(300)]
        public String ItemOther1
        {
            get => _ItemOther1;
            set => SetPropertyValue(nameof(ItemOther1), ref _ItemOther1, value);
        }  
        private String _ItemOther2;
        [Size(300)]
        public String ItemOther2
        {
            get => _ItemOther2;
            set => SetPropertyValue(nameof(ItemOther2), ref _ItemOther2, value);
        }  
        private String _ItemCustomFields;
        [Size(300)]
        public String ItemCustomFields
        {
            get => _ItemCustomFields;
            set => SetPropertyValue(nameof(ItemCustomFields), ref _ItemCustomFields, value);
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
        private String _ShipToEntityId;
        [Size(300)]
        public String ShipToEntityId
        {
            get => _ShipToEntityId;
            set => SetPropertyValue(nameof(ShipToEntityId), ref _ShipToEntityId, value);
        }  
        private String _ShipToEntityName;
        [Size(300)]
        public String ShipToEntityName
        {
            get => _ShipToEntityName;
            set => SetPropertyValue(nameof(ShipToEntityName), ref _ShipToEntityName, value);
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
        public const string QueryableProperties="Id,PurchaseOrderId,VendorName,VendorId,VendorMessage,ReferenceNumber,TxnNumber,Date,DueDate,ShipMethod,ShipMethodId,ExpectedDate,Memo,Class,ClassId,Terms,TermsId,TotalAmount,Template,TemplateId,CurrencyName,CurrencyId,CustomFields,ItemLineId,ItemLineNumber,ItemName,ItemId,ItemGroup,ItemGroupId,ItemDescription,ItemCustomer,ItemCustomerId,ItemUnitOfMeasure,ItemQuantity,ItemRate,ItemAmount,ItemReceivedQuantity,ItemClass,ItemClassId,ItemInventorySiteLocationId,ItemInventorySiteLocationName,ItemIsManuallyClosed,ItemPartNumber,ItemServiceDate,ItemOther1,ItemOther2,ItemCustomFields,IsFullyReceived,IsManuallyClosed,IsToBePrinted,IsToBeEmailed,IsTaxIncluded,SalesTaxCodeName,SalesTaxCodeId,Fob,VendorAddress,VendorLine1,VendorLine2,VendorLine3,VendorLine4,VendorLine5,VendorCity,VendorState,VendorPostalCode,VendorCountry,VendorNote,ShipToEntityId,ShipToEntityName,ShippingAddress,ShippingLine1,ShippingLine2,ShippingLine3,ShippingLine4,ShippingLine5,ShippingCity,ShippingState,ShippingPostalCode,ShippingCountry,ShippingNote,ExchangeRate,Other1,Other2,EditSequence,TimeModified,TimeCreated";
    }
}