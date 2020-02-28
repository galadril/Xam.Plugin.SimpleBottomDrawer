using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms.Internals;

namespace Xam.Plugin.SimpleBottomDrawer.Samples.Helpers
{
    /// <summary>
    /// Observable object with INotifyPropertyChanged implementation
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ObservableObject : INotifyPropertyChanged
    {
        #region Events

        /// <summary>
        /// Occurs when property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Protected

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            // To be thread save, first assign the PropertyChanged event handler to a variable
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets the property
        /// </summary>
        /// <typeparam name="T">The 1st type parameter</typeparam>
        /// <param name="backingStore">Backing store</param>
        /// <param name="value">Value</param>
        /// <param name="onChanged">On changed</param>
        /// <param name="propertyName">Property name</param>
        /// <returns><see langword="true"/> if property was set, otherwise <see langword="false"/></returns>
        protected bool SetProperty<T>(ref T backingStore, T value, Action onChanged = null, [CallerMemberName]string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Sets the property
        /// </summary>
        /// <typeparam name="T">The 1st type parameter</typeparam>
        /// <param name="backingStore">Backing store</param>
        /// <param name="value">Value</param>
        /// <param name="setter">The setter for the backing store</param>
        /// <param name="propertyName">Property name</param>
        /// <param name="onChanged">On changed</param>
        /// <returns><see langword="true"/> if property was set, otherwise <see langword="false"/></returns>
        protected bool SetProperty<T>(T backingStore, T value, Action<T> setter, Action onChanged = null, [CallerMemberName]string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            setter(value);
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
    }
}
