using System;
using System.Html;

namespace Sys.UI
{
	/// <summary>
	/// Defines static methods and properties that set attributes and provide information about DOM elements.
	/// </summary>
	public static class DomElement
	{
		/// <summary>
		/// Adds a CSS class to an element if the element does not already have it CSS class.
		/// </summary>
		/// <param name="element">The <see cref="T:Sys.UI.DomElement" /> object to add the CSS class to.</param>
		/// <param name="className">The name of the CSS class to add.</param>
        public extern static void addCssClass(HTMLElement element, string className);

        /// <summary>
		/// Returns a value that indicates whether the element contains the specified CSS class.
		/// </summary>
		/// <param name="element">The <see cref="T:Sys.UI.DomElement" /> object to test for the CSS class.</param>
		/// <param name="className">The name of the CSS class to test for.</param>
        public extern static bool containsCssClass(HTMLElement element, string className);

        /// <summary>
		/// Gets a set of integer coordinates that represent the position, width, and height of an element.
		/// </summary>
		/// <param name="element">The <see cref="T:Sys.UI.DomElement" /> instance to get the coordinates of.</param>
		/// <returns>A JSON-formatted object that contains the x-coordinate and y-coordinate of the upper-left corner, the width, and the height of the element in pixels.</returns>
        public extern static Bounds getBounds(HTMLElement element);

        /// <summary>
		/// Gets an element that has the specified id attribute.
		/// </summary>
		/// <param name="id">The ID of the element to find.</param>
		/// <returns>The element with the specified ID.</returns>
        //TODO: use $get when Blade supports it
        public extern static HTMLElement getElementById(string id);

        /// <summary>
		/// Gets an element that has the specified id attribute.
		/// </summary>
		/// <param name="id">The ID of the element to find.</param>
		/// <param name="element">The parent element to search in. The default is the document element.</param>
		/// <returns>The element with the specified ID.</returns>
        //TODO: use $get when Blade supports it
        public extern static HTMLElement getElementById(string id, HTMLElement element);

        /// <summary>
		/// Gets the absolute position of an element relative to the upper-left corner of the browser window.
		/// </summary>
		/// <param name="element">The target element.</param>
		/// <returns>A JSON-formatted object that contains the x-coordinate and y-coordinate of the element in pixels.</returns>
        public extern static Point getLocation(HTMLElement element);

        /// <summary>
		/// Removes a CSS class from an element.
		/// </summary>
		/// <param name="element">The <see cref="T:Sys.UI.DomElement" /> object to remove the CSS class from.</param>
		/// <param name="className">The name of the CSS class to remove.</param>
        public extern static void removeCssClass(HTMLElement element, string className);

        /// <summary>
		/// Sets the position of an element.
		/// </summary>
		/// <param name="element">The target element.</param>
		/// <param name="x">The x-coordinate in pixels.</param>
		/// <param name="y">The y-coordinate in pixels.</param>
        public extern static void setLocation(HTMLElement element, int x, int y);

        /// <summary>
		/// Toggles a CSS class in an element.
		/// </summary>
		/// <param name="element">The element to toggle.</param>
		/// <param name="className">The name of the CSS class to toggle.</param>
        public extern static void toggleCssClass(HTMLElement element, string className);
	}
}
