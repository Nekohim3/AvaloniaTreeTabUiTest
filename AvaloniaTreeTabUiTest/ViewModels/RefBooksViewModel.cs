using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using AvaloniaTreeTabWindowManager.Utils.TabControl;
using AvaloniaTreeTabWindowManager.ViewModels;

namespace AvaloniaTreeTabUiTest.ViewModels
{
    public class RefBooksViewModel : TabViewModelBase
    {
        public ReactiveCommand<Unit, Unit> AnswersCmd { get; }

        public RefBooksViewModel()
        {
            AnswersCmd = ReactiveCommand.Create(OnAnswers);
        }

        private void OnAnswers()
        {
            TabViewControl.SwitchView(TabViewControl.Tree.Root);
        }
    }
}
