using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using IHerb_BAD.MVVM.Core;
using IHerb_BAD.MVVM.View;
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
        public ICommand LoginClick { get; set; }
        public ICommand BackClick { get; set; }
        public LoginViewModel()
        {
            BackClick = new Command(()=>Navigation.PopAsync());
            LoginClick = new Command(Authorize);
        }

        public void Authorize()
        {
            if (Login == "admin" && Password == "admin")
            {
                Data.UserProfile = new UserProfile(){username = "admin"};
                Navigation.PushAsync(new ProfileManager());
            }
        }
        
    }
}
