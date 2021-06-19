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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDYxMjQ5QDMxMzkyZTMxMmUzMFhnOFJPelczRnpveUw5aFdXT3lheE42NGIyMmo2cGZpTVBJTDBzWHdEKzg9");
            InitializeComponent();
            MainPage = new NavigationPage(new Start());
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
