using System;
using System.Html;

namespace Sys.UI
{
    /// <summary>
    /// Provides a base class for all Microsoft ASP.NET AJAX behaviors.
    /// </summary>
    public abstract class Behavior : Component
    {
        /// <summary>
        /// Gets the <see cref="T:System.DHTML.DOMElement" /> instance that the current <see cref="T:Sys.UI.Behavior" />
        /// object is associated with.
        /// </summary>
        public extern HTMLElement Element{get;}

        /// <summary>
        /// Gets or sets the name of the <see cref="T:Sys.UI.Behavior" /> object.
        /// </summary>
        public string Name{get;set;}

        /// <summary>
        /// Initializes a new instance of a behavior.
        /// </summary>
        /// <param name="element">The <see cref="T:System.DHTML.DOMElement" /> object to associate with the behavior.</param>
        protected Behavior(HTMLElement element)
        {
        }

        /// <summary>
        /// Gets a <see cref="T:Sys.UI.Behavior" /> instance that has the specified <see cref="P:Sys.UI.Behavior.Name" />
        /// property from the specified <see cref="T:Sys.UI.DomElement" /> object.
        /// </summary>
        /// <param name="element">The DOM element to search.</param>
        /// <param name="name">The name property of the Behavior instance to look for.</param>
        /// <returns>The specified Behavior object, if found; otherwise, null.</returns>
        public extern static Behavior getBehaviorByName(HTMLElement element, string name);

        /// <summary>
        /// Gets a collection that contains the behaviors associated with the specified <see cref="T:Sys.UI.DomElement" /> object.
        /// </summary>
        /// <param name="element">The DOM element to search.</param>
        /// <returns>An array of <see cref="T:Sys.UI.Behavior" /> objects.</returns>
        public extern static Behavior[] getBehaviors(HTMLElement element);

        /// <summary>
        /// Gets an array of behaviors that are of the specified <see cref="T:System.Type" /> from the
        /// specified <see cref="T:System.DHTML.DOMElement" /> instance.
        /// </summary>
        /// <param name="element">The DOM element to search.</param>
        /// <param name="type">The type of the <see cref="T:Sys.UI.Behavior" /> object to look for.</param>
        /// <returns>An array of all Behavior objects of the specified type associated with the specified DOM element instance, if found; otherwise, an empty array.</returns>
        public extern static Behavior[] getBehaviorsByType(HTMLElement element, Type type);
    }
}
