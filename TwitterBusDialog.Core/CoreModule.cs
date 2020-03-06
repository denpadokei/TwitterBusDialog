using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using TwitterBusDialog.Core.Interfaces;
using TwitterBusDialog.Core.Services;

namespace TwitterBusDialog.Core
{
    public class CoreModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ICustomDialogService, CustomDialogService>();
        }
    }
}