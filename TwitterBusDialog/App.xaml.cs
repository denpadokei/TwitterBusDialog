using Prism.Ioc;
using TwitterBusDialog.Views;
using System.Windows;
using Prism.Regions;

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

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Main>();
            containerRegistry.RegisterDialog<OKDialog>();
            containerRegistry.RegisterDialogWindow<CustomDialogWindow>();
        }
    }
}
