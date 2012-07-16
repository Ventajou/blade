using System;
using System.Html;

namespace Sys.WebForms
{
    public sealed class BeginRequestEventArgs : EventArgs
    {
        public extern HTMLElement postBackElement { get; }

        public extern object request { get; }

        internal BeginRequestEventArgs()
        {
        }
    }
}
