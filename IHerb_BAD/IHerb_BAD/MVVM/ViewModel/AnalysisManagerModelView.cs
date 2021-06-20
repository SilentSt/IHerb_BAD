using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using IHerb_BAD.MVVM.Core;
using IHerb_BAD.MVVM.View;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class AnalysisManagerModelView : ObservableObject
    {
        public INavigation Navigation { get; set; }
        public ICommand BackClick { get; set; }
        public ICommand Save { get; set; }
        private User _user;
        public AnalysisManagerModelView(User user)
        {
            _user = user;
            Save = new Command(SaveAndGo);
            BackClick = new Command(() => Navigation.PopModalAsync());
        }

        public void SaveAndGo()
        {
            _user.AnalyseData.Add(new AnalyseData(){type = AnalyseType.OO_Blood, stats = AnalyseGetter.getter[AnalyseType.OO_Blood]});
            Navigation.PushModalAsync(new Analysis(_user));
        }
    }
}