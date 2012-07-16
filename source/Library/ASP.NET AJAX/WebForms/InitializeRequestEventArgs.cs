using System;
using System.Html;

namespace Sys.WebForms
{
    public sealed class InitializeRequestEventArgs : CancelEventArgs
    {
        public extern HTMLElement postBackElement { get; }

        public extern object request { get; }

        internal InitializeRequestEventArgs()
        {
        }
    }
}
