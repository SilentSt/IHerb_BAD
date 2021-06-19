using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHerb_BAD.MVVM.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IHerb_BAD.MVVM.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileManager : ContentPage
    {
        private UserProfile _user;
        private ProfileManagerViewModel profileManagerVM;
		public ProfileManager ( )
        {
             
            profileManagerVM = new ProfileManagerViewModel() { Navigation = this.Navigation };

            InitializeComponent ();
            BindingContext = profileManagerVM;
        }
        
    }
}