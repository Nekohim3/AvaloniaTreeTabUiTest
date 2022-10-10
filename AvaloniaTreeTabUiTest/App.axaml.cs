using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaTreeTabUiTest.ViewModels;
using AvaloniaTreeTabUiTest.Views;
using AvaloniaTreeTabWindowManager.Utils.TabControl;
using AvaloniaTreeTabWindowManager.Utils.TreeCollections;
using AvaloniaTreeTabWindowManager.ViewModels;
using AvaloniaTreeTabWindowManager.Views;

namespace AvaloniaTreeTabUiTest
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var wnd  = new TabWindow();
                var root = new ViewNode(new MainViewModel());
                var vm   = new TabWindowViewModel(wnd, root.ViewModel);
                wnd.DataContext    = vm;
                TabViewControl.Init(vm, root);
                //g.TabViewControl   = new TabViewControl(vm, root);
                desktop.MainWindow = wnd;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
