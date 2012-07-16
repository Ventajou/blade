using System;

namespace Sys.WebForms
{
    public sealed class EndRequestEventArgs : EventArgs
    {
        public extern object dataItems { get; }

        public extern Exception error { get; }

        public bool errorHandled { get; set; }

        public extern object response { get; }

        internal EndRequestEventArgs()
        {
        }
    }
}
