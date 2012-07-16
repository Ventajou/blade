namespace Sys
{
    /// <summary>
    /// Used by event sources that enable the handler to cancel the operation in progress.
    /// </summary>
    public class CancelEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets a value that specifies whether the event source should cancel the operation that caused the event.
        /// </summary>
        /// <value>true to request that the event be canceled; otherwise, false. The default is false.</value>
        public bool cancel { get; set; }
    }
}
