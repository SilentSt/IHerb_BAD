using IHerb_BAD.MVVM.Core;
using Syncfusion.XForms.Pickers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class ControlViewModel:ObservableObject
    {
        public INavigation Navigation { get; set; }
        public ICommand BackClick { get; set; }
        public ICommand ShowDatePicker { get; set; }
        public string selDate { get; set; } = "< Выберите дату >";
        public ControlViewModel()
        {
            ShowDatePicker = new Command(OpenDatePicker);
            BackClick = new Command(() => Navigation.PopAsync());
        }
        public void OpenDatePicker(object sender)
        {            
            var date = (sender as SfDatePicker);
            date.IsOpen = true;
            date.DateSelected += Date_DateSelected;
            
        }

        private void Date_DateSelected(object sender, Syncfusion.XForms.Pickers.DateChangedEventArgs e)
        {
            var date = (sender as SfDatePicker).Date;
            selDate = "< "+date.DayOfWeek.ToString()+", "+date.Day.ToString()+" "+date.Month.ToString()+" >";
            Fire("selDate");
        }
    }
}
