using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

using IHerb_BAD.MVVM.Core;

using Syncfusion.SfCalendar.XForms;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class CalendarViewModel : ObservableObject
    {
        public INavigation Navigation { get; set; }
        public ICommand BackClick { get; set; }
        public SfCalendar SelectedDates { get; set; } = new SfCalendar();
        public CalendarViewModel()
        {
            BackClick = new Command(() => Navigation.PopAsync());
        }
    }
}
