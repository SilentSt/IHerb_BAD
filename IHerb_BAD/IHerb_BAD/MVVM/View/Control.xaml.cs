using IHerb_BAD.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IHerb_BAD.MVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Control : ContentPage
    {
        public Control()
        {
            InitializeComponent();
            BindingContext = new ControlViewModel(){Navigation = this.Navigation};
        }
    }
}