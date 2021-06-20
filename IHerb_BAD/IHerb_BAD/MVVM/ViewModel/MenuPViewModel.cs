using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using IHerb_BAD.MVVM.Core;
using IHerb_BAD.MVVM.View;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class MenuPViewModel :ObservableObject
    {
        public INavigation Navigation { get; set; }
        public ICommand BackClick { get; set; }

        public ICommand ShowUserInfo { get; set; }
        public ICommand ControlUsing { get; set; }
        public ICommand MyDrags { get; set; }
        public ICommand Calendar { get; set; }
        public ICommand Statement { get; set; }
        public ICommand Recomends { get; set; }

        public ICommand DeleteUser { get; set; }


        public MenuPViewModel(User user)
        {
            BackClick = new Command(() => Navigation.PopAsync());
            ShowUserInfo = new Command(() => Navigation.PushAsync(new Profile()));
            ControlUsing = new Command(() => Navigation.PushAsync(new Control()));
            MyDrags = new Command(() => Navigation.PushAsync(new MyDrags()));
            Calendar = new Command(() => Navigation.PushAsync(new Calendar()));
            Statement = new Command(() => Navigation.PushAsync(new Statement()));
            Recomends = new Command(() => Navigation.PushAsync(new Recomendations()));
            DeleteUser = new Command(() => Navigation.PopAsync());
        }
    }
}
