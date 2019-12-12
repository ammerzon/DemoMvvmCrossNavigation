using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using MvvmCross.Platforms.Uap.Core;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.Helpers
{
    public class Setup : MvxWindowsSetup<Core.App>
    {
        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
