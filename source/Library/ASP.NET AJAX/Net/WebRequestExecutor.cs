using System;
using System.Dom;

namespace Sys.Net
{
    /// <summary>
    /// Provides the abstract base class from which network executors derive.
    /// </summary>
    public abstract class WebRequestExecutor
    {
        /// <summary>
        /// Gets a value indicating whether the request associated with the executor was aborted.
        /// </summary>
        public abstract bool aborted { get; }

        /// <summary>
        /// Gets the result object by JSON deserializing the response data.
        /// </summary>
        [ScriptName("object")]
        public extern virtual object @object { get; }

        /// <summary>
        /// Gets a value indicating whether the request completed successfully.
        /// </summary>
        public abstract bool responseAvailable { get; }

        /// <summary>
        /// Gets the text representation of the response body.
        /// </summary>
        public abstract string responseData { get; }

        /// <summary>
        /// Returns a value indicating whether the executor has started processing the request.
        /// </summary>
        public abstract bool started { get; }

        /// <summary>
        /// Gets the status code of the response associated with the request being processed.
        /// </summary>
        public abstract int statusCode { get; }

        /// <summary>
        /// Gets the status text of the response associated with the request being processed.
        /// </summary>
        public abstract string statusText { get; }

        /// <summary>
        /// Gets a value indicating whether the request timed out.
        /// </summary>
        public abstract bool timedOut { get; }

        /// <summary>
        /// Gets the associated <see cref="P:Sys.Net.WebRequestExecutor.WebRequest" /> object.
        /// </summary>
        public extern WebRequest webRequest { get; }

        /// <summary>
        /// Attempts to get the response to the current request as an XMLDOM object.
        /// </summary>
        //TODO: use XMLDocument when that's available
        public abstract object xml { get; }

        /// <summary>
        /// Stops the pending network request issued by the executor.
        /// </summary>
        public abstract void abort();

        /// <summary>
        /// Instructs the executor to execute a Web request.
        /// </summary>
        protected abstract void executeRequest();

        /// <summary>
        /// Gets the value of the specified response header.
        /// </summary>
        /// <returns>The specified response header.</returns>
        public abstract string getResponseHeader(string header);

        /// <summary>
        /// Gets all the response headers for the current request.
        /// </summary>
        /// <returns>All the response headers for the current request.</returns>
        public abstract string getAllResponseHeaders();
    }
}
