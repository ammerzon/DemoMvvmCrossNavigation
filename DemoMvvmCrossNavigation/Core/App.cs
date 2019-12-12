using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ViewModels.NavigationRootViewModel>();
        }
    }
}
