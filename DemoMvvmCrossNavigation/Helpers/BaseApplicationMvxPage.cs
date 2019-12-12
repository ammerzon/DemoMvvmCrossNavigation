using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.Helpers
{
    public class BaseApplicationMvxPage<TViewModel> : MvxWindowsPage<TViewModel> where TViewModel : MvxViewModel
    {
    }
}