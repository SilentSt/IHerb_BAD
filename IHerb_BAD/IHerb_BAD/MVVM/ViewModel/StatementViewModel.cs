using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class StatementViewModel
    {
        public INavigation Navigation { get; set; }
        public ICommand BackClick { get; set; }

        public StatementViewModel()
        {
            BackClick = new Command(() => Navigation.PopAsync());
        }
    }
}
