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
            this.InitializeComponent();
        }
    }
}
