using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Xam.Plugin.SimpleBottomDrawer
{
    /// <summary>
    /// Bottom drawer control with a border
    /// </summary>
    [Preserve(AllMembers = true)]
    public class BottomDrawer : Frame
    {
        #region Variables

		/// <summary>
		/// Needed to save the startposition on iOS
		/// </summary>
		private double translationYStart;

        /// <summary>
        /// Is the drawer being dragged
        /// </summary>
        private bool isDragging = false;

        /// <summary>
        /// Get width
        /// </summary>
        private double _width;

        /// <summary>
        /// Get height
        /// </summary>
        private double _height;

        /// <summary>
        /// Bindable property for the <see cref="IsExpanded"/> property
        /// </summary>
        public static readonly BindableProperty IsExpandedProperty = BindableProperty.Create(nameof(IsExpanded), typeof(bool), typeof(BottomDrawer), false, BindingMode.TwoWay,
           propertyChanged: IsExpandedPropertyChanged);

        /// <summary>
        /// Bindable property for the <see cref="ExpandedPercentage"/> property
        /// </summary>
        public static readonly BindableProperty ExpandedPercentageProperty = BindableProperty.Create(nameof(ExpandedPercentage), typeof(double), typeof(BottomDrawer), defaultBindingMode: BindingMode.TwoWay, propertyChanged: ExpandedPercentageChanged);

        /// <summary>
        /// Bindable property for the <see cref="ExpandedPercentage"/> property
        /// </summary>
        public static readonly BindableProperty LockStatesProperty = BindableProperty.Create(nameof(LockStates), typeof(double[]), typeof(BottomDrawer), new double[] { 0, .4, .75 });

        #endregion Variables


        #region Constructor & Destructor

        /// <summary>
        /// Constructor
        /// </summary>
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

        #endregion


        #region Properties


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
            set
            {
#if DEBUG
                if (value > 0.8)
                {
                    // > 360.0 / 640.0
                    // 0.5625
                    // ---
                    // > 0.5625 + (1 - 0.5625) / 2
                    // 0.78125
                    // -
                    System.Console.WriteLine("[BottomDrawer] debug drag to top");
                }
#endif

                SetValue(ExpandedPercentageProperty, value);
            }
        }

        #endregion


        #region Protected

        /// <summary>
        /// Make sure we collapse the view on orientation change
        /// </summary>
        protected override void OnSizeAllocated(
              double width
            , double height
        )
        {
            base.OnSizeAllocated(width, height);
            if (width != _width || height != _height)
            {
                _width = width;
                _height = height;
                IsExpanded = false;
            }
        }

        #endregion Protected


        #region Private

        /// <summary>
        /// Handle the change of the <see cref="IsExpanded"/> property
        /// </summary>
        /// <param name="bindable">The bindable object</param>
        /// <param name="o">The old value</param>
        /// <param name="n">The new value</param>
        private static void IsExpandedPropertyChanged(
              BindableObject bindable
            , object o
            , object n)
        {
            if (n is bool isExpanded && bindable is BottomDrawer drawer)
            {
                if (!drawer.isDragging)
                {
                    if (!isExpanded)
                    {
#if DEBUG
                        System.Console.WriteLine("[BottomDrawer] IsExpandedPropertyChanged() ==> Dismiss()");
#endif
                        drawer.Dismiss();
                    }
                    else
                    {
#if DEBUG
                        System.Console.WriteLine("[BottomDrawer] IsExpandedPropertyChanged() ==> Open()");
#endif
                        drawer.Open();
                    }
                }
            }
        }

        /// <summary>
        /// Handle the change of the <see cref="ExpandedPercentage"/> property
        /// </summary>
        /// <param name="bindable">The bindable object</param>
        /// <param name="o">The old value</param>
        /// <param name="n">The new value</param>
        private static void ExpandedPercentageChanged(
              BindableObject bindable
            , object o
            , object n)
        {
            if (n is double expandValue && bindable is BottomDrawer drawer)
            {
                if (!drawer.isDragging)
                {
                    double proportionY = drawer.getProportionCoordinate(expandValue);

                    var finalTranslation =
                        Math.Max(
                               Math.Min(0, -1000)
                            , -Math.Abs(proportionY)
                        );

#if DEBUG
                    System.Console.WriteLine(
                        $"[BottomDrawer] ExpandedPercentageChanged() ==> proportionY=={proportionY} | finalTranslation=={finalTranslation}");
#endif

                    if (expandValue < 0)
                    {
                        drawer.TranslateTo(
                              x: drawer.X
                            , y: finalTranslation
                            , length: 250
                            , easing: Easing.SpringIn
                        );
                    }
                    else
                    {
                        drawer.TranslateTo(
                              x: drawer.X
                            , y: finalTranslation
                            , length: 250
                            , easing: Easing.SpringOut
                        );
                    }
                }
            }
        }

        /// <summary>
        /// On pan gesture changed
        /// </summary>
        private void OnPanChanged(
              object              sender
            , PanUpdatedEventArgs e
        )
        {
            double Y =
                (Device.RuntimePlatform == Device.Android
                    ? this.TranslationY // Frame.TranslationY
                    : this.translationYStart)
                + e.TotalY;
            double tmpExpandedPercentage = GetPropertionDistance(Y);


            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    isDragging = true;


                    // Translate and ensure we don't y + e.TotalY pan beyond the wrapped user interface element bounds.
					var translateY =
                        Math.Max(
                               Math.Min(0, Y)
                            , -Math.Abs((Height * .25) - Height)
                        );

					this.TranslateTo(x: this.X, y: translateY, length: 1);
                    this.ExpandedPercentage = tmpExpandedPercentage;
#if DEBUG
                    System.Console.WriteLine($"[BottomDrawer] OnPanChanged() - Running | ExpandedPercentage=={ExpandedPercentage} | translateY=={translateY}");
#endif
                    break;

                case GestureStatus.Completed:
#if DEBUG
                    System.Console.WriteLine("[BottomDrawer] OnPanChanged() - Completed");
#endif

                    double dragDistanceY1 = e.TotalY + this.TranslationY;
#if DEBUG
                    System.Console.WriteLine($"[BottomDrawer] OnPanChanged() - call#1 GetClosestLockState({dragDistanceY1})");
#endif
                    // Note: [alex-d] when calculated value was used, there was an issue of not expanding to full screen
                    // -
                    double tmpLockState = GetClosestLockStatePercentage(this.ExpandedPercentage);
                    double tmpLockStateY = getProportionCoordinate(tmpLockState);

                    // At the end of the event - snap to the closest location
                    double finalTranslation =
                        Math.Max(
                               Math.Min(0, -1000)
                            , -Math.Abs(tmpLockStateY)
                        );

                    // Depending on Swipe Up or Down - change the snapping animation
                    if (DetectSwipeUp(e))
                    {
#if DEBUG
                        System.Console.WriteLine("[BottomDrawer] OnPanChanged() - DetectSwipeUp()==true");
#endif

                        this.TranslateTo(
                              x: this.X
                            , y: finalTranslation
                            , length: 250
                            , easing: Easing.SpringIn);
                    }
                    else
                    {
#if DEBUG
                        System.Console.WriteLine("[BottomDrawer] OnPanChanged() - DetectSwipeUp()==false");
#endif

                        this.TranslateTo(
                              x: this.X
                            , y: finalTranslation
                            , length: 250
                            , easing: Easing.SpringOut);
                    }

                    // Note: [alex-d] this.TranslationY might change due to this.TranslateTo()
                    // -
                    double dragDistanceY2 = e.TotalY + this.TranslationY;

#if DEBUG
                    System.Console.WriteLine($"[BottomDrawer] OnPanChanged() - call#2 GetClosestLockState({dragDistanceY2})");
#endif
                    this.ExpandedPercentage = GetClosestLockStateAbsolute(dragDistanceY2);
                    this.isDragging = false;

#if DEBUG
                    System.Console.WriteLine($"[BottomDrawer] OnPanChanged() - Completed | ExpandedPercentage=={ExpandedPercentage} | finalTranslation=={finalTranslation}");
#endif
                    break;

				case GestureStatus.Started:
                    this.translationYStart = this.TranslationY;

#if DEBUG
                    System.Console.WriteLine($"[BottomDrawer] OnPanChanged() - Started | translationYStart=={translationYStart}");
#endif
                    break;
            }

            if (LockStates.Length <= 0)
            {
                return;
            }

            int indexOfLastLockState = LockStates.Length - 1;
            double lastLockState = LockStates[indexOfLastLockState];
            double expandedPercentageBeforeLock = ExpandedPercentage;

            if (ExpandedPercentage > lastLockState)
            {
                ExpandedPercentage = lastLockState;
            }

            IsExpanded = (ExpandedPercentage > 0);

#if DEBUG
            System.Console.WriteLine($"[BottomDrawer] OnPanChanged() - [END] | ExpandedPercentage=={ExpandedPercentage} | expandedPercentageBeforeLock=={expandedPercentageBeforeLock}");
#endif
        }

        /// <summary>
        /// On tapped event
        /// </summary>
        private void OnTapped(
              object    sender
            , EventArgs e
        )
        {
#if DEBUG
            System.Console.WriteLine("[BottomDrawer] OnTapped()");
#endif
            if (!this.IsExpanded)
            {
                if (this.LockStates.Length >= 2)
                {
                    // TODO: [alex-d] why hard-coded [1] index?
                    // -
                    this.ExpandedPercentage = LockStates[1];
                }

                this.IsExpanded = (this.ExpandedPercentage > 0);
            }
        }

        /// <summary>
        /// Check if the action is a swipe up
        /// </summary>
        private bool DetectSwipeUp(PanUpdatedEventArgs e)
        {
            return e.TotalY < 0;
        }

        /// <summary>
        /// Find the closest lock state when swip is finished
        /// </summary>
        private double GetClosestLockStateAbsolute(double TranslationY)
        {
            // Play with these values to adjust the locking motions - this will change depending on the amount of content ona  apge
            double current = GetPropertionDistance(TranslationY);

            double result = GetClosestLockStatePercentage(current);
            return result;
        }

        private double GetClosestLockStatePercentage(double currentPercentageVisible)
        {
            double current = currentPercentageVisible;

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

            double result = LockStates[closestIndex];
#if DEBUG
            System.Console.WriteLine($"[BottomDrawer] GetClosestLockState() | current=={current} | result=={result} | index=={closestIndex} | TranslationY=={TranslationY}");
#endif
            return result;
        }

        /// <summary>
        /// Get the current proportion of the sheet in relation to the screen
        /// </summary>
        private double GetPropertionDistance(double TranslationY)
        {
            return Math.Abs(TranslationY) / Height;
        }

        /// <summary>
        /// Get proportion coordinates
        /// </summary>
        private double getProportionCoordinate(double proportion)
        {
            return proportion * Height;
        }

        #endregion


        #region Public

        /// <summary>
        /// Dismiss the bottom drawer
        /// </summary>
        public void Dismiss()
        {
            double finalTranslation =
                Math.Max(
                       Math.Min(0, -1000)
                    , -Math.Abs(getProportionCoordinate(LockStates[0]))
                );

            this.TranslateTo(
                  x: this.X
                , y: finalTranslation
                , length: 450
                , easing:
                    Device.RuntimePlatform == Device.Android
                        ? Easing.SpringOut
                        : null
            );

#if DEBUG
            System.Console.WriteLine($"[BottomDrawer] Dismiss() | finalTranslation=={finalTranslation}");
#endif
        }

        /// <summary>
        /// Open the bottom drawer
        /// </summary>
        public void Open()
        {
            double finalTranslation =
                Math.Max(
                       Math.Min(0, -1000)
                    , -Math.Abs(getProportionCoordinate(LockStates[LockStates.Length - 1]))
                );

            this.TranslateTo(
                  x: this.X
                , y: finalTranslation
                , length: 150
                , easing:
                    Device.RuntimePlatform == Device.Android
                        ? Easing.SpringIn
                        : null
            );

#if DEBUG
            System.Console.WriteLine($"[BottomDrawer] Open() | finalTranslation=={finalTranslation}");
#endif
        }

        #endregion Public
    }
}