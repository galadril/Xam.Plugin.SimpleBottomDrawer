using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Xam.Plugin.SimpleBottomDrawer
{
    [Preserve(AllMembers = true)]
    public class BottomDrawer : Frame
    {
        private bool isDragging = false;
        private double _width;
        private double _height;
        public static readonly BindableProperty IsExpandedProperty = BindableProperty.Create(nameof(IsExpanded), typeof(bool), typeof(BottomDrawer), false, BindingMode.TwoWay,
           propertyChanged: IsExpandedPropertyChanged);
        public static readonly BindableProperty ExpandedPercentageProperty = BindableProperty.Create(nameof(ExpandedPercentage), typeof(double), typeof(BottomDrawer), defaultBindingMode: BindingMode.TwoWay, propertyChanged: ExpandedPercentageChanged);
        public static readonly BindableProperty LockStatesProperty = BindableProperty.Create(nameof(LockStates), typeof(double[]), typeof(BottomDrawer), new double[] { 0, .4, .75 });
        
        public BottomDrawer()
        {
            // Set the default values for this control
            BackgroundColor = Color.White;
            CornerRadius = 8;
            HasShadow = true;

            // Set the pan gesture listeners
            var panGestures = new PanGestureRecognizer();
            panGestures.PanUpdated += OnPanChanged;
            GestureRecognizers.Add(panGestures);

            // Add click gesture listeners
            var tapGestures = new TapGestureRecognizer();
            tapGestures.Tapped += OnTapped;
            GestureRecognizers.Add(tapGestures);
        }

        /// <summary>
        /// Gets or sets the lock statues
        /// </summary>
        public double[] LockStates
        {
            get => (double[])GetValue(LockStatesProperty);
            set => SetValue(LockStatesProperty, value);
        }

        /// <summary>
        /// Gets or sets the is expanded value
        /// </summary>
        public bool IsExpanded
        {
            get => (bool)GetValue(IsExpandedProperty);
            set => SetValue(IsExpandedProperty, value);
        }

        /// <summary>
        /// Gets or sets the is expanded percentage
        /// </summary>
        public double ExpandedPercentage
        {
            get => (double)GetValue(ExpandedPercentageProperty);
            set => SetValue(ExpandedPercentageProperty, value);
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != _width || height != _height)
            {
                _width = width;
                _height = height;
                IsExpanded = false;
            }
        }
        
        private static void IsExpandedPropertyChanged(BindableObject bindable, object o, object n)
        {
            if (n is bool isExpanded && bindable is BottomDrawer drawer)
            {
                if (!drawer.isDragging)
                {
                    if (!isExpanded)
                        drawer.Dismiss();
                    else
                        drawer.Open();
                }
            }
        }

        private static void ExpandedPercentageChanged(BindableObject bindable, object o, object n)
        {
            if (n is double expandValue && bindable is BottomDrawer drawer)
            {
                if (!drawer.isDragging)
                {
                    var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(drawer.getProportionCoordinate(expandValue)));
                    if (expandValue < 0)
                        drawer.TranslateTo(drawer.X, finalTranslation, 250, Easing.SpringIn);
                    else
                        drawer.TranslateTo(drawer.X, finalTranslation, 250, Easing.SpringOut);
                }
            }
        }

        private void OnPanChanged(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    isDragging = true;
                    // Translate and ensure we don't y + e.TotalY pan beyond the wrapped user interface element bounds.
                    var translateY = Math.Max(Math.Min(0, this.TranslationY + e.TotalY), -Math.Abs((Height * .25) - Height));
                    this.TranslateTo(this.X, translateY, 20);
                    ExpandedPercentage = GetPropertionDistance(e.TotalY + this.TranslationY);
                    break;
                case GestureStatus.Completed:
                    // At the end of the event - snap to the closest location
                    var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getProportionCoordinate(GetClosestLockState(e.TotalY + this.TranslationY))));

                    // Depending on Swipe Up or Down - change the snapping animation
                    if (DetectSwipeUp(e))
                        this.TranslateTo(this.X, finalTranslation, 250, Easing.SpringIn);
                    else
                        this.TranslateTo(this.X, finalTranslation, 250, Easing.SpringOut);
                    ExpandedPercentage = GetClosestLockState(e.TotalY + this.TranslationY);
                    isDragging = false;
                    break;
            }

            if (ExpandedPercentage > LockStates[LockStates.Length - 1])
                ExpandedPercentage = LockStates[LockStates.Length - 1];
            IsExpanded = ExpandedPercentage > 0;
        }

        private void OnTapped(object sender, EventArgs e)
        {
            if (!IsExpanded)
            {
                ExpandedPercentage = LockStates[1];
                IsExpanded = ExpandedPercentage > 0;
            }
        }

        private bool DetectSwipeUp(PanUpdatedEventArgs e)
        {
            return e.TotalY < 0;
        }

        private double GetClosestLockState(double TranslationY)
        {
            // Play with these values to adjust the locking motions - this will change depending on the amount of content ona  apge
            double current = GetPropertionDistance(TranslationY);

            // Calculate which lockstate it's the closest to
            var smallestDistance = 10000.0;
            var closestIndex = 0;

            for (int i = 0; i < LockStates.Length; i++)
            {
                var state = LockStates[i];
                var absoluteDistance = Math.Abs(state - current);
                if (absoluteDistance < smallestDistance)
                {
                    smallestDistance = absoluteDistance;
                    closestIndex = i;
                }
            }

            return LockStates[closestIndex];
        }

        private double GetPropertionDistance(double TranslationY)
        {
            return Math.Abs(TranslationY) / Height;
        }

        private double getProportionCoordinate(double proportion)
        {
            return proportion * Height;
        }

        /// <summary>
        /// Dismiss the bottom drawer
        /// </summary>
        public void Dismiss()
        {
            var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getProportionCoordinate(LockStates[0])));
            this.TranslateTo(this.X, finalTranslation, 450, Easing.SpringOut);
        }

        /// <summary>
        /// Open the bottom drawer
        /// </summary>
        public void Open()
        {
            var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getProportionCoordinate(LockStates[LockStates.Length - 1])));
            this.TranslateTo(this.X, finalTranslation, 150, Easing.SpringIn);
        }
    }
}