using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Xam.Plugin.SimpleBottomDrawer
{
    [Preserve(AllMembers = true)]
    public class BottomDrawer : Frame
    {
        private double[] lockStates = new double[] { 0, .5, .85 };
        private double _width;
        private double _height;
        public static readonly BindableProperty IsExpandedProperty = BindableProperty.Create(nameof(IsExpanded), typeof(bool), typeof(BottomDrawer), false, BindingMode.TwoWay,
           propertyChanged: IsExpandedPropertyChanged);
        public static readonly BindableProperty ExpandedPercentageProperty = BindableProperty.Create(nameof(ExpandedPercentage), typeof(double), typeof(BottomDrawer), defaultBindingMode: BindingMode.TwoWay, propertyChanged: OnExpandedPercentageChanged);
        
        public BottomDrawer()
        {
            BackgroundColor = Color.White;
            CornerRadius = 8;
            HasShadow = true;

            var panGestures = new PanGestureRecognizer();
            panGestures.PanUpdated += OnPanChanged;
            GestureRecognizers.Add(panGestures);
            var tapGestures = new TapGestureRecognizer();
            tapGestures.Tapped += OnTapped;
            GestureRecognizers.Add(tapGestures);
        }
        
        public bool IsExpanded
        {
            get => (bool)GetValue(IsExpandedProperty);
            set => SetValue(IsExpandedProperty, value);
        }

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
        private void OnTapped(object sender, EventArgs e)
        {
            if (!IsExpanded)
            {
                ExpandedPercentage = lockStates[1];
                IsExpanded = ExpandedPercentage > 0;
            }
        }

        private static void IsExpandedPropertyChanged(BindableObject bindable, object o, object n)
        {
            if (n is bool isExpanded && bindable is BottomDrawer drawer)
            {
                if (!isExpanded)
                    drawer.Dismiss();
                else
                    drawer.Open();
            }
        }

        private static void OnExpandedPercentageChanged(BindableObject bindable, object o, object n)
        {
            if (n is double expandValue && bindable is BottomDrawer drawer)
            {
                var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(drawer.getProportionCoordinate(expandValue)));
                if (expandValue < 0)
                    drawer.TranslateTo(drawer.X, finalTranslation, 250, Easing.SpringIn);
                else
                    drawer.TranslateTo(drawer.X, finalTranslation, 250, Easing.SpringOut);
            }
        }

        private void OnPanChanged(object sender, PanUpdatedEventArgs e)
        {
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    var translateY = Math.Max(Math.Min(0, this.TranslationY + e.TotalY), -Math.Abs((Height * .25) - Height));
                    this.TranslateTo(this.X, translateY, 20);
                    ExpandedPercentage = GetPropertionDistance(e.TotalY + this.TranslationY);
                    break;
                case GestureStatus.Completed:
                    var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getProportionCoordinate(GetClosestLockState(e.TotalY + this.TranslationY))));
                    if (e.TotalY < 0)
                        this.TranslateTo(this.X, finalTranslation, 250, Easing.SpringIn);
                    else
                        this.TranslateTo(this.X, finalTranslation, 250, Easing.SpringOut);
                    ExpandedPercentage = GetClosestLockState(e.TotalY + this.TranslationY);
                    break;
            }

            if (ExpandedPercentage > lockStates[lockStates.Length - 1])
                ExpandedPercentage = lockStates[lockStates.Length - 1];
            IsExpanded = ExpandedPercentage > 0;
        }
        
        private double GetClosestLockState(double TranslationY)
        {
            double current = GetPropertionDistance(TranslationY);
            var smallestDistance = 10000.0;
            var closestIndex = 0;
            for (int i = 0; i < lockStates.Length; i++)
            {
                var state = lockStates[i];
                var absoluteDistance = Math.Abs(state - current);
                if (absoluteDistance < smallestDistance)
                {
                    smallestDistance = absoluteDistance;
                    closestIndex = i;
                }
            }
            return lockStates[closestIndex];
        }

        private double GetPropertionDistance(double TranslationY)
        {
            return Math.Abs(TranslationY) / Height;
        }
        
        private double getProportionCoordinate(double proportion)
        {
            return proportion * Height;
        }
        public void Dismiss()
        {
            var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getProportionCoordinate(lockStates[0])));
            this.TranslateTo(this.X, finalTranslation, 450, Easing.SpringOut);
        }
        public void Open()
        {
            var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getProportionCoordinate(lockStates[lockStates.Length - 1])));
            this.TranslateTo(this.X, finalTranslation, 150, Easing.SpringIn);
        }
    }
}