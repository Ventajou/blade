using System;

namespace Sys
{
    /// <summary>
    /// Provides a common interface for all components that can contain other components.
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        /// Adds a <see cref="T:Sys.Component" /> object to the current container.
        /// </summary>
        /// <param name="component">The Component object to add.</param>
        void addComponent(Component component);

        /// <summary>
        /// Returns an array of all objects in the current container that inherit from <see cref="T:Sys.Component" />.
        /// </summary>
        /// <returns>An array of all objects in the current container that inherit from Component.</returns>
        Component[] getComponents();

        /// <summary>
        /// Returns the specified <see cref="T:Sys.Component" /> instance.
        /// </summary>
        /// <param name="id">The ID of the Component object to search for.</param>
        /// <returns>The Component instance with the specified ID.</returns>
        Component findComponent(string id);

        /// <summary>
        /// Removes a <see cref="T:Sys.Component" /> object from the current container.
        /// </summary>
        /// <param name="component">The Component object to remove.</param>
        void removeComponent(Component component);
    }
}
