using System.Configuration;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ApplicationBuilder;
using DevExpress.ExpressApp.Win.ApplicationBuilder;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.XtraEditors;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.ExpressApp.Design;

namespace QuickBooksSync.Win;

public class ApplicationBuilder : IDesignTimeApplicationFactory {
    public static WinApplication BuildApplication(string connectionString) {
        var builder = WinApplication.CreateBuilder();
        builder.UseApplication<QuickBooksSyncWindowsFormsApplication>();
        builder.Modules
            .AddAuditTrailXpo(options => {
                options.AuditDataItemPersistentType = typeof(DevExpress.Persistent.BaseImpl.AuditDataItemPersistent);
            })
            .AddCharts()
            .AddCloningXpo()
            .AddConditionalAppearance()
            .AddDashboards(options => {
                options.DashboardDataType = typeof(DevExpress.Persistent.BaseImpl.DashboardData);
                options.DesignerFormStyle = DevExpress.XtraBars.Ribbon.RibbonFormStyle.Ribbon;
            })
            .AddFileAttachments()
            .AddKpi()
            .AddNotifications()
            .AddOffice()
            .AddPivotChart()
            .AddPivotGrid()
            .AddReports(options => {
                options.EnableInplaceReports = true;
                options.ReportDataType = typeof(DevExpress.Persistent.BaseImpl.ReportDataV2);
                options.ReportStoreMode = DevExpress.ExpressApp.ReportsV2.ReportStoreModes.XML;
            })
            .AddScheduler()
#if DEBUG
            .AddScriptRecorder()
#endif
            .AddStateMachine(options => {
                options.StateMachineStorageType = typeof(DevExpress.ExpressApp.StateMachine.Xpo.XpoStateMachine);
            })
            .AddTreeListEditors()
            .AddValidation(options => {
                options.AllowValidationDetailsAccess = false;
            })
            .AddViewVariants()
            .Add<QuickBooksSync.Module.QuickBooksSyncModule>()
        	.Add<QuickBooksSyncWinModule>();
        builder.ObjectSpaceProviders
            .AddSecuredXpo((application, options) => {
                options.ConnectionString = connectionString;
            })
            .AddNonPersistent();
        builder.Security
            .UseIntegratedMode(options => {
                options.RoleType = typeof(PermissionPolicyRole);
                options.UserType = typeof(QuickBooksSync.Module.BusinessObjects.ApplicationUser);
                options.UserLoginInfoType = typeof(QuickBooksSync.Module.BusinessObjects.ApplicationUserLoginInfo);
                options.UseXpoPermissionsCaching();
            })
            .UsePasswordAuthentication();
        builder.AddBuildStep(application => {
            application.ConnectionString = connectionString;
#if DEBUG
            if(System.Diagnostics.Debugger.IsAttached && application.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                application.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            }
#endif
        });
        var winApplication = builder.Build();
        return winApplication;
    }

    XafApplication IDesignTimeApplicationFactory.Create()
        => BuildApplication(XafApplication.DesignTimeConnectionString);
}
