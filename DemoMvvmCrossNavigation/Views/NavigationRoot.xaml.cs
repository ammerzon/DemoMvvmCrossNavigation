using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DemoMvvmCrossNavigation.Helpers;
using DemoMvvmCrossNavigation.ViewModels;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.Views
{
    public abstract class NavigationRootAbstract : BaseApplicationMvxPage<NavigationRootViewModel>
    {
    }

    [MvxViewFor(typeof(NavigationRootViewModel))]
    public sealed partial class NavigationRoot : NavigationRootAbstract
    {
        public NavigationRoot()
        {
            this.InitializeComponent();
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            switch (args.InvokedItem as string)
            {
                case "Main":
                    ViewModel.ShowMain();
                    break;
                default:
                    break;
            }
        }

        private void NavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (FrameContent.CanGoBack)
            {
                FrameContent.GoBack();
            }
        }
    }
}
