using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xam.Plugin.SimpleBottomDrawer.Samples.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        private bool _IsExpanded;
        private bool _IsVisible = true;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            IsExpanded = false;
            IsVisible = true;
        }

        public bool IsExpanded
        {
            set
            {
                if (_IsExpanded != value)
                {
                    _IsExpanded = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsExpanded"));
                }
            }
            get
            {
                return _IsExpanded;
            }
        }

        public bool IsVisible
        {
            set
            {
                if (_IsVisible != value)
                {
                    _IsVisible = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsVisible"));
                }
            }
            get
            {
                return _IsVisible;
            }
        }
    }
}
