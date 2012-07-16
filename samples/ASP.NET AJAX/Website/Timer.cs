using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:Timer runat=server></{0}:Timer>")]
    public class Timer : ScriptControl
    {
        protected override IEnumerable<ScriptDescriptor> GetScriptDescriptors()
        {
            var descriptor = new ScriptComponentDescriptor("Application.Timer");
            descriptor.ID = "Timer";
            yield return descriptor;
        }

        protected override IEnumerable<ScriptReference> GetScriptReferences()
        {
            yield return new ScriptReference(ResolveClientUrl("~/scripts/blade.js")); 
            yield return new ScriptReference(ResolveClientUrl("~/scripts/application.js"));
        }
    }
}
