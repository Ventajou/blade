using System;

namespace Sys
{
    /// <summary>
    /// Creates a dictionary to hold client-script events and their associated handlers.
    /// </summary>
    public sealed class EventHandlerList
    {
        /// <summary>
        /// Attaches a handler to a specified event in an <see cref="T:Sys.EventHandlerList" /> instance
        /// and adds the specified event to the list if not already present.
        /// </summary>
        /// <param name="id">The string literal that will be used as the ID for the event.</param>
        /// <param name="handler">The delegate to handle the event.</param>
        public extern void addHandler(string id, Delegate handler);

        /// <summary>
        /// Returns a single method that can be invoked to call all handlers sequentially for the specified event.
        /// </summary>
        /// <param name="id">The ID for the specified event.</param>
        /// <returns>A single method that can be invoked to call all handlers sequentially for the specified event.</returns>
        public extern Delegate getHandler(string id);

        /// <summary>
        /// Removes an event handler from the specified event in a <see cref="T:Sys.EventHandlerList" /> instance.
        /// </summary>
        /// <param name="id">The ID for the event.</param>
        /// <param name="handler">The handler to remove from the event.</param>
        public extern void removeHandler(string id, Delegate handler);
    }
}
