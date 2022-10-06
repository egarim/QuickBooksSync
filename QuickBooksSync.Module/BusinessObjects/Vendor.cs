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
    public class Vendor : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Vendor(Session session)
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
        private String? _Company;
        public String? Company
        {
            get => _Company;
            set => SetPropertyValue(nameof(Company), ref _Company, value);
        }  
        private String? _Contact;
        public String? Contact
        {
            get => _Contact;
            set => SetPropertyValue(nameof(Contact), ref _Contact, value);
        }  
        private String? _AccountNumber;
        public String? AccountNumber
        {
            get => _AccountNumber;
            set => SetPropertyValue(nameof(AccountNumber), ref _AccountNumber, value);
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
        private Single _CreditLimit;
        public Single CreditLimit
        {
            get => _CreditLimit;
            set => SetPropertyValue(nameof(CreditLimit), ref _CreditLimit, value);
        }  
        private String? _TaxIdentity;
        public String? TaxIdentity
        {
            get => _TaxIdentity;
            set => SetPropertyValue(nameof(TaxIdentity), ref _TaxIdentity, value);
        }  
        private String? _SalesTaxCountry;
        public String? SalesTaxCountry
        {
            get => _SalesTaxCountry;
            set => SetPropertyValue(nameof(SalesTaxCountry), ref _SalesTaxCountry, value);
        }  
        private String? _AlternateContact;
        public String? AlternateContact
        {
            get => _AlternateContact;
            set => SetPropertyValue(nameof(AlternateContact), ref _AlternateContact, value);
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
        private String? _Notes;
        public String? Notes
        {
            get => _Notes;
            set => SetPropertyValue(nameof(Notes), ref _Notes, value);
        }  
        private String? _Address;
        public String? Address
        {
            get => _Address;
            set => SetPropertyValue(nameof(Address), ref _Address, value);
        }  
        private String? _Line1;
        public String? Line1
        {
            get => _Line1;
            set => SetPropertyValue(nameof(Line1), ref _Line1, value);
        }  
        private String? _Line2;
        public String? Line2
        {
            get => _Line2;
            set => SetPropertyValue(nameof(Line2), ref _Line2, value);
        }  
        private String? _Line3;
        public String? Line3
        {
            get => _Line3;
            set => SetPropertyValue(nameof(Line3), ref _Line3, value);
        }  
        private String? _Line4;
        public String? Line4
        {
            get => _Line4;
            set => SetPropertyValue(nameof(Line4), ref _Line4, value);
        }  
        private String? _Line5;
        public String? Line5
        {
            get => _Line5;
            set => SetPropertyValue(nameof(Line5), ref _Line5, value);
        }  
        private String? _City;
        public String? City
        {
            get => _City;
            set => SetPropertyValue(nameof(City), ref _City, value);
        }  
        private String? _State;
        public String? State
        {
            get => _State;
            set => SetPropertyValue(nameof(State), ref _State, value);
        }  
        private String? _PostalCode;
        public String? PostalCode
        {
            get => _PostalCode;
            set => SetPropertyValue(nameof(PostalCode), ref _PostalCode, value);
        }  
        private String? _Country;
        public String? Country
        {
            get => _Country;
            set => SetPropertyValue(nameof(Country), ref _Country, value);
        }  
        private String? _Note;
        public String? Note
        {
            get => _Note;
            set => SetPropertyValue(nameof(Note), ref _Note, value);
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
        private Single _Balance;
        public Single Balance
        {
            get => _Balance;
            set => SetPropertyValue(nameof(Balance), ref _Balance, value);
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
        private Boolean _EligibleFor1099;
        public Boolean EligibleFor1099
        {
            get => _EligibleFor1099;
            set => SetPropertyValue(nameof(EligibleFor1099), ref _EligibleFor1099, value);
        }  
        private String? _NameOnCheck;
        public String? NameOnCheck
        {
            get => _NameOnCheck;
            set => SetPropertyValue(nameof(NameOnCheck), ref _NameOnCheck, value);
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
        private String? _PrefillAccountId1;
        public String? PrefillAccountId1
        {
            get => _PrefillAccountId1;
            set => SetPropertyValue(nameof(PrefillAccountId1), ref _PrefillAccountId1, value);
        }  
        private String? _PrefillAccountName1;
        public String? PrefillAccountName1
        {
            get => _PrefillAccountName1;
            set => SetPropertyValue(nameof(PrefillAccountName1), ref _PrefillAccountName1, value);
        }  
        private String? _PrefillAccountId2;
        public String? PrefillAccountId2
        {
            get => _PrefillAccountId2;
            set => SetPropertyValue(nameof(PrefillAccountId2), ref _PrefillAccountId2, value);
        }  
        private String? _PrefillAccountName2;
        public String? PrefillAccountName2
        {
            get => _PrefillAccountName2;
            set => SetPropertyValue(nameof(PrefillAccountName2), ref _PrefillAccountName2, value);
        }  
        private String? _PrefillAccountId3;
        public String? PrefillAccountId3
        {
            get => _PrefillAccountId3;
            set => SetPropertyValue(nameof(PrefillAccountId3), ref _PrefillAccountId3, value);
        }  
        private String? _PrefillAccountName3;
        public String? PrefillAccountName3
        {
            get => _PrefillAccountName3;
            set => SetPropertyValue(nameof(PrefillAccountName3), ref _PrefillAccountName3, value);
        }  
        private string _Currency;
        public string Currency
        {
            get => _Currency;
            set => SetPropertyValue(nameof(Currency), ref _Currency, value);
        }
       
    }
}