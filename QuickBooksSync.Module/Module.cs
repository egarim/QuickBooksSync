using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using QuickBooksSync.Module.BusinessObjects;
using XafWinBackgroundWorker.Module.BusinessObjects;
using DevExpress.Xpo.Metadata;
using System.Reflection;
using System.Diagnostics;
using DevExpress.Xpo.DB.Helpers;

namespace QuickBooksSync.Module;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ModuleBase.
public sealed class QuickBooksSyncModule : ModuleBase {

    public static Dictionary<Type, string> QuickbooksTables = new Dictionary<Type, string>();
    public QuickBooksSyncModule() {
		// 
		// QuickBooksSyncModule
		// 
		AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.ModelDifference));
		AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.ModelDifferenceAspect));
        AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.BaseObject));
        AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.AuditDataItemPersistent));
        AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.AuditedObjectWeakReference));
        AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.FileData));
        AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.FileAttachmentBase));
        AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Analysis));
        AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Event));
        AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.Resource));
        AdditionalExportedTypes.Add(typeof(DevExpress.Persistent.BaseImpl.HCategory));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.SystemModule.SystemModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Security.SecurityModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.AuditTrail.AuditTrailModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Chart.ChartModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.CloneObject.CloneObjectModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Dashboards.DashboardsModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Kpi.KpiModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Notifications.NotificationsModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Office.OfficeModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.PivotChart.PivotChartModuleBase));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.PivotGrid.PivotGridModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ReportsV2.ReportsModuleV2));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Scheduler.SchedulerModuleBase));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.StateMachine.StateMachineModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.TreeListEditors.TreeListEditorsModuleBase));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Validation.ValidationModule));
		RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule));

      
        var QuickbooksPersistentTypes = typeof(Account).Assembly.GetTypes().Where(t => t.BaseType == typeof(XPLiteObject)).ToList();

        var ObjectsWithoutKey = QuickbooksPersistentTypes.Where(t => t.GetProperties().Count(p => p.GetCustomAttribute<KeyAttribute>() != null) == 0).ToList();

        foreach (var item in ObjectsWithoutKey)
        {
            Debug.WriteLine($"missing key {item}");
            QuickbooksPersistentTypes.Remove(item);
        }

        foreach (var item in QuickbooksPersistentTypes)
        {



            AdditionalExportedTypes.Add(item);
            string TableName = item.GetAllPublicConstantValues<string>()[1];
            QuickbooksTables.Add(item, TableName);
        }

        //AdditionalExportedTypes.Add(typeof(Account));
        AdditionalExportedTypes.Add(typeof(BalanceSheetDetail));
        AdditionalExportedTypes.Add(typeof(BalanceSheetStandard));
        AdditionalExportedTypes.Add(typeof(BalanceSheetSummary));


        QuickbooksTables.Add(typeof(BalanceSheetDetail), "BalanceSheetDetail");
        QuickbooksTables.Add(typeof(BalanceSheetStandard), "BalanceSheetStandard");
        //QuickbooksTables.Add(typeof(BalanceSheetSummary), "BalanceSheetSummary");

        //AdditionalExportedTypes.Add(typeof(Bill));
        //AdditionalExportedTypes.Add(typeof(Class));
        //AdditionalExportedTypes.Add(typeof(CreditCardCharge));
        //AdditionalExportedTypes.Add(typeof(Customer));
        //AdditionalExportedTypes.Add(typeof(CreditCardChargeExpenseItem));
        //AdditionalExportedTypes.Add(typeof(CreditCardChargeLineItem));
        //AdditionalExportedTypes.Add(typeof(JournalEntry));
        //AdditionalExportedTypes.Add(typeof(JournalEntryLine));

    }
    public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
        ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
        return new ModuleUpdater[] { updater };
    }
    public override void Setup(XafApplication application) {
        base.Setup(application);
        // Manage various aspects of the application UI and behavior at the module level.
    }
    public override void CustomizeTypesInfo(ITypesInfo typesInfo) {
        base.CustomizeTypesInfo(typesInfo);
        CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);
    }
}
