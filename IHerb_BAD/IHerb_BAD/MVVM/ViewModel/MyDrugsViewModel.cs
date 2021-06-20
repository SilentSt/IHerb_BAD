using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class MyDrugsViewModel
    {
        public INavigation Navigation { get; set; }
        public ICommand BackClick { get; set; }

        public MyDrugsViewModel()
        {
            BackClick = new Command(() => Navigation.PopAsync());
        }
    }
}
