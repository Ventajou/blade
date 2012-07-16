using System;
namespace Sys
{
    /// <summary>
    /// Defines the <see cref="E:Sys.INotifyPropertyChange.PropertyChanged">PropertyChanged</see> event.
    /// </summary>
    public interface INotifyPropertyChange
    {
        /// <summary>
        /// Occurs when a component property is set to a new value.
        /// </summary>
        void add_propertyChanged(PropertyChangedEventHandler handler);
        void remove_propertyChanged(PropertyChangedEventHandler handler);
        //TODO: proper event when Blade allows it
        //event PropertyChangedEventHandler propertyChanged;
    }
}
