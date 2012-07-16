using System;
using System.Html;

namespace Sys
{
    /// <summary>
    /// Provides the base class for the <see cref="T:Sys.UI.Control" /> and <see cref="T:Sys.UI.Behavior" /> classes,
    /// and for any other object whose lifetime should be managed by Microsoft ASP.NET AJAX.
    /// </summary>
    public abstract class Component : IDisposable, INotifyDisposing, INotifyPropertyChange
    {
        /// <summary>
        /// Raised when the <see cref="M:Sys.Component.Dispose" /> method is called for a component.
        /// </summary>
        public extern void add_disposing(EventHandler handler);
        public extern void remove_disposing(EventHandler handler);
        //TODO: proper event when Blade allows it
        //public extern event EventHandler disposing;

        /// <summary>
        /// Raised when a property changes.
        /// </summary>
        public extern void add_propertyChanged(PropertyChangedEventHandler handler);
        public extern void remove_propertyChanged(PropertyChangedEventHandler handler);
        //TODO: proper event when Blade allows it
        //public extern event PropertyChangedEventHandler propertyChanged;

        /// <summary>
        /// Gets an <see cref="T:Sys.EventHandlerList" /> object that contains references to all the events
        /// and handlers for the current <see cref="T:Sys.Component" /> object.
        /// </summary>
        protected extern EventHandlerList events { get; }

        /// <summary>
        /// Gets or sets the ID of the current <see cref="T:Sys.Component" /> object.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets a value indicating whether the current <see cref="T:Sys.Component" /> object is initialized.
        /// </summary>
        protected extern bool isInitialized { get; }

        /// <summary>
        /// Gets a value indicating whether the current <see cref="T:Sys.Component" /> object is updating.
        /// </summary>
        protected extern bool isUpdating { get; }

        /// <summary>
        /// Sets the <see cref="P:Sys.Component.IsUpdating" /> property of the current <see cref="T:Sys.Component" /> object to true.
        /// </summary>
        public extern virtual void beginUpdate();

        /// <summary>
        /// Returns a new instance of the <see cref="T:Sys.Component" /> class that uses the specified
        /// parameters and calls the <see cref="M:Sys.Component.Initialize" /> method.
        /// </summary>
        /// <param name="type">The type of the component to create.</param>
        /// <returns>A new instance of the Component class that uses the specified parameters.</returns>
        //TODO: use $create when Blade supports it
        public extern static Component create(Type type);

        /// <summary>
        /// Returns a new instance of the <see cref="T:Sys.Component" /> class that uses the specified
        /// parameters and calls the <see cref="M:Sys.Component.Initialize" /> method.
        /// </summary>
        /// <param name="type">The type of the component to create.</param>
        /// <param name="properties">A JSON object that describes the properties and their values.</param>
        /// <param name="events">A JSON object that describes the events and their handlers.</param>
        /// <param name="references">A JSON object that describes the properties that are references to other components.</param>
        /// <param name="element">The DOM element the component must be attached to.</param>
        /// <returns>A new instance of the Component class that uses the specified parameters.</returns>
        //TODO: use $create when Blade supports it
        public extern static Component create(Type type, object properties, object events, object references, HTMLElement element);

        /// <summary>
        /// Raises the <see cref="E:Sys.Component.Disposing" /> event of the current <see cref="T:Sys.Component" /> object
        /// and removes the component from the application.
        /// </summary>
        public extern virtual void dispose();

        /// <summary>
        /// Sets the <see cref="P:Sys.Component.IsUpdating" /> property of the current <see cref="T:Sys.Component" /> object
        /// to false, calls the <see cref="M:Sys.Component.Initialize" /> method if it has not already been called,
        /// and then calls the <see cref="M:Sys.Component.Updated" /> method.
        /// </summary>
        public extern virtual void endUpdate();

        /// <summary>
        /// Sets the <see cref="P:Sys.Component.IsInitialized" /> property of the current <see cref="T:Sys.Component" />
        /// object to true.
        /// </summary>
        public extern virtual void initialize();

        /// <summary>
        /// Raises the <see cref="E:Sys.Component.PropertyChanged" /> event for the specified property.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
        protected extern void raisePropertyChanged(string propertyName);

        /// <summary>
        /// Has no built-in functionality; the Updated method is a placeholder for post-update logic
        /// in derived classes.
        /// </summary>
        protected extern virtual void updated();
    }
}