using System;
using System.Collections.Generic;
using System.Text;
using IHerb_BAD.MVVM.Core;

namespace IHerb_BAD.MVVM.ViewModel
{
    class CurrentViewModel : ObservableObject
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public CurrentViewModel()
        {
            
        }
    }
}
