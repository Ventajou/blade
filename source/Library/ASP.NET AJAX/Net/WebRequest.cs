using System;

namespace Sys.Net
{
    /// <summary>
    /// Provides an API to make Web requests.
    /// </summary>
    public sealed class WebRequest
    {
        /// <summary>
        /// Occurs when the work being performed by the associated executor is finished. An executor
        /// finishes its work in one of three states: completed, aborted, or timed out.
        /// </summary>
        public extern void add_completed(WebRequestCompletedCallback handler);
        public extern void remove_completed(WebRequestCompletedCallback handler);
        //TODO: proper event when Blade allows it
        //public event WebRequestCompletedCallback completed;

        /// <summary>
        /// Gets or sets the HTTP body of the WebRequest.
        /// </summary>
        public string body { get; set; }

        /// <summary>
        /// Gets the executor of the associated <see cref="T:Sys.Net.WebRequest" /> instance.
        /// </summary>
        public extern WebRequestExecutor executor { get; }

        /// <summary>
        /// Gets the dictionary of name/value pairs that contains the HTTP headers that are sent with the Web request.
        /// </summary>
        public extern object headers { get; }

        /// <summary>
        /// Gets or sets the HTTP verb for the Web request, which must be an HTTP verb that is recognized by the Web server, such as "GET" or "POST".
        /// </summary>
        public string httpVerb { get; set; }

        /// <summary>
        /// Gets or sets the time-out value in milliseconds for the <see cref="T:Sys.Net.WebRequest" /> instance.
        /// </summary>
        public int timeout { get; set; }

        /// <summary>
        /// Gets or sets the URL of the <see cref="T:Sys.Net.WebRequest" /> instance.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Gets or sets the user context associated with the <see cref="T:Sys.Net.WebRequest" /> instance.
        /// </summary>
        public object userContext { get; set; }

        /// <summary>
        /// Gets the resolved URL of the <see cref="T:Sys.Net.WebRequest" /> instance.
        /// </summary>
        /// <returns>
        /// The absolute URL representation of the URL associated with the WebRequest instance.
        /// The URL includes the protocol identifier and the fully qualified domain name.
        /// </returns>
        public extern string getResolvedUrl();

        /// <summary>
        /// Executes the Web request.
        /// </summary>
        public extern void invoke();
    }
}
