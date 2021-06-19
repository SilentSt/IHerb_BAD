using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using IHerb_BAD.MVVM.Core;
using IHerb_BAD.MVVM.View;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    public class StartViewModel : ObservableObject
    {
        public INavigation Navigation { get; set; }

        public ICommand Login { get; set; }
        public ICommand SignIn { get; set; }

        public StartViewModel()
        {
            Login = new Command(LoginClick);
            SignIn = new Command(SignInClick);
        }

        public void SignInClick()
        {
            Navigation.PushAsync(new SignIn());
        }
        public void LoginClick()
        {
            Navigation.PushAsync(new Profile());
        }
    }
}
