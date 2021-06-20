using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IHerb_BAD.MVVM.ViewModel
{
    class AnalysisModelView
    {
        public ObservableCollection<AnalyseStat> AnalStats { get; set; }
        public INavigation Navigation { get; set; }
        public ICommand SaveClick { get; set; }
        public string AnalysType { get; set; }
        public AnalysisModelView(User user)
        {
            AnalStats = new ObservableCollection<AnalyseStat>(user.AnalyseData.Last().stats);
            AnalysType = user.AnalyseData.Last().AnalysType;
            SaveClick = new Command(Save);
        }

        public void Save()
        {
            Navigation.PopModalAsync();
        }
    }
}
