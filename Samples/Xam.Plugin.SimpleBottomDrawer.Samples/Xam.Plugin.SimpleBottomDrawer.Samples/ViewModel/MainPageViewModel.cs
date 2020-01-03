using System.ComponentModel;

namespace Xam.Plugin.SimpleBottomDrawer.Samples.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        private bool _IsExpanded;
        private bool _ShowShadow = true;
        private bool _IsVisible = true;
        private double _ExpandedPercentage = 0;
        private double _OverlayOpacity = 0;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            IsExpanded = false;
            IsVisible = true;
            ExpandedPercentage = 0;
        }

        public double ExpandedPercentage
        {
            set
            {
                if (_ExpandedPercentage != value)
                {
                    _ExpandedPercentage = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ExpandedPercentage"));
                }
            }
            get
            {
                return _ExpandedPercentage;
            }
        }

        public double OverlayOpacity
        {
            set
            {
                if (_OverlayOpacity != value)
                {
                    _OverlayOpacity = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OverlayOpacity"));
                }
            }
            get
            {
                return _OverlayOpacity;
            }
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

        public bool ShowShadow
        {
            set
            {
                if (_ShowShadow != value)
                {
                    _ShowShadow = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ShowShadow"));
                }
            }
            get
            {
                return _ShowShadow;
            }
        }
    }
}
