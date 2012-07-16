namespace Sys
{
    /// <summary>
    /// Provides a specialized event arguments collection for the <see cref="E:Sys.Application.Load">Load</see>
    /// event of the <see cref="T:Sys.Application" /> class.
    /// </summary>
    public class ApplicationLoadEventArgs : EventArgs
    {
        /// <summary>
        /// Gets an array of all the components that were created since the last time the
        /// <see cref="E:Sys.Application.Load">Load</see> event was raised.
        /// </summary>
        public Component[] Components
        {
            get
            {
                return null;
            }
        }
        /// <summary>
        /// Returns a value that indicates whether the page is engaged in a partial-page update.
        /// </summary>
        public bool IsPartialLoad
        {
            get
            {
                return false;
            }
        }
        internal ApplicationLoadEventArgs()
        {
        }
    }
}
