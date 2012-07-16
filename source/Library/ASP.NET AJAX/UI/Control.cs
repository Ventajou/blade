using System;
using System.Html;

namespace Sys.UI
{
	/// <summary>
	/// Provides the base class for all Microsoft ASP.NET AJAX controls.
	/// </summary>
	public abstract class Control : Component
	{
		/// <summary>
		/// Gets the <see cref="T:System.DHTML.DOMElement" /> instance that the current <see cref="T:Sys.UI.Control" />
		/// object is associated with.
		/// </summary>
        public extern HTMLElement element{get;}

        /// <summary>
		/// Gets or sets the parent control associated with the current control.
		/// </summary>
		public Control parent{get;set;}

        /// <summary>
		/// Gets or sets the visibility of the current <see cref="T:Sys.UI.Control" /> object.
		/// </summary>
		public bool visible{get;set;}

        /// <summary>
		/// Gets or sets the <see cref="T:Sys.UI.VisibilityMode" /> value for the current <see cref="T:Sys.UI.Control" /> object.
		/// </summary>
		public VisibilityMode visibilityMode{get;set;}

        /// <summary>
		/// Initializes a new instance of a Control.
		/// </summary>
		/// <param name="element">The <see cref="T:System.DHTML.DOMElement" /> object that the control will be associated with.</param>
        protected Control(HTMLElement element)
		{
		}
		
        /// <summary>
		/// Adds a CSS class to a <see cref="T:Sys.UI.Control" /> object.
		/// </summary>
		/// <param name="className">A string that contains the name of the CSS class to add.</param>
		public extern void addCssClass(string className);

        /// <summary>
		/// Handles events raised by the <see cref="M:Sys.UI.Control.RaiseBubbleEvent(System.Object,Sys.EventArgs)" /> method.
		/// </summary>
		/// <param name="sender">The object that triggered the event.</param>
		/// <param name="e">The <see cref="T:Sys.EventArgs" /> object that contains the event data.</param>
		/// <returns>true if the event was handled; false otherwise.</returns>
		protected extern virtual bool onBubbleEvent(object sender, EventArgs e);

        /// <summary>
		/// Bubbles an event to the parent control.
		/// </summary>
		/// <param name="sender">The object that triggered the event.</param>
		/// <param name="e">The <see cref="T:Sys.EventArgs" /> object that contains the event data.</param>
		protected extern void raiseBubbleEvent(object sender, EventArgs e);

        /// <summary>
		/// Removes a CSS class from a <see cref="T:Sys.UI.Control" /> object.
		/// </summary>
		/// <param name="className">A string that contains the name of the CSS class to remove.</param>
		public extern void removeCssClass(string className);

        /// <summary>
		/// Toggles a CSS class of a <see cref="T:Sys.UI.Control" /> object.
		/// </summary>
		/// <param name="className">A string that contains the name of the CSS class to toggle.</param>
		public extern void toggleCssClass(string className);
	}
}
