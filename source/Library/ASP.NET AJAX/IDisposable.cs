using System;
namespace Sys
{
    /// <summary>
    /// Provides a common interface for application-defined tasks associated with closing,
    /// releasing, or resetting resources held by instances of a registered Microsoft AJAX
    /// Library class.
    /// </summary>
    public interface IDisposable
    {
        /// <summary>
        /// Releases resources held by an object, or prepares an object for reuse.
        /// </summary>
        void dispose();
    }
}
