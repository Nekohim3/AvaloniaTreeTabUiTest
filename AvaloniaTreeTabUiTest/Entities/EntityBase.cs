using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaloniaUtils.Utils.ViewModels;

namespace AvaloniaTreeTabUiTest.Entities
{
    public class EntityBase : ViewModelBase
    {
        public int Id { get; set; }

        public EntityBase(int id)
        {
            Id = id;
        }
    }
}
