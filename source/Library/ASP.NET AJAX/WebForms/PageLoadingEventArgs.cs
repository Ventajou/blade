using System;
using System.Html;

namespace Sys.WebForms
{
	public sealed class PageLoadingEventArgs : EventArgs
	{
        public extern object DataItems { get; }

        public extern HTMLElement[] PanelsDeleting { get; }

        public extern HTMLElement[] PanelsUpdating { get; }

        internal PageLoadingEventArgs()
		{
		}
	}
}
