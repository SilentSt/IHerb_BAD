using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using IHerb_BAD.MVVM.Core;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM
{
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
        public string Nick { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int DavlenieUp { get; set; }
        public int DavlenieDown { get; set; }
        public int Puls { get; set; }
    }

    public class UserProfile
    {
        public string username;
        public ObservableCollection<User> users = new ObservableCollection<User>();
    }

    public static class Data
    {
        public static UserProfile UserProfile;
    }
}
