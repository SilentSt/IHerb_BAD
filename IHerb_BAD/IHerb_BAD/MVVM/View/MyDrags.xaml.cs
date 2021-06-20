using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHerb_BAD.MVVM.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IHerb_BAD.MVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyDrags : ContentPage
    {
        public MyDrags()
        {
            InitializeComponent();
            BindingContext = new MyDrugsViewModel() {Navigation = this.Navigation};
        }
    }
}