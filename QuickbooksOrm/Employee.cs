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
        private String _Name;
        [Size(300)]
        public String Name
        {
            get => _Name;
            set => SetPropertyValue(nameof(Name), ref _Name, value);
        }  
        private String _Salutation;
        [Size(300)]
        public String Salutation
        {
            get => _Salutation;
            set => SetPropertyValue(nameof(Salutation), ref _Salutation, value);
        }  
        private String _FirstName;
        [Size(300)]
        public String FirstName
        {
            get => _FirstName;
            set => SetPropertyValue(nameof(FirstName), ref _FirstName, value);
        }  
        private String _MiddleInitial;
        [Size(300)]
        public String MiddleInitial
        {
            get => _MiddleInitial;
            set => SetPropertyValue(nameof(MiddleInitial), ref _MiddleInitial, value);
        }  
        private String _LastName;
        [Size(300)]
        public String LastName
        {
            get => _LastName;
            set => SetPropertyValue(nameof(LastName), ref _LastName, value);
        }  
        private String _JobTitle;
        [Size(300)]
        public String JobTitle
        {
            get => _JobTitle;
            set => SetPropertyValue(nameof(JobTitle), ref _JobTitle, value);
        }  
        private String _AccountNumber;
        [Size(300)]
        public String AccountNumber
        {
            get => _AccountNumber;
            set => SetPropertyValue(nameof(AccountNumber), ref _AccountNumber, value);
        }  
        private String _Ssn;
        [Size(300)]
        public String Ssn
        {
            get => _Ssn;
            set => SetPropertyValue(nameof(Ssn), ref _Ssn, value);
        }  
        private String _EmployeeType;
        [Size(300)]
        public String EmployeeType
        {
            get => _EmployeeType;
            set => SetPropertyValue(nameof(EmployeeType), ref _EmployeeType, value);
        }  
        private String _Gender;
        [Size(300)]
        public String Gender
        {
            get => _Gender;
            set => SetPropertyValue(nameof(Gender), ref _Gender, value);
        }  
        private String _Address;
        [Size(300)]
        public String Address
        {
            get => _Address;
            set => SetPropertyValue(nameof(Address), ref _Address, value);
        }  
        private String _Line1;
        [Size(300)]
        public String Line1
        {
            get => _Line1;
            set => SetPropertyValue(nameof(Line1), ref _Line1, value);
        }  
        private String _Line2;
        [Size(300)]
        public String Line2
        {
            get => _Line2;
            set => SetPropertyValue(nameof(Line2), ref _Line2, value);
        }  
        private String _City;
        [Size(300)]
        public String City
        {
            get => _City;
            set => SetPropertyValue(nameof(City), ref _City, value);
        }  
        private String _State;
        [Size(300)]
        public String State
        {
            get => _State;
            set => SetPropertyValue(nameof(State), ref _State, value);
        }  
        private String _PostalCode;
        [Size(300)]
        public String PostalCode
        {
            get => _PostalCode;
            set => SetPropertyValue(nameof(PostalCode), ref _PostalCode, value);
        }  
        private String _AlternatePhone;
        [Size(300)]
        public String AlternatePhone
        {
            get => _AlternatePhone;
            set => SetPropertyValue(nameof(AlternatePhone), ref _AlternatePhone, value);
        }  
        private String _Email;
        [Size(300)]
        public String Email
        {
            get => _Email;
            set => SetPropertyValue(nameof(Email), ref _Email, value);
        }  
        private String _PrintAs;
        [Size(300)]
        public String PrintAs
        {
            get => _PrintAs;
            set => SetPropertyValue(nameof(PrintAs), ref _PrintAs, value);
        }  
        private String _MobilePhone;
        [Size(300)]
        public String MobilePhone
        {
            get => _MobilePhone;
            set => SetPropertyValue(nameof(MobilePhone), ref _MobilePhone, value);
        }  
        private String _Pager;
        [Size(300)]
        public String Pager
        {
            get => _Pager;
            set => SetPropertyValue(nameof(Pager), ref _Pager, value);
        }  
        private String _PagerPin;
        [Size(300)]
        public String PagerPin
        {
            get => _PagerPin;
            set => SetPropertyValue(nameof(PagerPin), ref _PagerPin, value);
        }  
        private String _Fax;
        [Size(300)]
        public String Fax
        {
            get => _Fax;
            set => SetPropertyValue(nameof(Fax), ref _Fax, value);
        }  
        private DateTime? _BirthDate;
        public DateTime? BirthDate
        {
            get => _BirthDate;
            set => SetPropertyValue(nameof(BirthDate), ref _BirthDate, value);
        }  
        private String _Uscitizen;
        [Size(300)]
        public String Uscitizen
        {
            get => _Uscitizen;
            set => SetPropertyValue(nameof(Uscitizen), ref _Uscitizen, value);
        }  
        private String _Ethnicity;
        [Size(300)]
        public String Ethnicity
        {
            get => _Ethnicity;
            set => SetPropertyValue(nameof(Ethnicity), ref _Ethnicity, value);
        }  
        private String _Disabled;
        [Size(300)]
        public String Disabled
        {
            get => _Disabled;
            set => SetPropertyValue(nameof(Disabled), ref _Disabled, value);
        }  
        private String _DisabilityDescription;
        [Size(300)]
        public String DisabilityDescription
        {
            get => _DisabilityDescription;
            set => SetPropertyValue(nameof(DisabilityDescription), ref _DisabilityDescription, value);
        }  
        private String _FormOnFile;
        [Size(300)]
        public String FormOnFile
        {
            get => _FormOnFile;
            set => SetPropertyValue(nameof(FormOnFile), ref _FormOnFile, value);
        }  
        private String _Usveteran;
        [Size(300)]
        public String Usveteran
        {
            get => _Usveteran;
            set => SetPropertyValue(nameof(Usveteran), ref _Usveteran, value);
        }  
        private String _MilitaryStatus;
        [Size(300)]
        public String MilitaryStatus
        {
            get => _MilitaryStatus;
            set => SetPropertyValue(nameof(MilitaryStatus), ref _MilitaryStatus, value);
        }  
        private DateTime? _HiredDate;
        public DateTime? HiredDate
        {
            get => _HiredDate;
            set => SetPropertyValue(nameof(HiredDate), ref _HiredDate, value);
        }  
        private Boolean? _IsActive;
        public Boolean? IsActive
        {
            get => _IsActive;
            set => SetPropertyValue(nameof(IsActive), ref _IsActive, value);
        }  
        private String _Notes;
        [Size(300)]
        public String Notes
        {
            get => _Notes;
            set => SetPropertyValue(nameof(Notes), ref _Notes, value);
        }  
        private String _PayPeriod;
        [Size(300)]
        public String PayPeriod
        {
            get => _PayPeriod;
            set => SetPropertyValue(nameof(PayPeriod), ref _PayPeriod, value);
        }  
        private String _PayrollClassName;
        [Size(300)]
        public String PayrollClassName
        {
            get => _PayrollClassName;
            set => SetPropertyValue(nameof(PayrollClassName), ref _PayrollClassName, value);
        }  
        private String _PayrollClassId;
        [Size(300)]
        public String PayrollClassId
        {
            get => _PayrollClassId;
            set => SetPropertyValue(nameof(PayrollClassId), ref _PayrollClassId, value);
        }  
        private String _Phone;
        [Size(300)]
        public String Phone
        {
            get => _Phone;
            set => SetPropertyValue(nameof(Phone), ref _Phone, value);
        }  
        private DateTime? _ReleasedDate;
        public DateTime? ReleasedDate
        {
            get => _ReleasedDate;
            set => SetPropertyValue(nameof(ReleasedDate), ref _ReleasedDate, value);
        }  
        private String _TimeDataForPaychecks;
        [Size(300)]
        public String TimeDataForPaychecks
        {
            get => _TimeDataForPaychecks;
            set => SetPropertyValue(nameof(TimeDataForPaychecks), ref _TimeDataForPaychecks, value);
        }  
        private String _SickTimeAccrualPeriod;
        [Size(300)]
        public String SickTimeAccrualPeriod
        {
            get => _SickTimeAccrualPeriod;
            set => SetPropertyValue(nameof(SickTimeAccrualPeriod), ref _SickTimeAccrualPeriod, value);
        }  
        private DateTime? _SickTimeAccrualStartDate;
        public DateTime? SickTimeAccrualStartDate
        {
            get => _SickTimeAccrualStartDate;
            set => SetPropertyValue(nameof(SickTimeAccrualStartDate), ref _SickTimeAccrualStartDate, value);
        }  
        private String _SickTimeAccrued;
        [Size(300)]
        public String SickTimeAccrued
        {
            get => _SickTimeAccrued;
            set => SetPropertyValue(nameof(SickTimeAccrued), ref _SickTimeAccrued, value);
        }  
        private String _SickTimeAvailable;
        [Size(300)]
        public String SickTimeAvailable
        {
            get => _SickTimeAvailable;
            set => SetPropertyValue(nameof(SickTimeAvailable), ref _SickTimeAvailable, value);
        }  
        private String _SickTimeMaximum;
        [Size(300)]
        public String SickTimeMaximum
        {
            get => _SickTimeMaximum;
            set => SetPropertyValue(nameof(SickTimeMaximum), ref _SickTimeMaximum, value);
        }  
        private Boolean? _SickTimeYearlyReset;
        public Boolean? SickTimeYearlyReset
        {
            get => _SickTimeYearlyReset;
            set => SetPropertyValue(nameof(SickTimeYearlyReset), ref _SickTimeYearlyReset, value);
        }  
        private String _SickTimeUsed;
        [Size(300)]
        public String SickTimeUsed
        {
            get => _SickTimeUsed;
            set => SetPropertyValue(nameof(SickTimeUsed), ref _SickTimeUsed, value);
        }  
        private String _VacationTimeAccrualPeriod;
        [Size(300)]
        public String VacationTimeAccrualPeriod
        {
            get => _VacationTimeAccrualPeriod;
            set => SetPropertyValue(nameof(VacationTimeAccrualPeriod), ref _VacationTimeAccrualPeriod, value);
        }  
        private DateTime? _VacationTimeAccrualStartDate;
        public DateTime? VacationTimeAccrualStartDate
        {
            get => _VacationTimeAccrualStartDate;
            set => SetPropertyValue(nameof(VacationTimeAccrualStartDate), ref _VacationTimeAccrualStartDate, value);
        }  
        private String _VacationTimeAccrued;
        [Size(300)]
        public String VacationTimeAccrued
        {
            get => _VacationTimeAccrued;
            set => SetPropertyValue(nameof(VacationTimeAccrued), ref _VacationTimeAccrued, value);
        }  
        private String _VacationTimeAvailable;
        [Size(300)]
        public String VacationTimeAvailable
        {
            get => _VacationTimeAvailable;
            set => SetPropertyValue(nameof(VacationTimeAvailable), ref _VacationTimeAvailable, value);
        }  
        private String _VacationTimeMaximum;
        [Size(300)]
        public String VacationTimeMaximum
        {
            get => _VacationTimeMaximum;
            set => SetPropertyValue(nameof(VacationTimeMaximum), ref _VacationTimeMaximum, value);
        }  
        private Boolean? _VacationTimeYearlyReset;
        public Boolean? VacationTimeYearlyReset
        {
            get => _VacationTimeYearlyReset;
            set => SetPropertyValue(nameof(VacationTimeYearlyReset), ref _VacationTimeYearlyReset, value);
        }  
        private String _VacationTimeUsed;
        [Size(300)]
        public String VacationTimeUsed
        {
            get => _VacationTimeUsed;
            set => SetPropertyValue(nameof(VacationTimeUsed), ref _VacationTimeUsed, value);
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
        public const string QueryableProperties="Id,Name,Salutation,FirstName,MiddleInitial,LastName,JobTitle,AccountNumber,Ssn,EmployeeType,Gender,Address,Line1,Line2,City,State,PostalCode,AlternatePhone,Email,PrintAs,MobilePhone,Pager,PagerPin,Fax,BirthDate,Uscitizen,Ethnicity,Disabled,DisabilityDescription,FormOnFile,Usveteran,MilitaryStatus,HiredDate,IsActive,Notes,PayPeriod,PayrollClassName,PayrollClassId,Phone,ReleasedDate,TimeDataForPaychecks,SickTimeAccrualPeriod,SickTimeAccrualStartDate,SickTimeAccrued,SickTimeAvailable,SickTimeMaximum,SickTimeYearlyReset,SickTimeUsed,VacationTimeAccrualPeriod,VacationTimeAccrualStartDate,VacationTimeAccrued,VacationTimeAvailable,VacationTimeMaximum,VacationTimeYearlyReset,VacationTimeUsed,CustomFields,EditSequence,TimeModified,TimeCreated";
        public const string QuickbooksTableName="Employees";
    }
}