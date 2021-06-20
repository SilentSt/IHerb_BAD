using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using IHerb_BAD.MVVM.Core;
using IHerb_BAD.MVVM.View;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class ProfileViewModel : ObservableObject
    {
        
        public Image Image { get; set; }
        public string Username { get; set; }
        public DateTime BirthDate { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Davlenie { get; set; }
        public string Puls { get; set; }

        public INavigation Navigation { get; set; }
        public ICommand BackClick { get; set; }
        public ICommand GoToAnals { get; set; }
        public ICommand SaveClick { get; set; }

        public ProfileViewModel( )
        {
            
            BackClick = new Command(() => Navigation.PopAsync());
            SaveClick = new Command(SaveData);
            GoToAnals = new Command(() =>
            {
                var user = new User()
                {
                    UserImage = Image,
                    Nick = Username,
                    BirthDate = BirthDate,
                    Weight = int.Parse(Weight),
                    Height = int.Parse(Height),
                    DavlenieUp = int.Parse(Davlenie.Replace(',','.').Split('.')[0]),
                    DavlenieDown = int.Parse(Davlenie.Replace(',', '.').Split('.')[1]),
                    Puls = int.Parse(Puls)
                };
                Navigation.PushAsync(new AnalysiesManager(user));
            });
        }

        public void SaveData()
        {
            var user = new User()
            {
                UserImage = Image,
                Nick = Username,
                BirthDate = BirthDate,
                Weight = int.Parse(Weight),
                Height = int.Parse(Height),
                DavlenieUp = int.Parse(Davlenie.Split('.')[0]),
                DavlenieDown = int.Parse(Davlenie.Split('.')[1]),
                Puls = int.Parse(Puls)
            };
            Data.UserProfile.users.Add(user);
            Navigation.PopAsync();
        }
    }
}
