using System;
using System.Dom;
using System.Html;
using Sys;

namespace Application
{
    public class Timer : Component
    {
        public void add_timer(Sys.EventHandler handler)
        {
            events.addHandler("timer", handler);
        }

        public void remove_timer(Sys.EventHandler handler)
        {
            events.removeHandler("timer", handler);
        }

        public override void initialize()
        {
            window.setInterval(
                (Action)(() =>
                {
                    window.document.writeln(new Date().toString());
                    var handler = (Sys.EventHandler)events.getHandler("timer");
                    if (handler != null) handler(this, EventArgs.Empty);
                }), 1000);

            base.initialize();
        }
    }
}
