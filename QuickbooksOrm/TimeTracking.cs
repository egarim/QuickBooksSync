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
    public class TimeTracking : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public TimeTracking(Session session)
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
        private String _BillableStatus;
        [Size(300)]
        public String BillableStatus
        {
            get => _BillableStatus;
            set => SetPropertyValue(nameof(BillableStatus), ref _BillableStatus, value);
        }  
        private DateTime? _Date;
        public DateTime? Date
        {
            get => _Date;
            set => SetPropertyValue(nameof(Date), ref _Date, value);
        }  
        private String _CustomerName;
        [Size(300)]
        public String CustomerName
        {
            get => _CustomerName;
            set => SetPropertyValue(nameof(CustomerName), ref _CustomerName, value);
        }  
        private String _CustomerId;
        [Size(300)]
        public String CustomerId
        {
            get => _CustomerId;
            set => SetPropertyValue(nameof(CustomerId), ref _CustomerId, value);
        }  
        private String _Duration;
        [Size(300)]
        public String Duration
        {
            get => _Duration;
            set => SetPropertyValue(nameof(Duration), ref _Duration, value);
        }  
        private String _EmployeeName;
        [Size(300)]
        public String EmployeeName
        {
            get => _EmployeeName;
            set => SetPropertyValue(nameof(EmployeeName), ref _EmployeeName, value);
        }  
        private String _EmployeeId;
        [Size(300)]
        public String EmployeeId
        {
            get => _EmployeeId;
            set => SetPropertyValue(nameof(EmployeeId), ref _EmployeeId, value);
        }  
        private String _Notes;
        [Size(300)]
        public String Notes
        {
            get => _Notes;
            set => SetPropertyValue(nameof(Notes), ref _Notes, value);
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
        private String _PayrollWageItemName;
        [Size(300)]
        public String PayrollWageItemName
        {
            get => _PayrollWageItemName;
            set => SetPropertyValue(nameof(PayrollWageItemName), ref _PayrollWageItemName, value);
        }  
        private String _PayrollWageItemId;
        [Size(300)]
        public String PayrollWageItemId
        {
            get => _PayrollWageItemId;
            set => SetPropertyValue(nameof(PayrollWageItemId), ref _PayrollWageItemId, value);
        }  
        private String _ServiceItemName;
        [Size(300)]
        public String ServiceItemName
        {
            get => _ServiceItemName;
            set => SetPropertyValue(nameof(ServiceItemName), ref _ServiceItemName, value);
        }  
        private String _ServiceItemId;
        [Size(300)]
        public String ServiceItemId
        {
            get => _ServiceItemId;
            set => SetPropertyValue(nameof(ServiceItemId), ref _ServiceItemId, value);
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
        public const string QueryableProperties="Id,BillableStatus,Date,CustomerName,CustomerId,Duration,EmployeeName,EmployeeId,Notes,Class,ClassId,PayrollWageItemName,PayrollWageItemId,ServiceItemName,ServiceItemId,EditSequence,TimeModified,TimeCreated";
    }
}