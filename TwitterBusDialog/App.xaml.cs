using Prism.Ioc;
using TwitterBusDialog.Views;
using System.Windows;
using Prism.Regions;
using Prism.Modularity;
using TwitterBusDialog.Core;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace TwitterBusDialog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var regionManager = this.Container.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegion", "Main");
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            // NLog ログの設定
            var config = new LoggingConfiguration();

            var file = new FileTarget("logfile") { FileName = "log.txt", ConcurrentWrites = true };
            var consol = new ConsoleTarget("console");

            config.AddRule(LogLevel.Trace, LogLevel.Fatal, file);
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, consol);

            LogManager.Configuration = config;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Main>();
            containerRegistry.RegisterDialog<OKDialog>();
            containerRegistry.RegisterDialog<AbortRetryIgnoreDialog>();
            containerRegistry.RegisterDialog<OKCancelDialog>();
            containerRegistry.RegisterDialog<RetryCancelDialog>();
            containerRegistry.RegisterDialog<YesNoCancelDialog>();
            containerRegistry.RegisterDialog<YesNoDialog>();
            containerRegistry.RegisterDialogWindow<CustomDialogWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<CoreModule>();
        }
    }
}
