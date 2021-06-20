using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using IHerb_BAD.MVVM.Core;
using IHerb_BAD.MVVM.View;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class ProfileManagerViewModel : ObservableObject
    {   
        public INavigation Navigation { get; set; }
        public ICommand AddUser { get; set; }
        public ICommand OpenProfile { get; set; }
        public ProfileManagerViewModel( )
        {
            AddUser = new Command(AddProfile);
            OpenProfile = new Command(Open);
        }
        public ObservableCollection<User> Users
        {
            get { return Data.UserProfile.users; }
            set { Data.UserProfile.users = value; }
        }

        public void AddProfile()
        {
            Navigation.PushAsync(new Profile());
        }

        public void Open(object sender)
        {
            var user = sender as User;
            Navigation.PushModalAsync(new MenuP(user));
        }
    }
    
}
