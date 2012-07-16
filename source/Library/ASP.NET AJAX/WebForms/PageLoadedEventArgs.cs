using System;
using System.Html;

namespace Sys.WebForms
{
    public sealed class PageLoadedEventArgs : EventArgs
    {
        public extern object DataItems { get; }

        public extern HTMLElement[] panelsCreated { get; }

        public extern HTMLElement[] panelsUpdated { get; }

        internal PageLoadedEventArgs()
        {
        }
    }
}
