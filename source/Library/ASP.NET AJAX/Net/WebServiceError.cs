using System;

namespace Sys.Net
{
    /// <summary>
    /// Represents the object type returned to the browser when a Web service issues an error.
    /// </summary>
    public sealed class WebServiceError
    {
        /// <summary>
        /// Gets the error exception type.
        /// </summary>
        public extern string exceptionType { get; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        public extern string message { get; }

        /// <summary>
        /// Gets the error stack trace.
        /// </summary>
        public extern string stackTrace { get; }

        /// <summary>
        /// Gets the underlying HTTP error status code for the Web request.
        /// </summary>
        public extern int statusCode { get; }

        /// <summary>
        /// Gets a value that indicates whether the Web service failed because of a time-out.
        /// </summary>
        public extern bool timedOut { get; }

        internal WebServiceError()
        {
        }
    }
}
