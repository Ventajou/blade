using System;

namespace Sys.UI
{
    /// <summary>
    /// Creates an object that contains a set of integer coordinates representing a position.
    /// </summary>
    public sealed class Point
    {
        /// <summary>
        /// Gets the x-coordinate of a <see cref="T:Sys.UI.Point" /> object in pixels.
        /// </summary>
        public int x;

        /// <summary>
        /// Gets the y-coordinate of a <see cref="T:Sys.UI.Point" /> object in pixels.
        /// </summary>
        public int y;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Sys.UI.Point" /> class.
        /// </summary>
        /// <param name="x">The number of pixels between the location and the left edge of the parent frame.</param>
        /// <param name="y">The number of pixels between the location and the top edge of the parent frame.</param>
        public Point(int x, int y)
        {
        }
    }
}
