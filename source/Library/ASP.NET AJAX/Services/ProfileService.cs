using Sys.Net;
using System;

namespace Sys.Services
{
    /// <summary>
    /// Provides the client proxy class for the profile service.
    /// </summary>
    public static class ProfileService
    {
        /// <summary>
        /// Gets or sets the name of the default failure callback function.
        /// </summary>
        public static WebServiceFailureCallback defaultFailedCallback{get;set;}

        /// <summary>
        /// Gets or sets the name of the default load-completed callback function.
        /// </summary>
        public static ProfileServiceCompletedCallback defaultLoadCompletedCallback{get;set;}

        /// <summary>
        /// Gets or sets the name of the default save-completed callback function.
        /// </summary>
        public static ProfileServiceCompletedCallback defaultSaveCompletedCallback{get;set;}

        /// <summary>
        /// Gets or sets the profile service path.
        /// </summary>
        public static string path{get;set;}

        /// <summary>
        /// Contains the loaded profile data.
        /// </summary>
        public extern static object properties{get;}

        /// <summary>
        /// Gets or sets the profile service time-out value in milliseconds.
        /// </summary>
        public static int timeout{get;set;}

        /// <summary>
        /// Loads all profile properties enabled for read access.
        /// </summary>
        public extern static void load();

        /// <summary>
        /// Loads the specified profile properties.
        /// </summary>
        /// <param name="propertyNames">A string array that contains the profile properties to load.</param>
        /// <param name="loadCompletedCallback">The function that is called when loading has completed. The default is null.</param>
        /// <param name="failedCallback">The function that is called when loading has failed. The default is null.</param>
        /// <param name="userContext">User context information passed to the callback functions.</param>
        public extern static void load(string[] propertyNames, ProfileServiceCompletedCallback loadCompletedCallback, WebServiceFailureCallback failedCallback, object userContext);

        /// <summary>
        /// Saves all profile properties.
        /// </summary>
        public extern static void save();

        /// <summary>
        /// Saves the specified profile properties.
        /// </summary>
        /// <param name="propertyNames">A string array that contains the profile properties to save.</param>
        /// <param name="saveCompletedCallback">The function that is called when the save method has finished. The default is null.</param>
        /// <param name="failedCallback">The function that is called if the save method has failed. The default is null.</param>
        /// <param name="userContext">User context information passed to the callback functions.</param>
        public extern static void save(string[] propertyNames, ProfileServiceCompletedCallback saveCompletedCallback, WebServiceFailureCallback failedCallback, object userContext);
    }
}
