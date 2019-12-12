using DemoMvvmCrossNavigation.Helpers;
using MvvmCross.Platforms.Uap.Views;

namespace DemoMvvmCrossNavigation
{
    /// <summary>
    ///     Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    internal sealed partial class App
    {
        /// <summary>
        ///     Initializes the singleton application object.  This is the first line of authored code
        ///     executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class DemoMvvmCrossNavigation : MvxApplication<Setup, Core.App>
    {
    }
}