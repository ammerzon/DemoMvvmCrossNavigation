using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.ViewModels
{
    public class MainViewModel: MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void ShowDetail(string data)
        {
            _navigationService.Navigate<DetailViewModel, string>(data);
        }
    }
}
