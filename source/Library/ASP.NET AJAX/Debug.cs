namespace Sys
{
    /// <summary>
    /// Provides debugging and tracing functionality for client code. This is a static class that
    /// is invoked directly without creating an instance of the class.
    /// </summary>
    public static class Debug
    {
        /// <summary>
        /// Checks for a condition, and if false, displays a message and prompts the user to break into the debugger.
        /// </summary>
        /// <param name="condition">true to continue to execute code; false to display message and break into the debugger.</param>
        public extern static void assert(bool condition);

        /// <summary>
        /// Checks for a condition, and if false, displays a message and prompts the user to break into the debugger.
        /// </summary>
        /// <param name="condition">true to continue to execute code; false to display message and break into the debugger.</param>
        /// <param name="message">The message to display. The default is an empty string ("").</param>
        public extern static void assert(bool condition, string message);

        /// <summary>
        /// Checks for a condition, and if false, displays a message and prompts the user to break into the debugger.
        /// </summary>
        /// <param name="condition">true to continue to execute code; false to display message and break into the debugger.</param>
        /// <param name="message">The message to display. The default is an empty string ("").</param>
        /// <param name="displayCaller">true to indicate that the name of the function that is calling assert should be displayed in the message. The default is false.</param>
        public extern static void assert(bool condition, string message, bool displayCaller);

        /// <summary>
        /// Clears all trace messages from the debugger output console.
        /// </summary>
        public extern static void clearTrace();

        /// <summary>
        /// Displays a message in the debugger's output window and breaks into the debugger.
        /// </summary>
        /// <param name="message">The message to display.</param>
        public extern static void fail(string message);

        /// <summary>
        /// Appends a text line to the debugger console and to the <c>TraceConsole&lt;textarea&gt;</c> element, if available.
        /// </summary>
        /// <param name="text">The text to display.</param>
        public extern static void trace(string text);

        /// <summary>
        /// Dumps an object to the debugger console and to the <c>TraceConsole&lt;textarea&gt;</c> element, if available.
        /// </summary>
        /// <param name="obj">The object to dump.</param>
        public extern static void traceDump(object obj);

        /// <summary>
        /// Dumps an object to the debugger console and to the <c>TraceConsole&lt;textarea&gt;</c> element, if available.
        /// </summary>
        /// <param name="obj">The object to dump.</param>
        /// <param name="name">The name of the object.</param>
        public extern static void traceDump(object obj, string name);
    }
}
