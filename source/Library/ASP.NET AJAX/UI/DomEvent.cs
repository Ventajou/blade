using System;
using System.Html;
using System.Dom;

namespace Sys.UI
{
    /// <summary>
    /// Provides access to client event handlers and event properties.
    /// </summary>
    public sealed class DomEvent
    {
        /// <summary>
        /// Gets a Boolean value that indicates the state of the ALT key when the associated event occurred.
        /// </summary>
        [ScriptField]
        public extern bool altKey { get; }

        /// <summary>
        /// Gets a <see cref="T:Sys.UI.MouseButton" /> enumeration value that indicates the button
        /// state of the mouse when the related event occurred.
        /// </summary>
        [ScriptField]
        public extern MouseButton button { get; }

        /// <summary>
        /// Gets the character code of the key that raised the associated event.
        /// </summary>
        [ScriptField]
        public extern int charCode { get; }

        /// <summary>
        /// Gets the x-coordinate of the mouse pointer's position relative to the client area of
        /// the browser window, excluding window scroll bars.
        /// </summary>
        /// <value>An integer that represents the x-coordinate in pixels.</value>
        [ScriptField]
        public extern int clientX { get; }

        /// <summary>
        /// Gets the y-coordinate of the mouse pointer's position relative to the client area of
        /// the browser window, excluding window scroll bars.
        /// </summary>
        /// <value>An integer that represents the y-coordinate in pixels.</value>
        [ScriptField]
        public extern int clientY { get; }

        /// <summary>
        /// Gets a Boolean value that indicates the state of the CTRL key when the associated event occurred.
        /// </summary>
        [ScriptField]
        public extern bool ctrlKey { get; }

        [ScriptField]
        public extern int keyCode { get; }

        /// <summary>
        /// Gets the x-coordinate of the mouse pointer's position relative to the object that raised the event.
        /// </summary>
        /// <value>An integer that represents the x-coordinate in pixels.</value>
        [ScriptField]
        public extern int offsetX { get; }

        /// <summary>
        /// Gets the y-coordinate of the mouse pointer's position relative to the object that raised the event.
        /// </summary>
        /// <value>An integer that represents the y-coordinate in pixels.</value>
        [ScriptField]
        public extern int offsetY { get; }

        [ScriptField]
        public extern Event rawEvent { get; }

        /// <summary>
        /// Gets the x-coordinate of the mouse pointer's position relative to the screen top left.
        /// </summary>
        /// <value>An integer that represents the x-coordinate in pixels.</value>
        [ScriptField]
        public extern int screenX { get; }

        /// <summary>
        /// Gets the y-coordinate of the mouse pointer's position relative to the screen top left.
        /// </summary>
        /// <value>An integer that represents the y-coordinate in pixels.</value>
        [ScriptField]
        public extern int screenY { get; }

        /// <summary>
        /// Gets a value that indicates the state of the SHIFT key when the associated event occurred.
        /// </summary>
        [ScriptField]
        public extern bool shiftKey { get; }

        /// <summary>
        /// Gets the object that the event acted upon.
        /// </summary>
        [ScriptField]
        public extern HTMLElement target { get; }

        /// <summary>
        /// Gets the name of the event that was raised.
        /// </summary>
        [ScriptField]
        public extern string type { get; }

        /// <summary>
        /// Initializes a new <see cref="T:Sys.UI.DomEvent" /> object from the raw DHTML event.
        /// </summary>
        /// <param name="rawEvent">The raw DHTML event object.</param>
        public DomEvent(Event rawEvent)
        {
        }

        /// <summary>
        /// Adds a DOM event handler to the element that exposes the event.
        /// </summary>
        /// <param name="element">The element that exposes the event.</param>
        /// <param name="eventName">The name of the event. Do not include the "on" prefix. For example, specify "click" instead of "onclick".</param>
        /// <param name="handler">The client function that is called when the event occurs.</param>
        //TODO: use $addHandler when Blade supports it
        public extern static void addHandler(HTMLElement element, string eventName, DomEventHandler handler);

        /// <summary>
        /// Adds a DOM event handler to a singleton object represented by a type.
        /// (Eg. Window and Document)
        /// </summary>
        /// <param name="type">The singleton object represented by its type.</param>
        /// <param name="eventName">The name of the event. Do not include the "on" prefix. For example, specify "click" instead of "onclick".</param>
        /// <param name="handler">The client function that is called when the event occurs.</param>
        //TODO: use $addHandler when Blade supports it
        public extern static void addHandler(Type type, string eventName, DomEventHandler handler);

        /// <summary>
        /// Adds a list of DOM event handlers to the element that exposes the event.
        /// </summary>
        /// <param name="element">The element that exposes the event.</param>
        /// <param name="events">A dictionary of event handlers.</param>
        //TODO: use $addHandlers when Blade supports it
        public extern static void addHandlers(HTMLElement element, object events);

        /// <summary>
        /// Adds a list of DOM event handler to a singleton object represented by a type.
        /// (Eg. Window and Document)
        /// </summary>
        /// <param name="type">The singleton object represented by its type.</param>
        /// <param name="events">A dictionary of event handlers.</param>
        //TODO: use $addHandlers when Blade supports it
        public extern static void addHandlers(Type type, object events);

        /// <summary>
        /// Adds a list of DOM event handlers to the element that exposes the event.
        /// </summary>
        /// <param name="element">The element that exposes the event.</param>
        /// <param name="events">A dictionary of event handlers.</param>
        /// <param name="handleOwner">The object instance that is the context for the delegates that should be created from the handlers.</param>
        //TODO: use $addHandlers when Blade supports it
        public extern static void addHandlers(HTMLElement element, object events, object handleOwner);

        /// <summary>
        /// Adds a list of DOM event handlers to a singleton object represented by a type.
        /// (Eg. Window and Document)
        /// </summary>
        /// <param name="type">The element that exposes the event.</param>
        /// <param name="events">A dictionary of event handlers.</param>
        /// <param name="handleOwner">The object instance that is the context for the delegates that should be created from the handlers.</param>
        //TODO: use $addHandlers when Blade supports it
        public extern static void addHandlers(Type type, object events, object handleOwner);

        /// <summary>
        /// Removes all event handlers from the specified element.
        /// </summary>
        /// <param name="element">The element that exposes the events.</param>
        //TODO: use $clearHandlers when Blade supports it
        public extern static void clearHandlers(HTMLElement element);

        /// <summary>
        /// Prevents the default event action from happening.
        /// </summary>
        public extern void preventDefault();

        /// <summary>
        /// Removes a DOM event handler from the element that exposes the event.
        /// </summary>
        /// <param name="element">The element that exposes the event.</param>
        /// <param name="eventName">The name of the event. Do not include the "on" prefix. For example, specify "click" instead of "onclick".</param>
        /// <param name="handler">The client function that is called when the event occurs.</param>
        //TODO: use $removeHandler when Blade supports it
        public extern static void removeHandler(HTMLElement element, string eventName, DomEventHandler handler);

        /// <summary>
        /// Removes a DOM event handler from the singleton object represented by a type.
        /// (Eg. Window and Document)
        /// </summary>
        /// <param name="type">The element that exposes the event.</param>
        /// <param name="eventName">The name of the event. Do not include the "on" prefix. For example, specify "click" instead of "onclick".</param>
        /// <param name="handler">The client function that is called when the event occurs.</param>
        //TODO: use $removeHandler when Blade supports it
        public extern static void removeHandler(Type type, string eventName, DomEventHandler handler);

        /// <summary>
        /// Prevents an event from being propagated (bubbled) to parent elements.
        /// </summary>
        public extern void stopPropagation();
    }
}
