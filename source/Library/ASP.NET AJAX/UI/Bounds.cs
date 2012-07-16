using System;

namespace Sys.UI
{
	/// <summary>
	/// Creates an object that contains a set of integer coordinates representing position, width, and height.
	/// </summary>
	public sealed class Bounds
	{
		/// <summary>
		/// Gets the x-coordinate of a <see cref="T:Sys.UI.Bounds" /> object in pixels.
		/// </summary>
		public int X;

        /// <summary>
		/// Gets the y-coordinate of a <see cref="T:Sys.UI.Bounds" /> object in pixels.
		/// </summary>
		public int Y;

        /// <summary>
		/// Gets the width of a <see cref="T:Sys.UI.Bounds" /> object in pixels.
		/// </summary>
		public int Width;

        /// <summary>
		/// Gets the height of a <see cref="T:Sys.UI.Bounds" /> object in pixels.
		/// </summary>
		public int Height;

        /// <summary>
		/// Initializes a new instance of the <see cref="T:Sys.UI.Bounds" /> class.
		/// </summary>
		/// <param name="x">The number of pixels between the location and the left edge of the parent frame.</param>
		/// <param name="y">The number of pixels between the location and the top edge of the parent frame.</param>
		/// <param name="width">The width in pixels.</param>
		/// <param name="height">The height in pixels.</param>
		public Bounds(int x, int y, int width, int height)
		{
		}
	}
}
