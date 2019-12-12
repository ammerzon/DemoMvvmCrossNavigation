using Windows.UI.Xaml;
using DemoMvvmCrossNavigation.Helpers;
using DemoMvvmCrossNavigation.ViewModels;
using MvvmCross.Platforms.Uap.Presenters.Attributes;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.Views
{
    public abstract class MainAbstract : BaseApplicationMvxPage<MainViewModel>
    {
    }

    [MvxViewFor(typeof(MainViewModel))]
    [MvxSplitViewPresentation(SplitPanePosition.Content)]
    public sealed partial class Main : MainAbstract
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ShowDetail_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.ShowDetail("Data");
        }
    }
}