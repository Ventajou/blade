using System;

namespace Sys
{
    /// <summary>
    /// Represents a culture definition that can be applied to other objects that accept a culture-related setting.
    /// </summary>
    public sealed class CultureInfo
    {
        /// <summary>
        /// Applies the current culture when you create a <see cref="T:Sys.CultureInfo" /> object.
        /// </summary>
        [ScriptField]
        public extern static CultureInfo CurrentCulture { get; }

        /// <summary>
        /// Applies the invariant (culture-independent) culture when you create a <see cref="T:Sys.CultureInfo" /> object.
        /// </summary>
        [ScriptField]
        public extern static CultureInfo InvariantCulture { get; }

        /// <summary>
        /// Gets an object that contains an array of culture-sensitive formatting strings that can be applied to Date type extensions.
        /// </summary>
        [ScriptField]
        public extern object dateTimeFormat { get; }

        /// <summary>
        /// Gets the culture value (locale) that represents a language and region.
        /// </summary>
        [ScriptField]
        public extern string name { get; }

        /// <summary>
        /// Gets an object that contains an array of culture-sensitive formatting strings that can be applied to Number type extensions.
        /// </summary>
        [ScriptField]
        public extern object numberFormat { get; }

        internal CultureInfo()
        {
        }
    }
}
