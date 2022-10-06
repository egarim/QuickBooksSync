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
    public class Customer : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Customer(Session session)
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
        private String? _Name;
        public String? Name
        {
            get => _Name;
            set => SetPropertyValue(nameof(Name), ref _Name, value);
        }  
        private String? _FullName;
        public String? FullName
        {
            get => _FullName;
            set => SetPropertyValue(nameof(FullName), ref _FullName, value);
        }  
        private String? _Salutation;
        public String? Salutation
        {
            get => _Salutation;
            set => SetPropertyValue(nameof(Salutation), ref _Salutation, value);
        }  
        private String? _FirstName;
        public String? FirstName
        {
            get => _FirstName;
            set => SetPropertyValue(nameof(FirstName), ref _FirstName, value);
        }  
        private String? _MiddleInitial;
        public String? MiddleInitial
        {
            get => _MiddleInitial;
            set => SetPropertyValue(nameof(MiddleInitial), ref _MiddleInitial, value);
        }  
        private String? _LastName;
        public String? LastName
        {
            get => _LastName;
            set => SetPropertyValue(nameof(LastName), ref _LastName, value);
        }  
        private String? _AccountNumber;
        public String? AccountNumber
        {
            get => _AccountNumber;
            set => SetPropertyValue(nameof(AccountNumber), ref _AccountNumber, value);
        }  
        private String? _Company;
        public String? Company
        {
            get => _Company;
            set => SetPropertyValue(nameof(Company), ref _Company, value);
        }  
        private Single _Balance;
        public Single Balance
        {
            get => _Balance;
            set => SetPropertyValue(nameof(Balance), ref _Balance, value);
        }  
        private Single _CustomerBalance;
        public Single CustomerBalance
        {
            get => _CustomerBalance;
            set => SetPropertyValue(nameof(CustomerBalance), ref _CustomerBalance, value);
        }  
        private String? _Contact;
        public String? Contact
        {
            get => _Contact;
            set => SetPropertyValue(nameof(Contact), ref _Contact, value);
        }  
        private String? _Type;
        public String? Type
        {
            get => _Type;
            set => SetPropertyValue(nameof(Type), ref _Type, value);
        }  
        private String? _TypeId;
        public String? TypeId
        {
            get => _TypeId;
            set => SetPropertyValue(nameof(TypeId), ref _TypeId, value);
        }  
        private String? _Phone;
        public String? Phone
        {
            get => _Phone;
            set => SetPropertyValue(nameof(Phone), ref _Phone, value);
        }  
        private String? _Fax;
        public String? Fax
        {
            get => _Fax;
            set => SetPropertyValue(nameof(Fax), ref _Fax, value);
        }  
        private String? _AlternateContact;
        public String? AlternateContact
        {
            get => _AlternateContact;
            set => SetPropertyValue(nameof(AlternateContact), ref _AlternateContact, value);
        }  
        private String? _AlternatePhone;
        public String? AlternatePhone
        {
            get => _AlternatePhone;
            set => SetPropertyValue(nameof(AlternatePhone), ref _AlternatePhone, value);
        }  
        private String? _Email;
        public String? Email
        {
            get => _Email;
            set => SetPropertyValue(nameof(Email), ref _Email, value);
        }  
        private String? _Cc;
        public String? Cc
        {
            get => _Cc;
            set => SetPropertyValue(nameof(Cc), ref _Cc, value);
        }  
        private String? _AdditionalContactInfo;
        public String? AdditionalContactInfo
        {
            get => _AdditionalContactInfo;
            set => SetPropertyValue(nameof(AdditionalContactInfo), ref _AdditionalContactInfo, value);
        }  
        private String? _ContactsAggregate;
        public String? ContactsAggregate
        {
            get => _ContactsAggregate;
            set => SetPropertyValue(nameof(ContactsAggregate), ref _ContactsAggregate, value);
        }  
        private String? _ClassName;
        public String? ClassName
        {
            get => _ClassName;
            set => SetPropertyValue(nameof(ClassName), ref _ClassName, value);
        }  
        private String? _ClassId;
        public String? ClassId
        {
            get => _ClassId;
            set => SetPropertyValue(nameof(ClassId), ref _ClassId, value);
        }  
        private String? _Notes;
        public String? Notes
        {
            get => _Notes;
            set => SetPropertyValue(nameof(Notes), ref _Notes, value);
        }  
        private String? _NotesAggregate;
        public String? NotesAggregate
        {
            get => _NotesAggregate;
            set => SetPropertyValue(nameof(NotesAggregate), ref _NotesAggregate, value);
        }  
        private String? _ParentName;
        public String? ParentName
        {
            get => _ParentName;
            set => SetPropertyValue(nameof(ParentName), ref _ParentName, value);
        }  
        private String? _ParentId;
        public String? ParentId
        {
            get => _ParentId;
            set => SetPropertyValue(nameof(ParentId), ref _ParentId, value);
        }  
        private Int32 _Sublevel;
        public Int32 Sublevel
        {
            get => _Sublevel;
            set => SetPropertyValue(nameof(Sublevel), ref _Sublevel, value);
        }  
        private String? _JobStatus;
        public String? JobStatus
        {
            get => _JobStatus;
            set => SetPropertyValue(nameof(JobStatus), ref _JobStatus, value);
        }  
        private DateTime _JobStartDate;
        public DateTime JobStartDate
        {
            get => _JobStartDate;
            set => SetPropertyValue(nameof(JobStartDate), ref _JobStartDate, value);
        }  
        private DateTime _JobProjectedEndDate;
        public DateTime JobProjectedEndDate
        {
            get => _JobProjectedEndDate;
            set => SetPropertyValue(nameof(JobProjectedEndDate), ref _JobProjectedEndDate, value);
        }  
        private DateTime _JobEndDate;
        public DateTime JobEndDate
        {
            get => _JobEndDate;
            set => SetPropertyValue(nameof(JobEndDate), ref _JobEndDate, value);
        }  
        private String? _JobDescription;
        public String? JobDescription
        {
            get => _JobDescription;
            set => SetPropertyValue(nameof(JobDescription), ref _JobDescription, value);
        }  
        private String? _JobType;
        public String? JobType
        {
            get => _JobType;
            set => SetPropertyValue(nameof(JobType), ref _JobType, value);
        }  
        private String? _JobTypeId;
        public String? JobTypeId
        {
            get => _JobTypeId;
            set => SetPropertyValue(nameof(JobTypeId), ref _JobTypeId, value);
        }  
        private String? _CreditCardAddress;
        public String? CreditCardAddress
        {
            get => _CreditCardAddress;
            set => SetPropertyValue(nameof(CreditCardAddress), ref _CreditCardAddress, value);
        }  
        private Int32 _CreditCardExpMonth;
        public Int32 CreditCardExpMonth
        {
            get => _CreditCardExpMonth;
            set => SetPropertyValue(nameof(CreditCardExpMonth), ref _CreditCardExpMonth, value);
        }  
        private Int32 _CreditCardExpYear;
        public Int32 CreditCardExpYear
        {
            get => _CreditCardExpYear;
            set => SetPropertyValue(nameof(CreditCardExpYear), ref _CreditCardExpYear, value);
        }  
        private String? _CreditCardNameOnCard;
        public String? CreditCardNameOnCard
        {
            get => _CreditCardNameOnCard;
            set => SetPropertyValue(nameof(CreditCardNameOnCard), ref _CreditCardNameOnCard, value);
        }  
        private String? _CreditCardNumber;
        public String? CreditCardNumber
        {
            get => _CreditCardNumber;
            set => SetPropertyValue(nameof(CreditCardNumber), ref _CreditCardNumber, value);
        }  
        private String? _CreditCardPostalCode;
        public String? CreditCardPostalCode
        {
            get => _CreditCardPostalCode;
            set => SetPropertyValue(nameof(CreditCardPostalCode), ref _CreditCardPostalCode, value);
        }  
        private Single _CreditLimit;
        public Single CreditLimit
        {
            get => _CreditLimit;
            set => SetPropertyValue(nameof(CreditLimit), ref _CreditLimit, value);
        }  
        private String? _BillingAddress;
        public String? BillingAddress
        {
            get => _BillingAddress;
            set => SetPropertyValue(nameof(BillingAddress), ref _BillingAddress, value);
        }  
        private String? _BillingLine1;
        public String? BillingLine1
        {
            get => _BillingLine1;
            set => SetPropertyValue(nameof(BillingLine1), ref _BillingLine1, value);
        }  
        private String? _BillingLine2;
        public String? BillingLine2
        {
            get => _BillingLine2;
            set => SetPropertyValue(nameof(BillingLine2), ref _BillingLine2, value);
        }  
        private String? _BillingLine3;
        public String? BillingLine3
        {
            get => _BillingLine3;
            set => SetPropertyValue(nameof(BillingLine3), ref _BillingLine3, value);
        }  
        private String? _BillingLine4;
        public String? BillingLine4
        {
            get => _BillingLine4;
            set => SetPropertyValue(nameof(BillingLine4), ref _BillingLine4, value);
        }  
        private String? _BillingLine5;
        public String? BillingLine5
        {
            get => _BillingLine5;
            set => SetPropertyValue(nameof(BillingLine5), ref _BillingLine5, value);
        }  
        private String? _BillingCity;
        public String? BillingCity
        {
            get => _BillingCity;
            set => SetPropertyValue(nameof(BillingCity), ref _BillingCity, value);
        }  
        private String? _BillingState;
        public String? BillingState
        {
            get => _BillingState;
            set => SetPropertyValue(nameof(BillingState), ref _BillingState, value);
        }  
        private String? _BillingPostalCode;
        public String? BillingPostalCode
        {
            get => _BillingPostalCode;
            set => SetPropertyValue(nameof(BillingPostalCode), ref _BillingPostalCode, value);
        }  
        private String? _BillingCountry;
        public String? BillingCountry
        {
            get => _BillingCountry;
            set => SetPropertyValue(nameof(BillingCountry), ref _BillingCountry, value);
        }  
        private String? _BillingNote;
        public String? BillingNote
        {
            get => _BillingNote;
            set => SetPropertyValue(nameof(BillingNote), ref _BillingNote, value);
        }  
        private String? _ShippingAddress;
        public String? ShippingAddress
        {
            get => _ShippingAddress;
            set => SetPropertyValue(nameof(ShippingAddress), ref _ShippingAddress, value);
        }  
        private String? _ShippingLine1;
        public String? ShippingLine1
        {
            get => _ShippingLine1;
            set => SetPropertyValue(nameof(ShippingLine1), ref _ShippingLine1, value);
        }  
        private String? _ShippingLine2;
        public String? ShippingLine2
        {
            get => _ShippingLine2;
            set => SetPropertyValue(nameof(ShippingLine2), ref _ShippingLine2, value);
        }  
        private String? _ShippingLine3;
        public String? ShippingLine3
        {
            get => _ShippingLine3;
            set => SetPropertyValue(nameof(ShippingLine3), ref _ShippingLine3, value);
        }  
        private String? _ShippingLine4;
        public String? ShippingLine4
        {
            get => _ShippingLine4;
            set => SetPropertyValue(nameof(ShippingLine4), ref _ShippingLine4, value);
        }  
        private String? _ShippingLine5;
        public String? ShippingLine5
        {
            get => _ShippingLine5;
            set => SetPropertyValue(nameof(ShippingLine5), ref _ShippingLine5, value);
        }  
        private String? _ShippingCity;
        public String? ShippingCity
        {
            get => _ShippingCity;
            set => SetPropertyValue(nameof(ShippingCity), ref _ShippingCity, value);
        }  
        private String? _ShippingState;
        public String? ShippingState
        {
            get => _ShippingState;
            set => SetPropertyValue(nameof(ShippingState), ref _ShippingState, value);
        }  
        private String? _ShippingPostalCode;
        public String? ShippingPostalCode
        {
            get => _ShippingPostalCode;
            set => SetPropertyValue(nameof(ShippingPostalCode), ref _ShippingPostalCode, value);
        }  
        private String? _ShippingCountry;
        public String? ShippingCountry
        {
            get => _ShippingCountry;
            set => SetPropertyValue(nameof(ShippingCountry), ref _ShippingCountry, value);
        }  
        private String? _ShippingNote;
        public String? ShippingNote
        {
            get => _ShippingNote;
            set => SetPropertyValue(nameof(ShippingNote), ref _ShippingNote, value);
        }  
        private String? _ShippingAggregate;
        public String? ShippingAggregate
        {
            get => _ShippingAggregate;
            set => SetPropertyValue(nameof(ShippingAggregate), ref _ShippingAggregate, value);
        }  
        private String? _ResaleNumber;
        public String? ResaleNumber
        {
            get => _ResaleNumber;
            set => SetPropertyValue(nameof(ResaleNumber), ref _ResaleNumber, value);
        }  
        private String? _SalesRep;
        public String? SalesRep
        {
            get => _SalesRep;
            set => SetPropertyValue(nameof(SalesRep), ref _SalesRep, value);
        }  
        private String? _SalesRepId;
        public String? SalesRepId
        {
            get => _SalesRepId;
            set => SetPropertyValue(nameof(SalesRepId), ref _SalesRepId, value);
        }  
        private String? _Terms;
        public String? Terms
        {
            get => _Terms;
            set => SetPropertyValue(nameof(Terms), ref _Terms, value);
        }  
        private String? _TermsId;
        public String? TermsId
        {
            get => _TermsId;
            set => SetPropertyValue(nameof(TermsId), ref _TermsId, value);
        }  
        private String? _CurrencyName;
        public String? CurrencyName
        {
            get => _CurrencyName;
            set => SetPropertyValue(nameof(CurrencyName), ref _CurrencyName, value);
        }  
        private String? _CurrencyId;
        public String? CurrencyId
        {
            get => _CurrencyId;
            set => SetPropertyValue(nameof(CurrencyId), ref _CurrencyId, value);
        }  
        private String? _TaxCode;
        public String? TaxCode
        {
            get => _TaxCode;
            set => SetPropertyValue(nameof(TaxCode), ref _TaxCode, value);
        }  
        private String? _TaxCodeId;
        public String? TaxCodeId
        {
            get => _TaxCodeId;
            set => SetPropertyValue(nameof(TaxCodeId), ref _TaxCodeId, value);
        }  
        private String? _TaxItem;
        public String? TaxItem
        {
            get => _TaxItem;
            set => SetPropertyValue(nameof(TaxItem), ref _TaxItem, value);
        }  
        private String? _TaxItemId;
        public String? TaxItemId
        {
            get => _TaxItemId;
            set => SetPropertyValue(nameof(TaxItemId), ref _TaxItemId, value);
        }  
        private String? _SalesTaxCountry;
        public String? SalesTaxCountry
        {
            get => _SalesTaxCountry;
            set => SetPropertyValue(nameof(SalesTaxCountry), ref _SalesTaxCountry, value);
        }  
        private String? _PriceLevel;
        public String? PriceLevel
        {
            get => _PriceLevel;
            set => SetPropertyValue(nameof(PriceLevel), ref _PriceLevel, value);
        }  
        private String? _PriceLevelId;
        public String? PriceLevelId
        {
            get => _PriceLevelId;
            set => SetPropertyValue(nameof(PriceLevelId), ref _PriceLevelId, value);
        }  
        private String? _PreferredDeliveryMethod;
        public String? PreferredDeliveryMethod
        {
            get => _PreferredDeliveryMethod;
            set => SetPropertyValue(nameof(PreferredDeliveryMethod), ref _PreferredDeliveryMethod, value);
        }  
        private String? _PreferredPaymentMethodName;
        public String? PreferredPaymentMethodName
        {
            get => _PreferredPaymentMethodName;
            set => SetPropertyValue(nameof(PreferredPaymentMethodName), ref _PreferredPaymentMethodName, value);
        }  
        private String? _PreferredPaymentMethodId;
        public String? PreferredPaymentMethodId
        {
            get => _PreferredPaymentMethodId;
            set => SetPropertyValue(nameof(PreferredPaymentMethodId), ref _PreferredPaymentMethodId, value);
        }  
        private Boolean _IsActive;
        public Boolean IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
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
        private string _Currency;
        public string Currency
        {
            get => _Currency;
            set => SetPropertyValue(nameof(Currency), ref _Currency, value);
        }  
        private string _JobTypeNavigation;
        public string JobTypeNavigation
        {
            get => _JobTypeNavigation;
            set => SetPropertyValue(nameof(JobTypeNavigation), ref _JobTypeNavigation, value);
        }  
        private string _Parent;
        public string Parent
        {
            get => _Parent;
            set => SetPropertyValue(nameof(Parent), ref _Parent, value);
        }  
        private string _PreferredPaymentMethod;
        public string PreferredPaymentMethod
        {
            get => _PreferredPaymentMethod;
            set => SetPropertyValue(nameof(PreferredPaymentMethod), ref _PreferredPaymentMethod, value);
        }  
        private string _PriceLevelNavigation;
        public string PriceLevelNavigation
        {
            get => _PriceLevelNavigation;
            set => SetPropertyValue(nameof(PriceLevelNavigation), ref _PriceLevelNavigation, value);
        }  
        private string _SalesRepNavigation;
        public string SalesRepNavigation
        {
            get => _SalesRepNavigation;
            set => SetPropertyValue(nameof(SalesRepNavigation), ref _SalesRepNavigation, value);
        }  
        private string _TaxCodeNavigation;
        public string TaxCodeNavigation
        {
            get => _TaxCodeNavigation;
            set => SetPropertyValue(nameof(TaxCodeNavigation), ref _TaxCodeNavigation, value);
        }  
        private string _TaxItemNavigation;
        public string TaxItemNavigation
        {
            get => _TaxItemNavigation;
            set => SetPropertyValue(nameof(TaxItemNavigation), ref _TaxItemNavigation, value);
        }  
        private string _TypeNavigation;
        public string TypeNavigation
        {
            get => _TypeNavigation;
            set => SetPropertyValue(nameof(TypeNavigation), ref _TypeNavigation, value);
        }
        public const string QueriableProperties="Id,Name,FullName,Salutation,FirstName,MiddleInitial,LastName,AccountNumber,Company,Balance,CustomerBalance,Contact,Type,TypeId,Phone,Fax,AlternateContact,AlternatePhone,Email,Cc,AdditionalContactInfo,ContactsAggregate,ClassName,ClassId,Notes,NotesAggregate,ParentName,ParentId,Sublevel,JobStatus,JobStartDate,JobProjectedEndDate,JobEndDate,JobDescription,JobType,JobTypeId,CreditCardAddress,CreditCardExpMonth,CreditCardExpYear,CreditCardNameOnCard,CreditCardNumber,CreditCardPostalCode,CreditLimit,BillingAddress,BillingLine1,BillingLine2,BillingLine3,BillingLine4,BillingLine5,BillingCity,BillingState,BillingPostalCode,BillingCountry,BillingNote,ShippingAddress,ShippingLine1,ShippingLine2,ShippingLine3,ShippingLine4,ShippingLine5,ShippingCity,ShippingState,ShippingPostalCode,ShippingCountry,ShippingNote,ShippingAggregate,ResaleNumber,SalesRep,SalesRepId,Terms,TermsId,CurrencyName,CurrencyId,TaxCode,TaxCodeId,TaxItem,TaxItemId,SalesTaxCountry,PriceLevel,PriceLevelId,PreferredDeliveryMethod,PreferredPaymentMethodName,PreferredPaymentMethodId,IsActive,CustomFields,EditSequence,TimeModified,TimeCreated,Currency,JobTypeNavigation,Parent,PreferredPaymentMethod,PriceLevelNavigation,SalesRepNavigation,TaxCodeNavigation,TaxItemNavigation,TypeNavigation";
    }
}