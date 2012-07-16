namespace Sys
{
    /// <summary>
    /// This class is used by the Sys.Application class to hold event arguments for the Navigate event.
    /// </summary>
    public class HistoryEventArgs : EventArgs
    {
        /// <summary>
        /// Retrieves a collection of name/value pairs that represent the state of the page.
        /// </summary>
        public extern object state { get; }

        internal HistoryEventArgs()
        {
        }
    }
}
