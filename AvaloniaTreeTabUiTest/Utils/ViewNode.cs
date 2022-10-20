using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaloniaTreeTabUiTest.Entities;
using AvaloniaTreeTabWindowManager.Utils.TreeCollections;
using AvaloniaTreeTabWindowManager.ViewModels;
using ReactiveUI;

namespace AvaloniaTreeTabUiTest.Utils
{
    public class ViewNode : ViewNodeBase
    {
        private Ship? _ship;

        public Ship? Ship
        {
            get => _ship;
            set => this.RaiseAndSetIfChanged(ref _ship, value);
        }

        public ViewNode(TabViewModelBase vm, Ship? ship, ViewNodeBase? parent = null) : base(vm, parent)
        {
            _ship = ship;
        }

        public ViewNode(TabViewModelBase vm, ViewNode? parent = null) : base(vm, parent)
        {
            _ship = parent?.Ship;
        }
    }
}
