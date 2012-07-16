using System;
namespace Sys
{
    /// <summary>
    /// Defines the <see cref="E:Sys.INotifyDisposing.Disposing">Disposing</see> event.
    /// </summary>
    public interface INotifyDisposing
    {
        /// <summary>
        /// Occurs when an object's resources are released.
        /// </summary>
        void add_disposing(EventHandler handler);
        void remove_disposing(EventHandler handler);
        //TODO: proper event when Blade allows it
        //event EventHandler disposing;
    }
}
