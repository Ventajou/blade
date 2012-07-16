using System;
namespace Sys.WebForms
{
    public delegate void BeginRequestEventHandler(object sender, BeginRequestEventArgs e);
    public delegate void EndRequestEventHandler(object sender, EndRequestEventArgs e);
    public delegate void InitializeRequestEventHandler(object sender, InitializeRequestEventArgs e);
    public delegate void PageLoadedEventHandler(object sender, PageLoadedEventArgs e);
    public delegate void PageLoadingEventHandler(object sender, PageLoadingEventArgs e);
}
