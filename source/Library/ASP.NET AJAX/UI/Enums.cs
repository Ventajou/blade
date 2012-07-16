using System;
namespace Sys.UI
{
    /// <summary>
    /// Describes common key codes.
    /// </summary>
    public enum Key
    {
        /// <summary>
        /// Represents the BACKSPACE key.
        /// </summary>
        backspace = 8,
        /// <summary>
        /// Represents the TAB key.
        /// </summary>
        tab = 9,
        /// <summary>
        /// Represents the ENTER key.
        /// </summary>
        enter = 13,
        /// <summary>
        /// Represents the ESC key.
        /// </summary>
        esc = 27,
        /// <summary>
        /// Represents the SPACEBAR key.
        /// </summary>
        space = 32,
        /// <summary>
        /// Represents the PAGE UP key.
        /// </summary>
        pageUp = 33,
        /// <summary>
        /// Represents the PAGE DOWN key.
        /// </summary>
        pageDown = 34,
        /// <summary>
        /// Represents the END key.
        /// </summary>
        end = 35,
        /// <summary>
        /// Represents the HOME key.
        /// </summary>
        home = 36,
        /// <summary>
        /// Represents the LEFT ARROW key.
        /// </summary>
        left = 37,
        /// <summary>
        /// Represents the UP ARROW key.
        /// </summary>
        up = 38,
        /// <summary>
        /// Represents the RIGHT ARROW key.
        /// </summary>
        right = 39,
        /// <summary>
        /// Represents the DOWN ARROW key.
        /// </summary>
        down = 40,
        /// <summary>
        /// Represents the DELETE key.
        /// </summary>
        del = 127
    }

    /// <summary>
    /// Describes mouse buttons.
    /// </summary>
    public enum MouseButton
    {
        /// <summary>
        /// Represents the left mouse button.
        /// </summary>
        leftButton = 0,
        /// <summary>
        /// Represents the wheel button (middle mouse button).
        /// </summary>
        middleButton = 1,
        /// <summary>
        /// Represents the right mouse button.
        /// </summary>
        rightButton = 2
    }

    /// <summary>
    /// Describes the layout of a DOM element in the page when the element's
    /// <see cref="P:Sys.UI.Control.Visible">Visible</see> property is set to false.
    /// </summary>
    public enum VisibilityMode
    {
        /// <summary>
        /// The element is not visible, but it occupies space on the page.
        /// </summary>
        hide = 0,
        /// <summary>
        /// The element is not visible, and the space it occupies is collapsed.
        /// </summary>
        collapse = 1
    }
}
