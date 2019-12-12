using Windows.UI.Xaml.Controls;
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
            InitializeComponent();
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            switch (args.InvokedItem as string)
            {
                case "Main":
                    ViewModel.ShowMain();
                    break;
            }
        }

        private void NavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (FrameContent.CanGoBack) FrameContent.GoBack();
        }
    }
}