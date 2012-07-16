using System;

namespace Sys.WebForms
{
    public sealed class PageRequestManager
    {
        public extern void add_beginRequest(BeginRequestEventHandler handler);
        public extern void remove_beginRequest(BeginRequestEventHandler handler);
        //TODO: proper event when Blade allows it
        //public event BeginRequestEventHandler beginRequest;

        public extern void add_endRequest(EndRequestEventHandler handler);
        public extern void remove_endRequest(EndRequestEventHandler handler);
        //TODO: proper event when Blade allows it
        //public event EndRequestEventHandler endRequest;

        public extern void add_initializeRequest(InitializeRequestEventHandler handler);
        public extern void remove_initializeRequest(InitializeRequestEventHandler handler);
        //TODO: proper event when Blade allows it
        //public event InitializeRequestEventHandler initializeRequest;

        public extern void add_pageLoaded(PageLoadedEventHandler handler);
        public extern void remove_pageLoaded(PageLoadedEventHandler handler);
        //TODO: proper event when Blade allows it
        //public event PageLoadedEventHandler pageLoaded;

        public extern void add_pageLoading(PageLoadingEventHandler handler);
        public extern void remove_pageLoading(PageLoadingEventHandler handler);
        //TODO: proper event when Blade allows it
        //public event PageLoadingEventHandler pageLoading;

        public extern bool isInAsyncPostBack{get;}

        private PageRequestManager()
        {
        }
        
        public extern void abortPostBack();

        public extern static PageRequestManager getInstance();
    }
}
