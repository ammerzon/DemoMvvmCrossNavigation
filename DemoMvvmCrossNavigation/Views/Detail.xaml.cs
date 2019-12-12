using DemoMvvmCrossNavigation.ViewModels;
using MvvmCross.Platforms.Uap.Presenters.Attributes;
using MvvmCross.Platforms.Uap.Views;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.Views
{
    [MvxViewFor(typeof(DetailViewModel))]
    [MvxSplitViewPresentation(SplitPanePosition.Content)]
    public sealed partial class Detail : MvxWindowsPage
    {
        public Detail()
        {
            InitializeComponent();
        }
    }
}