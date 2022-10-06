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
    public class CustomColumn : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public CustomColumn(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
         
        private String? _DataExtId;
        public String? DataExtId
        {
            get => _DataExtId;
            set => SetPropertyValue(nameof(DataExtId), ref _DataExtId, value);
        }  
        private String? _OwnerId;
        public String? OwnerId
        {
            get => _OwnerId;
            set => SetPropertyValue(nameof(OwnerId), ref _OwnerId, value);
        }  
        private String? _DataExtName;
        public String? DataExtName
        {
            get => _DataExtName;
            set => SetPropertyValue(nameof(DataExtName), ref _DataExtName, value);
        }  
        private String? _DataExtType;
        public String? DataExtType
        {
            get => _DataExtType;
            set => SetPropertyValue(nameof(DataExtType), ref _DataExtType, value);
        }  
        private String? _AssignToObject;
        public String? AssignToObject
        {
            get => _AssignToObject;
            set => SetPropertyValue(nameof(AssignToObject), ref _AssignToObject, value);
        }  
        private Boolean _DataExtListRequire;
        public Boolean DataExtListRequire
        {
            get => _DataExtListRequire;
            set => SetPropertyValue(nameof(DataExtListRequire), ref _DataExtListRequire, value);
        }  
        private Boolean _DataExtTxnRequire;
        public Boolean DataExtTxnRequire
        {
            get => _DataExtTxnRequire;
            set => SetPropertyValue(nameof(DataExtTxnRequire), ref _DataExtTxnRequire, value);
        }  
        private String? _DataExtFormatString;
        public String? DataExtFormatString
        {
            get => _DataExtFormatString;
            set => SetPropertyValue(nameof(DataExtFormatString), ref _DataExtFormatString, value);
        }
        public const string QueriableProperties="DataExtId,OwnerId,DataExtName,DataExtType,AssignToObject,DataExtListRequire,DataExtTxnRequire,DataExtFormatString";
    }
}