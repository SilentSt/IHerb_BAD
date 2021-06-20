using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace IHerb_BAD.MVVM.ViewModel
{
    class AnalysisModelView
    {
        public ObservableCollection<AnalyseStat> AnalStats { get; set; }
        public AnalysisModelView(User user)
        {
            AnalStats = new ObservableCollection<AnalyseStat>(user.AnalyseData.Last().stats);
        }
    }
}
