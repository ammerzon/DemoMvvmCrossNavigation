using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.ViewModels
{
    public class NavigationRootViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public NavigationRootViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();
            ShowMain();
        }

        public void ShowMain()
        {
            _navigationService.Navigate<MainViewModel>();
        }
    }
}