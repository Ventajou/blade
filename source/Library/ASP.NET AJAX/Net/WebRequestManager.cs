using System;

namespace Sys.Net
{
    /// <summary>
    /// Manages the flow of Web requests between the <see cref="T:Sys.Net.WebRequest" /> object and the
    /// executor instance that makes the network requests.
    /// </summary>
    public static class WebRequestManager
    {
        /// <summary>
        /// Occurs before the Web request has executed.
        /// </summary>
        public extern static void add_invokingRequest(NetworkRequestEventHandler handler);
        public extern static void remove_invokingRequest(NetworkRequestEventHandler handler);
        //TODO: proper event when Blade allows it
        //public static event NetworkRequestEventHandler invokingRequest;

        /// <summary>
        /// Occurs after a web request has executed.
        /// </summary>
        public extern static void add_completedRequest(EventHandler handler);
        public extern static void remove_completedRequest(EventHandler handler);
        //TODO: proper event when Blade allows it
        //public static event EventHandler completedRequest;

        /// <summary>
        /// Gets or sets the default network executor type that is used to make network requests.
        /// </summary>
        public static string defaultExecutorType { get; set; }

        /// <summary>
        /// Gets or sets the time-out for the default network executor.
        /// </summary>
        /// <value>The time in milliseconds that the default executor should wait before timing out a Web request. This value must be 0 or a positive integer.</value>
        public static int defaultTimeout { get; set; }
    }
}
