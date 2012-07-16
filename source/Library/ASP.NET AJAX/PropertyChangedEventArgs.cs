using System;
namespace Sys
{
    /// <summary>
    /// Describes property changes.
    /// </summary>
    public class PropertyChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the name of the property that changed.
        /// </summary>
        public extern string propertyName{get;}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Sys.PropertyChangedEventArgs" /> class.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
        public PropertyChangedEventArgs(string propertyName)
        {
        }
    }
}
