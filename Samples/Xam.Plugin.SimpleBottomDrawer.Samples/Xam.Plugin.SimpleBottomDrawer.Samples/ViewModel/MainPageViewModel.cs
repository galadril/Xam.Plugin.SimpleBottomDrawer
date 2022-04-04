using System.Windows.Input;
using Xam.Plugin.SimpleBottomDrawer.Samples.Helpers;
using Xamarin.Forms;

namespace Xam.Plugin.SimpleBottomDrawer.Samples.ViewModel
{
    /// <summary>
    /// View model to demonstrate the <see cref="BottomDrawer"/> control
    /// </summary>
    public class MainPageViewModel : ObservableObject
    {
        #region Variables

        /// <summary>
        /// variable for the max opacity value
        /// </summary>
        private const double MaxOpacity = 0.5;

        /// <summary>
        /// Is expanded value
        /// </summary>
        private bool _IsExpanded;

        /// <summary>
        /// Is visible value
        /// </summary>
        private bool _IsVisible = true;

        /// <summary>
        /// Is Y value
        /// </summary>
        private double _ExpandedPercentage;

        /// <summary>
        /// Is overlay visible / opacity
        /// </summary>
        private double _OverlayOpacity;

        /// <summary>
        /// The bottom drawer lock states
        ///
        /// Note: [alex-d] works incorrectly when more than 3 values
        /// </summary>
        private double[] _LockStates = new double[] { 0, .30, 0.6, 0.95 };

        #endregion

        #region Constructor & Destructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainPageViewModel()
        {
            BackgroundClicked = new Command(() => IsExpanded = false);
        }

        #endregion

        #region Properties

        /// <summary>
        /// On background clicked
        /// </summary>
        public ICommand BackgroundClicked { get; private set; }

        /// <summary>
        /// Is ExpandedPercentage
        /// </summary>
        public double ExpandedPercentage
        {
            get => _ExpandedPercentage;
            set
            {
                SetProperty(ref _ExpandedPercentage, value);
                OverlayOpacity = MaxOpacity < value ? MaxOpacity : value;
            }
        }

        /// <summary>
        /// Lock states
        /// </summary>
        public double[] LockStates
        {
            get => _LockStates;
            set => SetProperty(ref _LockStates, value);
        }

        /// <summary>
        /// Is expanded
        /// </summary>
        public bool IsExpanded
        {
            get => _IsExpanded;
            set => SetProperty(ref _IsExpanded, value);
        }

        /// <summary>
        /// Is visible
        /// </summary>
        public bool IsVisible
        {
            get => _IsVisible;
            set => SetProperty(ref _IsVisible, value);
        }

        /// <summary>
        /// Is layout opacity value
        /// </summary>
        public double OverlayOpacity
        {
            get => _OverlayOpacity;
            set => SetProperty(ref _OverlayOpacity, value);
        }

        #endregion
    }
}
