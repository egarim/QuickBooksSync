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
    public class Employee : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Employee(Session session)
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
        private String? _JobTitle;
        public String? JobTitle
        {
            get => _JobTitle;
            set => SetPropertyValue(nameof(JobTitle), ref _JobTitle, value);
        }  
        private String? _AccountNumber;
        public String? AccountNumber
        {
            get => _AccountNumber;
            set => SetPropertyValue(nameof(AccountNumber), ref _AccountNumber, value);
        }  
        private String? _Ssn;
        public String? Ssn
        {
            get => _Ssn;
            set => SetPropertyValue(nameof(Ssn), ref _Ssn, value);
        }  
        private String? _EmployeeType;
        public String? EmployeeType
        {
            get => _EmployeeType;
            set => SetPropertyValue(nameof(EmployeeType), ref _EmployeeType, value);
        }  
        private String? _Gender;
        public String? Gender
        {
            get => _Gender;
            set => SetPropertyValue(nameof(Gender), ref _Gender, value);
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
        private String? _PrintAs;
        public String? PrintAs
        {
            get => _PrintAs;
            set => SetPropertyValue(nameof(PrintAs), ref _PrintAs, value);
        }  
        private String? _MobilePhone;
        public String? MobilePhone
        {
            get => _MobilePhone;
            set => SetPropertyValue(nameof(MobilePhone), ref _MobilePhone, value);
        }  
        private String? _Pager;
        public String? Pager
        {
            get => _Pager;
            set => SetPropertyValue(nameof(Pager), ref _Pager, value);
        }  
        private String? _PagerPin;
        public String? PagerPin
        {
            get => _PagerPin;
            set => SetPropertyValue(nameof(PagerPin), ref _PagerPin, value);
        }  
        private String? _Fax;
        public String? Fax
        {
            get => _Fax;
            set => SetPropertyValue(nameof(Fax), ref _Fax, value);
        }  
        private DateTime _BirthDate;
        public DateTime BirthDate
        {
            get => _BirthDate;
            set => SetPropertyValue(nameof(BirthDate), ref _BirthDate, value);
        }  
        private String? _Uscitizen;
        public String? Uscitizen
        {
            get => _Uscitizen;
            set => SetPropertyValue(nameof(Uscitizen), ref _Uscitizen, value);
        }  
        private String? _Ethnicity;
        public String? Ethnicity
        {
            get => _Ethnicity;
            set => SetPropertyValue(nameof(Ethnicity), ref _Ethnicity, value);
        }  
        private String? _Disabled;
        public String? Disabled
        {
            get => _Disabled;
            set => SetPropertyValue(nameof(Disabled), ref _Disabled, value);
        }  
        private String? _DisabilityDescription;
        public String? DisabilityDescription
        {
            get => _DisabilityDescription;
            set => SetPropertyValue(nameof(DisabilityDescription), ref _DisabilityDescription, value);
        }  
        private String? _FormOnFile;
        public String? FormOnFile
        {
            get => _FormOnFile;
            set => SetPropertyValue(nameof(FormOnFile), ref _FormOnFile, value);
        }  
        private String? _Usveteran;
        public String? Usveteran
        {
            get => _Usveteran;
            set => SetPropertyValue(nameof(Usveteran), ref _Usveteran, value);
        }  
        private String? _MilitaryStatus;
        public String? MilitaryStatus
        {
            get => _MilitaryStatus;
            set => SetPropertyValue(nameof(MilitaryStatus), ref _MilitaryStatus, value);
        }  
        private DateTime _HiredDate;
        public DateTime HiredDate
        {
            get => _HiredDate;
            set => SetPropertyValue(nameof(HiredDate), ref _HiredDate, value);
        }  
        private Boolean _IsActive;
        public Boolean IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String? _Notes;
        public String? Notes
        {
            get => _Notes;
            set => SetPropertyValue(nameof(Notes), ref _Notes, value);
        }  
        private String? _PayPeriod;
        public String? PayPeriod
        {
            get => _PayPeriod;
            set => SetPropertyValue(nameof(PayPeriod), ref _PayPeriod, value);
        }  
        private String? _PayrollClassName;
        public String? PayrollClassName
        {
            get => _PayrollClassName;
            set => SetPropertyValue(nameof(PayrollClassName), ref _PayrollClassName, value);
        }  
        private String? _PayrollClassId;
        public String? PayrollClassId
        {
            get => _PayrollClassId;
            set => SetPropertyValue(nameof(PayrollClassId), ref _PayrollClassId, value);
        }  
        private String? _Phone;
        public String? Phone
        {
            get => _Phone;
            set => SetPropertyValue(nameof(Phone), ref _Phone, value);
        }  
        private DateTime _ReleasedDate;
        public DateTime ReleasedDate
        {
            get => _ReleasedDate;
            set => SetPropertyValue(nameof(ReleasedDate), ref _ReleasedDate, value);
        }  
        private String? _TimeDataForPaychecks;
        public String? TimeDataForPaychecks
        {
            get => _TimeDataForPaychecks;
            set => SetPropertyValue(nameof(TimeDataForPaychecks), ref _TimeDataForPaychecks, value);
        }  
        private String? _SickTimeAccrualPeriod;
        public String? SickTimeAccrualPeriod
        {
            get => _SickTimeAccrualPeriod;
            set => SetPropertyValue(nameof(SickTimeAccrualPeriod), ref _SickTimeAccrualPeriod, value);
        }  
        private DateTime _SickTimeAccrualStartDate;
        public DateTime SickTimeAccrualStartDate
        {
            get => _SickTimeAccrualStartDate;
            set => SetPropertyValue(nameof(SickTimeAccrualStartDate), ref _SickTimeAccrualStartDate, value);
        }  
        private String? _SickTimeAccrued;
        public String? SickTimeAccrued
        {
            get => _SickTimeAccrued;
            set => SetPropertyValue(nameof(SickTimeAccrued), ref _SickTimeAccrued, value);
        }  
        private String? _SickTimeAvailable;
        public String? SickTimeAvailable
        {
            get => _SickTimeAvailable;
            set => SetPropertyValue(nameof(SickTimeAvailable), ref _SickTimeAvailable, value);
        }  
        private String? _SickTimeMaximum;
        public String? SickTimeMaximum
        {
            get => _SickTimeMaximum;
            set => SetPropertyValue(nameof(SickTimeMaximum), ref _SickTimeMaximum, value);
        }  
        private Boolean _SickTimeYearlyReset;
        public Boolean SickTimeYearlyReset
        {
            get => _SickTimeYearlyReset;
            set => SetPropertyValue(nameof(SickTimeYearlyReset), ref _SickTimeYearlyReset, value);
        }  
        private String? _SickTimeUsed;
        public String? SickTimeUsed
        {
            get => _SickTimeUsed;
            set => SetPropertyValue(nameof(SickTimeUsed), ref _SickTimeUsed, value);
        }  
        private String? _VacationTimeAccrualPeriod;
        public String? VacationTimeAccrualPeriod
        {
            get => _VacationTimeAccrualPeriod;
            set => SetPropertyValue(nameof(VacationTimeAccrualPeriod), ref _VacationTimeAccrualPeriod, value);
        }  
        private DateTime _VacationTimeAccrualStartDate;
        public DateTime VacationTimeAccrualStartDate
        {
            get => _VacationTimeAccrualStartDate;
            set => SetPropertyValue(nameof(VacationTimeAccrualStartDate), ref _VacationTimeAccrualStartDate, value);
        }  
        private String? _VacationTimeAccrued;
        public String? VacationTimeAccrued
        {
            get => _VacationTimeAccrued;
            set => SetPropertyValue(nameof(VacationTimeAccrued), ref _VacationTimeAccrued, value);
        }  
        private String? _VacationTimeAvailable;
        public String? VacationTimeAvailable
        {
            get => _VacationTimeAvailable;
            set => SetPropertyValue(nameof(VacationTimeAvailable), ref _VacationTimeAvailable, value);
        }  
        private String? _VacationTimeMaximum;
        public String? VacationTimeMaximum
        {
            get => _VacationTimeMaximum;
            set => SetPropertyValue(nameof(VacationTimeMaximum), ref _VacationTimeMaximum, value);
        }  
        private Boolean _VacationTimeYearlyReset;
        public Boolean VacationTimeYearlyReset
        {
            get => _VacationTimeYearlyReset;
            set => SetPropertyValue(nameof(VacationTimeYearlyReset), ref _VacationTimeYearlyReset, value);
        }  
        private String? _VacationTimeUsed;
        public String? VacationTimeUsed
        {
            get => _VacationTimeUsed;
            set => SetPropertyValue(nameof(VacationTimeUsed), ref _VacationTimeUsed, value);
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
        private string _PayrollClass;
        public string PayrollClass
        {
            get => _PayrollClass;
            set => SetPropertyValue(nameof(PayrollClass), ref _PayrollClass, value);
        }
        public const string QueriableProperties="Id,Name,Salutation,FirstName,MiddleInitial,LastName,JobTitle,AccountNumber,Ssn,EmployeeType,Gender,Address,Line1,Line2,City,State,PostalCode,AlternatePhone,Email,PrintAs,MobilePhone,Pager,PagerPin,Fax,BirthDate,Uscitizen,Ethnicity,Disabled,DisabilityDescription,FormOnFile,Usveteran,MilitaryStatus,HiredDate,IsActive,Notes,PayPeriod,PayrollClassName,PayrollClassId,Phone,ReleasedDate,TimeDataForPaychecks,SickTimeAccrualPeriod,SickTimeAccrualStartDate,SickTimeAccrued,SickTimeAvailable,SickTimeMaximum,SickTimeYearlyReset,SickTimeUsed,VacationTimeAccrualPeriod,VacationTimeAccrualStartDate,VacationTimeAccrued,VacationTimeAvailable,VacationTimeMaximum,VacationTimeYearlyReset,VacationTimeUsed,CustomFields,EditSequence,TimeModified,TimeCreated,PayrollClass";
    }
}