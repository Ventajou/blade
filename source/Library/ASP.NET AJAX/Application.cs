namespace Sys
{
    /// <summary>
    /// Provides members that support client-component development.
    /// </summary>
    public static class Application
    {
        /// <summary>
        /// Raised after all scripts have been loaded but before objects are created.
        /// </summary>        
        public extern static void add_init(EventHandler handler);
        public extern static void remove_init(EventHandler handler);
        //TODO: proper event when Blade allows it
        //public extern static event EventHandler init;

        /// <summary>
        /// Raised after all scripts have been loaded and the objects in the application have been
        /// created and initialized.
        /// </summary>
        public extern static void add_load(ApplicationLoadEventHandler handler);
        public extern static void remove_load(ApplicationLoadEventHandler handler);
        //TODO: proper event when Blade allows it
        //public extern static event ApplicationLoadEventHandler load;

        /// <summary>
        /// Occurs when the user clicks the browser's Back or Forward button.
        /// </summary>
        public extern static void add_navigate(HistoryEventHandler handler);
        public extern static void remove_navigate(HistoryEventHandler handler);
        //TODO: proper event when Blade allows it
        //public extern static event HistoryEventHandler navigate;

        /// <summary>
        /// Raised before all objects in the client application are disposed, typically when the DOM
        /// window.unload event is raised.
        /// </summary>
        public extern static void add_unload(EventHandler handler);
        public extern static void remove_unload(EventHandler handler);
        //TODO: proper event when Blade allows it
        //public extern static event EventHandler unload;

        /// <summary>
        /// Gets or sets a value that indicates whether the Web application supports history point management.
        /// </summary>
        public static bool enableHistory{get;set;}

        /// <summary>
        /// Gets a value that indicates whether the application is in the process of creating components.
        /// </summary>
        public extern static bool isCreatingComponents { get; }

        /// <summary>
        /// Registers a component with the application and initializes it if the component is not
        /// already initialized.
        /// </summary>
        /// <param name="component">An instance of a type derived from the <see cref="T:Sys.Component" /> class to register with the client application.</param>
        public extern static void addComponent(Component component);

        /// <summary>
        /// Creates a history point and adds it to the browser's history stack.
        /// </summary>
        /// <param name="state">A collection of key/value pairs that represent the state data. This data will be added to the main state to form the global state of the new history point.</param>
        public extern static void addHistoryPoint(object state);

        /// <summary>
        /// Creates a history point and adds it to the browser's history stack.
        /// </summary>
        /// <param name="state">A collection of key/value pairs that represent the state data. This data will be added to the main state to form the global state of the new history point.</param>
        /// <param name="title">The title for the new history point.</param>
        public extern static void addHistoryPoint(object state, string title);

        public extern static void beginCreateComponents();

        public extern static void endCreateComponents();

        /// <summary>
        /// Returns the specified <see cref="T:Sys.Component" /> object.
        /// </summary>
        /// <param name="id">A string that contains the ID of the component to find.</param>
        /// <returns>A Component object that contains the component requested by ID, if found; otherwise, null.</returns>
        //TODO: use $find when Blade supports it
        public extern static Component findComponent(string id);

        /// <summary>
        /// Returns the specified <see cref="T:Sys.Component" /> object.
        /// </summary>
        /// <param name="id">A string that contains the ID of the component to find.</param>
        /// <param name="parent">The component or element that contains the component to find.</param>
        /// <returns>A Component object that contains the component requested by ID, if found; otherwise, null.</returns>
        //TODO: use $find when Blade supports it
        public extern static Component findComponent(string id, IContainer parent);

        /// <summary>
        /// Returns an array of all components that have been registered with the application by
        /// using the <see cref="M:Sys.Application.AddComponent(Sys.Component)" /> method.
        /// </summary>
        /// <returns>An array of all components that have been registered with the application by using the AddComponent method.</returns>
        public extern static Component[] getComponents();

        /// <summary>
        /// Initializes the application and raises the <see cref="E:Sys.Application.Load" /> event.
        /// </summary>
        public extern static void initialize();

        /// <summary>
        /// Called by a referenced script to indicate that it has been loaded.
        /// </summary>
        public extern static void notifyScriptLoaded();

        /// <summary>
        /// Sequentially queues the scripts to be loaded in the queued order.
        /// </summary>
        /// <param name="scriptUrl">The URL for the referenced script.</param>
        public extern static void queueScriptReference(string scriptUrl);

        /// <summary>
        /// Registers with the application an object that will require disposing.
        /// </summary>
        /// <param name="disposableObject">The object to register.</param>
        public extern static void registerDisposableObject(IDisposable disposableObject);

        /// <summary>
        /// Removes the object from the application and disposes the object if it is disposable.
        /// </summary>
        /// <param name="component">The component to remove.</param>
        public extern static void removeComponent(Component component);

        /// <summary>
        /// Unregisters a disposable object from the application.
        /// </summary>
        /// <param name="disposableObject">The object to unregister.</param>
        public extern static void unregisterDisposableObject(IDisposable disposableObject);
    }
}
