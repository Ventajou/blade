using System;
using System.Dom;

namespace Sys.Net
{
    /// <summary>
    /// Makes asynchronous network requests by using the browser's XMLHTTP support.
    /// </summary>
    public sealed class XMLHttpExecutor : WebRequestExecutor
    {
        /// <summary>
        /// Gets a value indicating whether the request associated with the executor was aborted.
        /// </summary>
        public extern override bool aborted { get; }

        /// <summary>
        /// Gets a value indicating whether the request completed successfully.
        /// </summary>
        public extern override bool responseAvailable { get; }

        /// <summary>
        /// Gets the text representation of the response body.
        /// </summary>
        public extern override string responseData { get; }

        /// <summary>
        /// Returns a value indicating whether the executor has started processing the request.
        /// </summary>
        public extern override bool started { get; }

        /// <summary>
        /// Gets a success status code.
        /// </summary>
        public extern override int statusCode { get; }

        /// <summary>
        /// Gets status information about a request that completed successfully.
        /// </summary>
        public extern override string statusText { get; }

        /// <summary>
        /// Gets a value indicating whether the request timed out.
        /// </summary>
        public extern override bool timedOut { get; }

        /// <summary>
        /// Attempts to get the response to the current request as an XMLDOM object.
        /// </summary>
        //TODO: use XMLDocument when that's available
        public extern override object xml { get; }

        internal XMLHttpExecutor()
        {
        }

        /// <summary>
        /// Stops the pending network request issued by the executor.
        /// </summary>
        public extern override void abort();

        /// <summary>
        /// Instructs the executor to execute a Web request.
        /// </summary>
        protected extern override void executeRequest();

        /// <summary>
        /// Gets the value of the specified response header.
        /// </summary>
        /// <returns>The specified response header.</returns>
        public extern override string getResponseHeader(string header);

        /// <summary>
        /// Gets all the response headers for the current request.
        /// </summary>
        /// <returns>All the response headers for the current request.</returns>
        public extern override string getAllResponseHeaders();
    }
}
