using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using IHerb_BAD.MVVM.Core;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class LoginViewModel : ObservableObject
    {
        public INavigation Navigation;
        private string _login;

        public string Login
        {
            get { return _login; }
            set{
                if (_login != value)
                {
                    _login = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _password;
        public ICommand BackClick { get; set; }
        public LoginViewModel()
        {
            BackClick = new Command(Back);
        }

        public void Back()
        {
            Navigation.PopAsync();
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
