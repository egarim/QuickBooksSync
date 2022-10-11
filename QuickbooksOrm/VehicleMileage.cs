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
    public class VehicleMileage : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public VehicleMileage(Session session)
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
        private String _VehicleRefFullName;
        [Size(300)]
        public String VehicleRefFullName
        {
            get => _VehicleRefFullName;
            set => SetPropertyValue(nameof(VehicleRefFullName), ref _VehicleRefFullName, value);
        }  
        private String _VehicleRefListId;
        [Size(300)]
        public String VehicleRefListId
        {
            get => _VehicleRefListId;
            set => SetPropertyValue(nameof(VehicleRefListId), ref _VehicleRefListId, value);
        }  
        private String _CustomerRefFullName;
        [Size(300)]
        public String CustomerRefFullName
        {
            get => _CustomerRefFullName;
            set => SetPropertyValue(nameof(CustomerRefFullName), ref _CustomerRefFullName, value);
        }  
        private String _CustomerRefListId;
        [Size(300)]
        public String CustomerRefListId
        {
            get => _CustomerRefListId;
            set => SetPropertyValue(nameof(CustomerRefListId), ref _CustomerRefListId, value);
        }  
        private String _ItemRefFullName;
        [Size(300)]
        public String ItemRefFullName
        {
            get => _ItemRefFullName;
            set => SetPropertyValue(nameof(ItemRefFullName), ref _ItemRefFullName, value);
        }  
        private String _ItemRefListId;
        [Size(300)]
        public String ItemRefListId
        {
            get => _ItemRefListId;
            set => SetPropertyValue(nameof(ItemRefListId), ref _ItemRefListId, value);
        }  
        private String _ClassRefFullName;
        [Size(300)]
        public String ClassRefFullName
        {
            get => _ClassRefFullName;
            set => SetPropertyValue(nameof(ClassRefFullName), ref _ClassRefFullName, value);
        }  
        private String _ClassRefListId;
        [Size(300)]
        public String ClassRefListId
        {
            get => _ClassRefListId;
            set => SetPropertyValue(nameof(ClassRefListId), ref _ClassRefListId, value);
        }  
        private String _TripStartDate;
        [Size(300)]
        public String TripStartDate
        {
            get => _TripStartDate;
            set => SetPropertyValue(nameof(TripStartDate), ref _TripStartDate, value);
        }  
        private String _TripEndDate;
        [Size(300)]
        public String TripEndDate
        {
            get => _TripEndDate;
            set => SetPropertyValue(nameof(TripEndDate), ref _TripEndDate, value);
        }  
        private Int32? _OdometerStart;
        public Int32? OdometerStart
        {
            get => _OdometerStart;
            set => SetPropertyValue(nameof(OdometerStart), ref _OdometerStart, value);
        }  
        private Int32? _OdometerEnd;
        public Int32? OdometerEnd
        {
            get => _OdometerEnd;
            set => SetPropertyValue(nameof(OdometerEnd), ref _OdometerEnd, value);
        }  
        private Single? _TotalMiles;
        public Single? TotalMiles
        {
            get => _TotalMiles;
            set => SetPropertyValue(nameof(TotalMiles), ref _TotalMiles, value);
        }  
        private String _Notes;
        [Size(300)]
        public String Notes
        {
            get => _Notes;
            set => SetPropertyValue(nameof(Notes), ref _Notes, value);
        }  
        private String _BillableStatus;
        [Size(300)]
        public String BillableStatus
        {
            get => _BillableStatus;
            set => SetPropertyValue(nameof(BillableStatus), ref _BillableStatus, value);
        }  
        private Single? _StandardMileageRate;
        public Single? StandardMileageRate
        {
            get => _StandardMileageRate;
            set => SetPropertyValue(nameof(StandardMileageRate), ref _StandardMileageRate, value);
        }  
        private Single? _StandardMileageTotalAmount;
        public Single? StandardMileageTotalAmount
        {
            get => _StandardMileageTotalAmount;
            set => SetPropertyValue(nameof(StandardMileageTotalAmount), ref _StandardMileageTotalAmount, value);
        }  
        private Single? _BillableRate;
        public Single? BillableRate
        {
            get => _BillableRate;
            set => SetPropertyValue(nameof(BillableRate), ref _BillableRate, value);
        }  
        private Decimal? _BillableAmount;
        public Decimal? BillableAmount
        {
            get => _BillableAmount;
            set => SetPropertyValue(nameof(BillableAmount), ref _BillableAmount, value);
        }  
        private String _EditSequence;
        [Size(300)]
        public String EditSequence
        {
            get => _EditSequence;
            set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
        }  
        private DateTime? _TimeCreated;
        public DateTime? TimeCreated
        {
            get => _TimeCreated;
            set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
        }  
        private DateTime? _TimeModified;
        public DateTime? TimeModified
        {
            get => _TimeModified;
            set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
        }
        public const string QueryableProperties="Id,VehicleRefFullName,VehicleRefListId,CustomerRefFullName,CustomerRefListId,ItemRefFullName,ItemRefListId,ClassRefFullName,ClassRefListId,TripStartDate,TripEndDate,OdometerStart,OdometerEnd,TotalMiles,Notes,BillableStatus,StandardMileageRate,StandardMileageTotalAmount,BillableRate,BillableAmount,EditSequence,TimeCreated,TimeModified";
        public const string QuickbooksTableName="VehicleMileage";
    }
}