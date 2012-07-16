using System;
namespace Sys.Net
{
    /// <summary>
    /// Delegate for responding to the <see cref="E:Sys.Net.WebRequestManager.InvokingRequest" /> event.
    /// </summary>
    /// <param name="sender">The <see cref="T:Sys.Net.WebRequestManager" /> instance that raised the event.</param>
    /// <param name="e">The <see cref="T:Sys.Net.NetworkRequestEventArgs" /> object that contains the event data.</param>
    public delegate void NetworkRequestEventHandler(object sender, NetworkRequestEventArgs e);

    /// <summary>
    /// Delegate for handling the completed event raised by the WebRequest class.
    /// </summary>
    /// <param name="executor">The executor instance associated with the completed request.</param>
    public delegate void WebRequestCompletedCallback(WebRequestExecutor executor);

    /// <summary>
    /// Delegate for handling the <see cref="M:Sys.Net.WebServiceProxy.Invoke(System.String,System.String,System.Boolean,System.Dictionary,Sys.Net.WebServiceSuccessCallback,Sys.Net.WebServiceFailureCallback,System.Object,System.Int32)">
    /// WebServiceProxy.Invoke</see> failure callback.
    /// </summary>
    /// <param name="error">A <see cref="T:Sys.Net.WebServiceError" /> object that contains details of the error.</param>
    /// <param name="userContext">Any user-specific information. userContext can be any JavaScript primitive type, array, or object.</param>
    /// <param name="methodName">The name of the Web service method that was invoked.</param>
    public delegate void WebServiceFailureCallback(WebServiceError error, object userContext, string methodName);

    /// <summary>
    /// Delegate for handling the <see cref="M:Sys.Net.WebServiceProxy.Invoke(System.String,System.String,System.Boolean,System.Dictionary,Sys.Net.WebServiceSuccessCallback,Sys.Net.WebServiceFailureCallback,System.Object,System.Int32)">
    /// WebServiceProxy.Invoke</see> success callback.
    /// </summary>
    /// <param name="result">The result of the Web service call: either JSON, XML, or text.</param>
    /// <param name="userContext">Any user-specific information. userContext can be any JavaScript primitive type, array, or object.</param>
    /// <param name="methodName">The name of the Web service method that was invoked.</param>
    public delegate void WebServiceSuccessCallback(object result, object userContext, string methodName);
}
