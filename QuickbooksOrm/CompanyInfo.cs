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
    public class CompanyInfo : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CompanyInfo(Session session)
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
        private String? _Type;
        public String? Type
        {
            get => _Type;
            set => SetPropertyValue(nameof(Type), ref _Type, value);
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
        private String? _Email;
        public String? Email
        {
            get => _Email;
            set => SetPropertyValue(nameof(Email), ref _Email, value);
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
        private String? _Ssn;
        public String? Ssn
        {
            get => _Ssn;
            set => SetPropertyValue(nameof(Ssn), ref _Ssn, value);
        }  
        private String? _Taxform;
        public String? Taxform
        {
            get => _Taxform;
            set => SetPropertyValue(nameof(Taxform), ref _Taxform, value);
        }  
        private String? _Website;
        public String? Website
        {
            get => _Website;
            set => SetPropertyValue(nameof(Website), ref _Website, value);
        }  
        private String? _FirstMonthFiscal;
        public String? FirstMonthFiscal
        {
            get => _FirstMonthFiscal;
            set => SetPropertyValue(nameof(FirstMonthFiscal), ref _FirstMonthFiscal, value);
        }  
        private String? _FirstMonthTax;
        public String? FirstMonthTax
        {
            get => _FirstMonthTax;
            set => SetPropertyValue(nameof(FirstMonthTax), ref _FirstMonthTax, value);
        }  
        private String? _LegalAddress;
        public String? LegalAddress
        {
            get => _LegalAddress;
            set => SetPropertyValue(nameof(LegalAddress), ref _LegalAddress, value);
        }  
        private String? _LegalCity;
        public String? LegalCity
        {
            get => _LegalCity;
            set => SetPropertyValue(nameof(LegalCity), ref _LegalCity, value);
        }  
        private String? _LegalCountry;
        public String? LegalCountry
        {
            get => _LegalCountry;
            set => SetPropertyValue(nameof(LegalCountry), ref _LegalCountry, value);
        }  
        private String? _LegalState;
        public String? LegalState
        {
            get => _LegalState;
            set => SetPropertyValue(nameof(LegalState), ref _LegalState, value);
        }  
        private String? _LegalZip;
        public String? LegalZip
        {
            get => _LegalZip;
            set => SetPropertyValue(nameof(LegalZip), ref _LegalZip, value);
        }  
        private String? _LegalName;
        public String? LegalName
        {
            get => _LegalName;
            set => SetPropertyValue(nameof(LegalName), ref _LegalName, value);
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
        private String? _OpenedCompanyFile;
        public String? OpenedCompanyFile
        {
            get => _OpenedCompanyFile;
            set => SetPropertyValue(nameof(OpenedCompanyFile), ref _OpenedCompanyFile, value);
        }
       
    }
}