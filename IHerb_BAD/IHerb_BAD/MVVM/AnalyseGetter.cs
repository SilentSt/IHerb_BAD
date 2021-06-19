using System;
using System.Collections.Generic;
using System.Text;

namespace IHerb_BAD.MVVM
{
    public static class AnalyseGetter
    {
        public static Dictionary<AnalyseType, List<AnalyseStat>> getter = new Dictionary<AnalyseType, List<AnalyseStat>>()
        {
            {AnalyseType.OO_Blood,new List<AnalyseStat>()
                {
                    new AnalyseStat() { StatName = "Эритроциты", StatValue = null},
                    new AnalyseStat() { StatName = "Гемоглобин", StatValue = null},
                    new AnalyseStat() { StatName = "Лейкоциты", StatValue = null},
                    new AnalyseStat() { StatName = "Цветовой показатель", StatValue = null},
                    new AnalyseStat() { StatName = "Гематокрит", StatValue = null},
                    new AnalyseStat() { StatName = "Ретикулоциты", StatValue = null},
                    new AnalyseStat() { StatName = "Тромбоциты", StatValue = null},
                    new AnalyseStat() { StatName = "СОЭ", StatValue = null}
                }
            }
        };

    }
}
