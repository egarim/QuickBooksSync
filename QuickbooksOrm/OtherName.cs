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
    public class OtherName : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public OtherName(Session session)
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
        private Boolean _IsActive;
        public Boolean IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String? _CompanyName;
        public String? CompanyName
        {
            get => _CompanyName;
            set => SetPropertyValue(nameof(CompanyName), ref _CompanyName, value);
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
        private String? _MiddleName;
        public String? MiddleName
        {
            get => _MiddleName;
            set => SetPropertyValue(nameof(MiddleName), ref _MiddleName, value);
        }  
        private String? _LastName;
        public String? LastName
        {
            get => _LastName;
            set => SetPropertyValue(nameof(LastName), ref _LastName, value);
        }  
        private String? _OtherNameAddressAddr1;
        public String? OtherNameAddressAddr1
        {
            get => _OtherNameAddressAddr1;
            set => SetPropertyValue(nameof(OtherNameAddressAddr1), ref _OtherNameAddressAddr1, value);
        }  
        private String? _OtherNameAddressAddr2;
        public String? OtherNameAddressAddr2
        {
            get => _OtherNameAddressAddr2;
            set => SetPropertyValue(nameof(OtherNameAddressAddr2), ref _OtherNameAddressAddr2, value);
        }  
        private String? _OtherNameAddressAddr3;
        public String? OtherNameAddressAddr3
        {
            get => _OtherNameAddressAddr3;
            set => SetPropertyValue(nameof(OtherNameAddressAddr3), ref _OtherNameAddressAddr3, value);
        }  
        private String? _OtherNameAddressAddr4;
        public String? OtherNameAddressAddr4
        {
            get => _OtherNameAddressAddr4;
            set => SetPropertyValue(nameof(OtherNameAddressAddr4), ref _OtherNameAddressAddr4, value);
        }  
        private String? _OtherNameAddressAddr5;
        public String? OtherNameAddressAddr5
        {
            get => _OtherNameAddressAddr5;
            set => SetPropertyValue(nameof(OtherNameAddressAddr5), ref _OtherNameAddressAddr5, value);
        }  
        private String? _OtherNameAddressCity;
        public String? OtherNameAddressCity
        {
            get => _OtherNameAddressCity;
            set => SetPropertyValue(nameof(OtherNameAddressCity), ref _OtherNameAddressCity, value);
        }  
        private String? _OtherNameAddressState;
        public String? OtherNameAddressState
        {
            get => _OtherNameAddressState;
            set => SetPropertyValue(nameof(OtherNameAddressState), ref _OtherNameAddressState, value);
        }  
        private String? _OtherNameAddressPostalCode;
        public String? OtherNameAddressPostalCode
        {
            get => _OtherNameAddressPostalCode;
            set => SetPropertyValue(nameof(OtherNameAddressPostalCode), ref _OtherNameAddressPostalCode, value);
        }  
        private String? _OtherNameAddressCountry;
        public String? OtherNameAddressCountry
        {
            get => _OtherNameAddressCountry;
            set => SetPropertyValue(nameof(OtherNameAddressCountry), ref _OtherNameAddressCountry, value);
        }  
        private String? _OtherNameAddressNote;
        public String? OtherNameAddressNote
        {
            get => _OtherNameAddressNote;
            set => SetPropertyValue(nameof(OtherNameAddressNote), ref _OtherNameAddressNote, value);
        }  
        private String? _Phone;
        public String? Phone
        {
            get => _Phone;
            set => SetPropertyValue(nameof(Phone), ref _Phone, value);
        }  
        private String? _AltPhone;
        public String? AltPhone
        {
            get => _AltPhone;
            set => SetPropertyValue(nameof(AltPhone), ref _AltPhone, value);
        }  
        private String? _Fax;
        public String? Fax
        {
            get => _Fax;
            set => SetPropertyValue(nameof(Fax), ref _Fax, value);
        }  
        private String? _Email;
        public String? Email
        {
            get => _Email;
            set => SetPropertyValue(nameof(Email), ref _Email, value);
        }  
        private String? _Contact;
        public String? Contact
        {
            get => _Contact;
            set => SetPropertyValue(nameof(Contact), ref _Contact, value);
        }  
        private String? _AltContact;
        public String? AltContact
        {
            get => _AltContact;
            set => SetPropertyValue(nameof(AltContact), ref _AltContact, value);
        }  
        private String? _AccountNumber;
        public String? AccountNumber
        {
            get => _AccountNumber;
            set => SetPropertyValue(nameof(AccountNumber), ref _AccountNumber, value);
        }  
        private String? _Notes;
        public String? Notes
        {
            get => _Notes;
            set => SetPropertyValue(nameof(Notes), ref _Notes, value);
        }  
        private String? _ExternalGuid;
        public String? ExternalGuid
        {
            get => _ExternalGuid;
            set => SetPropertyValue(nameof(ExternalGuid), ref _ExternalGuid, value);
        }  
        private String? _CustomFields;
        public String? CustomFields
        {
            get => _CustomFields;
            set => SetPropertyValue(nameof(CustomFields), ref _CustomFields, value);
        }  
        private DateTime _TimeCreated;
        public DateTime TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private DateTime _TimeModified;
        public DateTime TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }  
        private String? _EditSequence;
        public String? EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }
        public const string QueriableProperties="Id,Name,IsActive,CompanyName,Salutation,FirstName,MiddleName,LastName,OtherNameAddressAddr1,OtherNameAddressAddr2,OtherNameAddressAddr3,OtherNameAddressAddr4,OtherNameAddressAddr5,OtherNameAddressCity,OtherNameAddressState,OtherNameAddressPostalCode,OtherNameAddressCountry,OtherNameAddressNote,Phone,AltPhone,Fax,Email,Contact,AltContact,AccountNumber,Notes,ExternalGuid,CustomFields,TimeCreated,TimeModified,EditSequence";
    }
}