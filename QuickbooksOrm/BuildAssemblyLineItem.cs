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

    //TODO fix type

    //[DefaultClassOptions]
    //[NavigationItem("Quickbooks Data")]
    ////[ImageName("BO_Contact")]
    ////[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    ////[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    ////[Persistent("DatabaseTableName")]
    //// Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    //public class BuildAssemblyLineItem : XPLiteObject
    //{ // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    //    // Use CodeRush to create XPO classes and properties with a few keystrokes.
    //    // https://docs.devexpress.com/CodeRushForRoslyn/118557
    //    public BuildAssemblyLineItem(Session session)
    //        : base(session)
    //    {
    //    }
    //    public override void AfterConstruction()
    //    {
    //        base.AfterConstruction();
    //        // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    //    }
         
    //    private string _Id;
    //    [Key(false)]
    //    public string Id
    //    {
    //        get => _Id;
    //        set => SetPropertyValue(nameof(Id), ref _Id, value);
    //    }  
    //    private String _BuildAssemblyId;
    //    [Size(300)]
    //    public String BuildAssemblyId
    //    {
    //        get => _BuildAssemblyId;
    //        set => SetPropertyValue(nameof(BuildAssemblyId), ref _BuildAssemblyId, value);
    //    }  
    //    private Int32? _TxnNumber;
    //    public Int32? TxnNumber
    //    {
    //        get => _TxnNumber;
    //        set => SetPropertyValue(nameof(TxnNumber), ref _TxnNumber, value);
    //    }  
    //    private String _ItemInventoryAssemblyRefListId;
    //    [Size(300)]
    //    public String ItemInventoryAssemblyRefListId
    //    {
    //        get => _ItemInventoryAssemblyRefListId;
    //        set => SetPropertyValue(nameof(ItemInventoryAssemblyRefListId), ref _ItemInventoryAssemblyRefListId, value);
    //    }  
    //    private String _ItemInventoryAssemblyRefFullName;
    //    [Size(300)]
    //    public String ItemInventoryAssemblyRefFullName
    //    {
    //        get => _ItemInventoryAssemblyRefFullName;
    //        set => SetPropertyValue(nameof(ItemInventoryAssemblyRefFullName), ref _ItemInventoryAssemblyRefFullName, value);
    //    }  
    //    private String _InventorySiteRefListId;
    //    [Size(300)]
    //    public String InventorySiteRefListId
    //    {
    //        get => _InventorySiteRefListId;
    //        set => SetPropertyValue(nameof(InventorySiteRefListId), ref _InventorySiteRefListId, value);
    //    }  
    //    private String _InventorySiteRefFullName;
    //    [Size(300)]
    //    public String InventorySiteRefFullName
    //    {
    //        get => _InventorySiteRefFullName;
    //        set => SetPropertyValue(nameof(InventorySiteRefFullName), ref _InventorySiteRefFullName, value);
    //    }  
    //    private String _SerialNumber;
    //    [Size(300)]
    //    public String SerialNumber
    //    {
    //        get => _SerialNumber;
    //        set => SetPropertyValue(nameof(SerialNumber), ref _SerialNumber, value);
    //    }  
    //    private String _LotNumber;
    //    [Size(300)]
    //    public String LotNumber
    //    {
    //        get => _LotNumber;
    //        set => SetPropertyValue(nameof(LotNumber), ref _LotNumber, value);
    //    }  
    //    private DateTime? _TxnDate;
    //    public DateTime? TxnDate
    //    {
    //        get => _TxnDate;
    //        set => SetPropertyValue(nameof(TxnDate), ref _TxnDate, value);
    //    }  
    //    private String _RefNumber;
    //    [Size(300)]
    //    public String RefNumber
    //    {
    //        get => _RefNumber;
    //        set => SetPropertyValue(nameof(RefNumber), ref _RefNumber, value);
    //    }  
    //    private String _Memo;
    //    [Size(300)]
    //    public String Memo
    //    {
    //        get => _Memo;
    //        set => SetPropertyValue(nameof(Memo), ref _Memo, value);
    //    }  
    //    private Boolean? _IsPending;
    //    public Boolean? IsPending
    //    {
    //        get => _IsPending;
    //        set => SetPropertyValue(nameof(IsPending), ref _IsPending, value);
    //    }  
    //    private Single? _QuantityToBuild;
    //    public Single? QuantityToBuild
    //    {
    //        get => _QuantityToBuild;
    //        set => SetPropertyValue(nameof(QuantityToBuild), ref _QuantityToBuild, value);
    //    }  
    //    private Single? _QuantityCanBuild;
    //    public Single? QuantityCanBuild
    //    {
    //        get => _QuantityCanBuild;
    //        set => SetPropertyValue(nameof(QuantityCanBuild), ref _QuantityCanBuild, value);
    //    }  
    //    private Single? _QuantityOnHand;
    //    public Single? QuantityOnHand
    //    {
    //        get => _QuantityOnHand;
    //        set => SetPropertyValue(nameof(QuantityOnHand), ref _QuantityOnHand, value);
    //    }  
    //    private Single? _QuantityOnSalesOrder;
    //    public Single? QuantityOnSalesOrder
    //    {
    //        get => _QuantityOnSalesOrder;
    //        set => SetPropertyValue(nameof(QuantityOnSalesOrder), ref _QuantityOnSalesOrder, value);
    //    }  
    //    private Boolean? _MarkPendingIfRequired;
    //    public Boolean? MarkPendingIfRequired
    //    {
    //        get => _MarkPendingIfRequired;
    //        set => SetPropertyValue(nameof(MarkPendingIfRequired), ref _MarkPendingIfRequired, value);
    //    }  
    //    private String _ExternalGuid;
    //    [Size(300)]
    //    public String ExternalGuid
    //    {
    //        get => _ExternalGuid;
    //        set => SetPropertyValue(nameof(ExternalGuid), ref _ExternalGuid, value);
    //    }  
    //    private String _ComponentItemLineRetItemRefListId;
    //    [Size(300)]
    //    public String ComponentItemLineRetItemRefListId
    //    {
    //        get => _ComponentItemLineRetItemRefListId;
    //        set => SetPropertyValue(nameof(ComponentItemLineRetItemRefListId), ref _ComponentItemLineRetItemRefListId, value);
    //    }  
    //    private String _ComponentItemLineRetItemRefFullName;
    //    [Size(300)]
    //    public String ComponentItemLineRetItemRefFullName
    //    {
    //        get => _ComponentItemLineRetItemRefFullName;
    //        set => SetPropertyValue(nameof(ComponentItemLineRetItemRefFullName), ref _ComponentItemLineRetItemRefFullName, value);
    //    }  
    //    private String _ComponentItemLineRetInventorySiteRefListId;
    //    [Size(300)]
    //    public String ComponentItemLineRetInventorySiteRefListId
    //    {
    //        get => _ComponentItemLineRetInventorySiteRefListId;
    //        set => SetPropertyValue(nameof(ComponentItemLineRetInventorySiteRefListId), ref _ComponentItemLineRetInventorySiteRefListId, value);
    //    }  
    //    private String _ComponentItemLineRetInventorySiteRefFullName;
    //    [Size(300)]
    //    public String ComponentItemLineRetInventorySiteRefFullName
    //    {
    //        get => _ComponentItemLineRetInventorySiteRefFullName;
    //        set => SetPropertyValue(nameof(ComponentItemLineRetInventorySiteRefFullName), ref _ComponentItemLineRetInventorySiteRefFullName, value);
    //    }  
    //    private String _ComponentItemLineRetDesc;
    //    [Size(300)]
    //    public String ComponentItemLineRetDesc
    //    {
    //        get => _ComponentItemLineRetDesc;
    //        set => SetPropertyValue(nameof(ComponentItemLineRetDesc), ref _ComponentItemLineRetDesc, value);
    //    }  
    //    private Single? _ComponentItemLineRetQuantityOnHand;
    //    public Single? ComponentItemLineRetQuantityOnHand
    //    {
    //        get => _ComponentItemLineRetQuantityOnHand;
    //        set => SetPropertyValue(nameof(ComponentItemLineRetQuantityOnHand), ref _ComponentItemLineRetQuantityOnHand, value);
    //    }  
    //    private Single? _ComponentItemLineRetQuantityNeeded;
    //    public Single? ComponentItemLineRetQuantityNeeded
    //    {
    //        get => _ComponentItemLineRetQuantityNeeded;
    //        set => SetPropertyValue(nameof(ComponentItemLineRetQuantityNeeded), ref _ComponentItemLineRetQuantityNeeded, value);
    //    }  
    //    private DateTime? _TimeCreated;
    //    public DateTime? TimeCreated
    //    {
    //        get => _TimeCreated;
    //        set => SetPropertyValue(nameof(TimeCreated), ref _TimeCreated, value);
    //    }  
    //    private DateTime? _TimeModified;
    //    public DateTime? TimeModified
    //    {
    //        get => _TimeModified;
    //        set => SetPropertyValue(nameof(TimeModified), ref _TimeModified, value);
    //    }  
    //    private String _EditSequence;
    //    [Size(300)]
    //    public String EditSequence
    //    {
    //        get => _EditSequence;
    //        set => SetPropertyValue(nameof(EditSequence), ref _EditSequence, value);
    //    }
    //    public const string QueryableProperties="Id,BuildAssemblyId,TxnNumber,ItemInventoryAssemblyRefListId,ItemInventoryAssemblyRefFullName,InventorySiteRefListId,InventorySiteRefFullName,SerialNumber,LotNumber,TxnDate,RefNumber,Memo,IsPending,QuantityToBuild,QuantityCanBuild,QuantityOnHand,QuantityOnSalesOrder,MarkPendingIfRequired,ExternalGuid,ComponentItemLineRetItemRefListId,ComponentItemLineRetItemRefFullName,ComponentItemLineRetInventorySiteRefListId,ComponentItemLineRetInventorySiteRefFullName,ComponentItemLineRetDesc,ComponentItemLineRetQuantityOnHand,ComponentItemLineRetQuantityNeeded,TimeCreated,TimeModified,EditSequence";
    //    public const string QuickbooksTableName="BuildAssemblyLineItems";
    //}
}