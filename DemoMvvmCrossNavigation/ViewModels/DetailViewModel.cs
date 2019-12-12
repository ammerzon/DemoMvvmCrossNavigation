using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace DemoMvvmCrossNavigation.ViewModels
{
    public class DetailViewModel : MvxViewModel<string>
    {
        public override void Prepare(string param)
        {
            // do something with param
        }
    }
}
