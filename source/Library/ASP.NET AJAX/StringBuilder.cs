using System;
namespace Sys
{
    /// <summary>
    /// Provides an optimized mechanism to concatenate strings.
    /// </summary>
    public sealed class StringBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Sys.StringBuilder" /> class.
        /// </summary>
        public StringBuilder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Sys.StringBuilder" /> class.
        /// </summary>
        /// <param name="initialText">
        /// The string that is used to initialize the value of the instance. If the value is null,
        /// the new StringBuilder instance will contain an empty string ("").
        /// </param>
        public StringBuilder(string initialText)
        {
        }

        /// <summary>
        /// Appends a copy of a specified string to the end of the <see cref="T:Sys.StringBuilder" /> instance.
        /// </summary>
        /// <param name="text">The string to append to the end of the StringBuilder instance.</param>
        public extern void append(string text);

        /// <summary>
        /// Appends a string with a line terminator to the end of the <see cref="T:Sys.StringBuilder" /> instance.
        /// </summary>
        public extern void appendLine();

        /// <summary>
        /// Appends a string with a line terminator to the end of the <see cref="T:Sys.StringBuilder" /> instance.
        /// </summary>
        /// <param name="text">The string to append with a line terminator to the end fo the StringBuilder instance.</param>
        public extern void appendLine(string text);

        /// <summary>
        /// Clears the contents of the <see cref="T:Sys.StringBuilder" /> instance.
        /// </summary>
        public extern void clear();

        /// <summary>
        /// Determines whether the <see cref="T:Sys.StringBuilder" /> object has any content.
        /// </summary>
        /// <returns>true if the StringBuilder instance contains no elements; otherwise, false.</returns>
        public extern bool isEmpty();

        /// <summary>
        /// Creates a string from the contents of a <see cref="T:Sys.StringBuilder" /> instance.
        /// </summary>
        /// <returns>A string representation of the StringBuilder instance.</returns>
        public extern override string toString();

        /// <summary>
        /// Creates a string from the contents of a <see cref="T:Sys.StringBuilder" /> instance, and
        /// optionally inserts a delimiter between each element of the created string.
        /// </summary>
        /// <param name="separator">A string to append between each element of the string that is returned.</param>
        /// <returns>
        /// A string representation of the StringBuilder instance. If <paramref name="separator" />
        /// is specified, the delimiter string is inserted between each element of the returned string.
        /// </returns>
        public extern string toString(string separator);
    }
}
