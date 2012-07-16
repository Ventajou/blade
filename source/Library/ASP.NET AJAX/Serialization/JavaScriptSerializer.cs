using System;

namespace Sys.Serialization
{
    /// <summary>
    /// Serializes ECMAScript (JavaScript) types into JSON-formatted data and deserializes
    /// JSON-formatted data into JavaScript types.
    /// </summary>
    public static class JavaScriptSerializer
    {
        /// <summary>
        /// Converts a JSON string into an ECMAScript (JavaScript) object graph.
        /// </summary>
        /// <param name="s">The JSON string to deserialize.</param>
        /// <returns></returns>
        public extern static object Deserialize(string s);

        /// <summary>
        /// Converts an ECMAScript (JavaScript) object graph into a JSON string.
        /// </summary>
        /// <param name="o">The JavaScript object graph to serialize.</param>
        /// <returns>A JSON string representation of the JavaScript object graph.</returns>
        public extern static string Serialize(object o);
    }
}
