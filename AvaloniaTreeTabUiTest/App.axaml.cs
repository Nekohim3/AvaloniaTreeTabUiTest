using System.Collections.Generic;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaTreeTabUiTest.ViewModels;
using AvaloniaTreeTabUiTest.Views;
using AvaloniaTreeTabWindowManager.Utils.TabControl;
using AvaloniaTreeTabWindowManager.Utils.TreeCollections;
using AvaloniaTreeTabWindowManager.ViewModels;
using AvaloniaTreeTabWindowManager.Views;
using AvaloniaUtils.Utils;
using AvaloniaUtils.Utils.Collections;
using AvaloniaUtils.Utils.ViewModels;
using ReactiveUI;
using Splat;

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
            g.CurrentModule = ProgramModules.Ship;
            //Locator.CurrentMutable.Register(() => new RefBooksViewModel(1), "RefBooksViewModelInt");
            //Locator.CurrentMutable.Register(() => new RefBooksViewModel("1"), "RefBooksViewModelString");
            //Locator.CurrentMutable.Register(() => new RefBooksViewModel("1", 1), "RefBooksViewModelStringInt");
            //Locator.CurrentMutable.Register(() => new RefBooksViewModel(), "RefBooksViewModel");
            //var q1  = Locator.Current.GetService<RefBooksViewModel>("RefBooksViewModel");
            //var q2  = Locator.Current.GetService<RefBooksViewModel>("RefBooksViewModelString");
            //var q3  = Locator.Current.GetService<RefBooksViewModel>("RefBooksViewModelStringInt");
            //var q4  = Locator.Current.GetService<RefBooksViewModel>("RefBooksViewModelInt");
            //var lst = new ObservableCollectionWithSelectedItem<Test>(true);
            //lst.Add(new Test("qwe"));
            //lst.Add(new Test("asd"));
            //lst.Add(new Test("zxc"));
            //lst.Add(new Test("wer"));
            //lst.Add(new Test("sdf"));
            //lst.Add(new Test("xcv"));
            //lst.Add(new Test("ert"));
            //lst.Add(new Test("dfg"));
            //lst.Add(new Test("cvb"));
            //lst.SelectionChanging += LstOnSelectionChanging;
            //lst.SelectionChanged += LstOnSelectionChanged;


            //lst.SetSelectedToFirst();
            //lst.SetSelectedToLast();
            //lst.SetSelectedTo(lst[3]);
            //lst.SetSelectedToId(0);
            //lst.SetSelectedToPosition(5);
            //lst.SelectedItem = lst[3];
            //lst.SelectedItem = lst[8];

            //lst.AddSelected(lst[0]);
            //lst.AddSelected(lst[1]);
            //lst.RemoveSelected(lst[8]);
            //lst.RemoveSelected(lst[1]);

            //lst.SetSelectedToFirst();
            //lst.SetSelectedToLast();
            //lst.SetSelectedTo(lst[3]);
            //lst.SetSelectedToId(0);
            //lst.SetSelectedToPosition(5);
            //lst.SelectedItem = lst[3];
            //lst.SelectedItem = lst[8];
            //lst.SelectedItem = null;
            //lst.ClearSelection();
            //lst.RemoveSelected(lst[8]);

            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                var wnd  = new TabWindow();
                var root = new ViewNode(new MainViewModel());
                var vm   = new TabWindowViewModel(wnd, root.ViewModel);
                wnd.DataContext    = vm;
                TabViewControl.Init(vm, root);
                desktop.MainWindow = wnd;
            }

            base.OnFrameworkInitializationCompleted();
        }
        
        private bool LstOnSelectionChanging(ObservableCollectionWithSelectedItem<Test> sender, IList<Test>? addeditems, IList<Test>? removeditems)
        {
            return true;
        }

        private void LstOnSelectionChanged(ObservableCollectionWithSelectedItem<Test> sender, IList<Test>? addeditems, IList<Test>? removeditems)
        {
            
        }
    }

    public class Test : ViewModelBase, ISelected
    {
        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set => _isSelected = value;
        }

        private string _str;

        public string Str
        {
            get => _str;
            set => this.RaiseAndSetIfChanged(ref _str, value);
        }

        public Test(string str)
        {
            _str = str;
        }
    }
}
