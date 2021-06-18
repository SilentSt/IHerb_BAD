using System;
using System.Collections.Generic;
using System.Text;
using IHerb_BAD.MVVM.Core;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    public class LoginViewModel : ObservableObject
    {
        public INavigation Navigation { get; set; }
        public LoginViewModel()
        {
            
        }
    }
}
