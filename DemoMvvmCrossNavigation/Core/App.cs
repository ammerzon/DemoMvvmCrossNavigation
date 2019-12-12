using DemoMvvmCrossNavigation.ViewModels;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<NavigationRootViewModel>();
        }
    }
}