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
        private ObservableCollection<User> _users;
        public ICommand AddUser { get; set; }
        public ProfileManagerViewModel()
        {
            AddUser = new Command(AddProfile);
        }
        public ObservableCollection<User> Users
        {
            get => _users;
            set=> _users = value;
        }

        public void AddProfile()
        {
            Navigation.PushAsync(new Profile());
        }

    }

    public class User : ObservableObject
    {
        private Image _userImage;

        public Image UserImage
        {
            get { return _userImage; }
            set
            {
                if (_userImage != value)
                {
                    _userImage = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
