using System;

namespace Sys.Services
{
    /// <summary>
    /// Delegate for responding to the <see cref="M:Sys.Services.AuthenticationService.Login(System.String,System.String,System.Boolean,System.String,System.String,Sys.Services.AuthenticationServiceLoginCallback,Sys.Net.WebServiceFailureCallback,System.Object)">AuthenticationService.Login</see> events.
    /// </summary>
    /// <param name="validCredentials">Returns true if the user was authenticated.</param>
    /// <param name="userContext">Any user-specific information. userContext can be any JavaScript primitive type, array, or object.</param>
    /// <param name="methodName">The name of the Web service method that was invoked.</param>
    public delegate void AuthenticationServiceLoginCallback(bool validCredentials, object userContext, string methodName);

    /// <summary>
    /// Delegate for responding to the <see cref="M:Sys.Services.ProfileService.Load(System.String[],Sys.Services.ProfileServiceCompletedCallback,Sys.Net.WebServiceFailureCallback,System.Object)" /> and <see cref="M:Sys.Services.ProfileService.Save(System.String[],Sys.Services.ProfileServiceCompletedCallback,Sys.Net.WebServiceFailureCallback,System.Object)">
    /// ProfileService.Save</see> success events.
    /// </summary>
    /// <param name="propertyCount">Indicates the number of properties returned by the profile service.</param>
    /// <param name="userContext">Any user-specific information. userContext can be any JavaScript primitive type, array, or object.</param>
    /// <param name="methodName">The name of the Web service method that was invoked.</param>
    public delegate void ProfileServiceCompletedCallback(int propertyCount, object userContext, string methodName);
}
