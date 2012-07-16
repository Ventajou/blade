using Sys.Net;
using System;

namespace Sys.Services
{
    /// <summary>
    /// Provides the client proxy class for the authentication service.
    /// </summary>
    public static class AuthenticationService
    {
        /// <summary>
        /// Gets or sets the name of the default failure callback function.
        /// </summary>
        public static WebServiceFailureCallback defaultFailedCallback{get;set;}

        /// <summary>
        /// Gets or sets the name of the default login-completed callback function.
        /// </summary>
        public static AuthenticationServiceLoginCallback defaultLoginCompletedCallback{get;set;}

        /// <summary>
        /// Gets or sets the name of the default logout-completed callback function.
        /// </summary>
        public static WebServiceSuccessCallback defaultLogoutCompletedCallback{get;set;}

        /// <summary>
        /// Gets the authentication state of the current user.
        /// </summary>
        public extern static bool isLoggedIn{get;}

        /// <summary>
        /// Gets or sets the authentication service path.
        /// </summary>
        public static string path{get;set;}

        /// <summary>
        /// Gets or sets the authentication service time-out value in milliseconds.
        /// </summary>
        public static int timeout{get;set;}

        /// <summary>
        /// Authenticates the user's credentials.
        /// </summary>
        /// <param name="username">The user name to authenticate.</param>
        /// <param name="password">The user's password. The default is null.</param>
        public extern static void login(string username, string password);

        /// <summary>
        /// Authenticates the user's credentials.
        /// </summary>
        /// <param name="username">The user name to authenticate.</param>
        /// <param name="password">The user's password. The default is null.</param>
        /// <param name="isPersistent">true if the issued authentication ticket should be persistent across browser sessions; otherwise, false. The default is false.</param>
        /// <param name="customInfo">Reserved for future use. The default is null.</param>
        /// <param name="redirectUrl">The URL to redirect the browser to on successful authentication. If null, no redirect occurs. The default is null.</param>
        /// <param name="loginCompletedCallback">The function to call when the login has finished successfully. The default is null.</param>
        /// <param name="failedCallback">The function to call if the login fails. The default is null.</param>
        /// <param name="userContext">User context information that you are passing to the callback functions.</param>
        public extern static void login(string username, string password, bool isPersistent, string customInfo, string redirectUrl, AuthenticationServiceLoginCallback loginCompletedCallback, WebServiceFailureCallback failedCallback, object userContext);

        /// <summary>
        /// Logs out the currently authenticated user.
        /// </summary>
        public extern static void logout();

        /// <summary>
        /// Logs out the currently authenticated user.
        /// </summary>
        /// <param name="redirectUrl">The URL to redirect the browser to on successful logout. The default is null.</param>
        /// <param name="logoutCompletedCallback">The function that is called when the logout has finished. The default is null.</param>
        /// <param name="failedCallback">The function that is called if the logout has failed. The default is null.</param>
        /// <param name="userContext">User context information that you are passing to the callback functions.</param>
        public extern static void logout(string redirectUrl, WebServiceSuccessCallback logoutCompletedCallback, WebServiceFailureCallback failedCallback, object userContext);
    }
}
