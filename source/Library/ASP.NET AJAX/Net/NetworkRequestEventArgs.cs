using System;

namespace Sys.Net
{
    /// <summary>
    /// Contains information about a Web request that is ready to be sent to the current
    /// <see cref="T:Sys.Net.WebRequestExecutor" /> instance.
    /// </summary>
    public sealed class NetworkRequestEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Gets the Web request to be routed to the current <see cref="T:Sys.Net.WebRequestExecutor" /> instance.
        /// </summary>
        public extern WebRequest webRequest { get; }

        internal NetworkRequestEventArgs()
        {
        }
    }
}
