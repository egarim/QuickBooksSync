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
    [NavigationItem("Quickbooks Data")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class CustomerContact : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CustomerContact(Session session)
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
        private String _CustomerId;
        [Size(300)]
        public String CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
        }  
        private String _Name;
        [Size(300)]
        public String Name
        {
            get => _Name;
            set => SetPropertyValue(nameof(Name), ref _Name, value);
        }  
        private String _FullName;
        [Size(300)]
        public String FullName
        {
            get => _FullName;
            set => SetPropertyValue(nameof(FullName), ref _FullName, value);
        }  
        private String _ContactId;
        [Size(300)]
        public String ContactId
        {
            get => _ContactId;
            set => SetPropertyValue(nameof(ContactId), ref _ContactId, value);
        }  
        private String _ContactEditSequence;
        [Size(300)]
        public String ContactEditSequence
        {
            get => _ContactEditSequence;
            set => SetPropertyValue(nameof(ContactEditSequence), ref _ContactEditSequence, value);
        }  
        private String _ContactFirstName;
        [Size(300)]
        public String ContactFirstName
        {
            get => _ContactFirstName;
            set => SetPropertyValue(nameof(ContactFirstName), ref _ContactFirstName, value);
        }  
        private String _ContactMiddleName;
        [Size(300)]
        public String ContactMiddleName
        {
            get => _ContactMiddleName;
            set => SetPropertyValue(nameof(ContactMiddleName), ref _ContactMiddleName, value);
        }  
        private String _ContactLastName;
        [Size(300)]
        public String ContactLastName
        {
            get => _ContactLastName;
            set => SetPropertyValue(nameof(ContactLastName), ref _ContactLastName, value);
        }  
        private String _ContactJobTitle;
        [Size(300)]
        public String ContactJobTitle
        {
            get => _ContactJobTitle;
            set => SetPropertyValue(nameof(ContactJobTitle), ref _ContactJobTitle, value);
        }  
        private String _ContactSalutation;
        [Size(300)]
        public String ContactSalutation
        {
            get => _ContactSalutation;
            set => SetPropertyValue(nameof(ContactSalutation), ref _ContactSalutation, value);
        }  
        private String _ContactMethods;
        [Size(300)]
        public String ContactMethods
        {
            get => _ContactMethods;
            set => SetPropertyValue(nameof(ContactMethods), ref _ContactMethods, value);
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
        public const string QueryableProperties="Id,CustomerId,Name,FullName,ContactId,ContactEditSequence,ContactFirstName,ContactMiddleName,ContactLastName,ContactJobTitle,ContactSalutation,ContactMethods,EditSequence,TimeModified,TimeCreated";
        public const string QuickbooksTableName="CustomerContacts";
    }
}