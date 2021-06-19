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

            //MainPage = new NavigationPage(new Profile());


            MainPage = new NavigationPage(new Analysis());


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
