namespace Sys
{
    public delegate void ApplicationLoadEventHandler(object sender, ApplicationLoadEventArgs e);

    public delegate void CancelEventHandler(object sender, CancelEventArgs e);

    public delegate void HistoryEventHandler(object sender, HistoryEventArgs e);

    /// <summary>
    /// Delegate for handling generic events.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The <see cref="T:Sys.EventArgs" /> object that contains the event data.</param>
    public delegate void EventHandler(object sender, EventArgs e);

    /// <summary>
    /// Delegate for the <see cref="E:Sys.INotifyPropertyChange.PropertyChanged" /> event.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The <see cref="T:Sys.PropertyChangedEventArgs" /> object that contains the event data.</param>
    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);
}