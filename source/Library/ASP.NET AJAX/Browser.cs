using System;

namespace Sys
{
    /// <summary>
    /// Contains information about the browser.
    /// </summary>
    public static class Browser
    {
        /// <summary>
        /// Represents the Internet Explorer browsers.
        /// </summary>
        public static readonly object InternetExplorer;

        /// <summary>
        /// Represents the Firefox browsers.
        /// </summary>
        public static readonly object Firefox;

        /// <summary>
        /// Represents the Safari browser.
        /// </summary>
        public static readonly object Safari;

        /// <summary>
        /// Represents the Opera browser.
        /// </summary>
        public static readonly object Opera;

        /// <summary>
        /// Gets the current <see cref="T:Sys.Browser" /> object (usage: Browser.Agent == Browser.InternetExplorer)
        /// </summary>
        [ScriptField]
        public extern static object agent { get; }

        /// <summary>
        /// Returns a value that indicates whether the browser supports a "debugger" statement,
        /// which suspends execution of the script and acts like a breakpoint.
        /// </summary>
        [ScriptField]
        public extern static bool hasDebuggerStatement { get; }

        /// <summary>
        /// Gets the name of the browser.
        /// </summary>
        [ScriptField]
        public extern static string name { get; }

        /// <summary>
        /// Gets the version of the browser.
        /// </summary>
        [ScriptField]
        public extern static float version { get; }
    }
}
