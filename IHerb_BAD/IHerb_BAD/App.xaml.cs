using System;
using IHerb_BAD.MVVM.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IHerb_BAD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
<<<<<<< HEAD
            MainPage = new NavigationPage(new ProfileManager());
=======

            MainPage = new NavigationPage(new Start());

>>>>>>> 3211033971b467bdfd4e7667b7d49a8fd2f1faff
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
