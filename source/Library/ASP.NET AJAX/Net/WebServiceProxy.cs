using System;

namespace Sys.Net
{
	/// <summary>
	/// Enables calling a method of a specified Web service asynchronously.
	/// </summary>
	public abstract class WebServiceProxy
	{
		/// <summary>
		/// Gets or sets the default failed callback function for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
		/// </summary>
		public WebServiceFailureCallback defaultFailedCallback {get;set;}

        /// <summary>
		/// Gets or sets the default succeeded callback function for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
		/// </summary>
		public WebServiceSuccessCallback defaultSucceededCallback{get;set;}

        /// <summary>
		/// Gets or sets the default user context for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
		/// </summary>
		public object defaultUserContext{get;set;}

        /// <summary>
		/// Gets or sets the path to the Web service for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
		/// </summary>
		public string path{get;set;}

        /// <summary>
		/// Gets or sets the time-out value in milliseconds for the <see cref="T:Sys.Net.WebServiceProxy" /> instance.
		/// </summary>
		public int timeout{get;set;}

        /// <summary>
		/// Invokes the specified Web service method.
		/// </summary>
		/// <param name="servicePath">The Web service URL.</param>
		/// <param name="methodName">The name of the Web service method to invoke.</param>
		/// <param name="useGet">false if the Web request HTTP verb is POST; otherwise, true. The default is false.</param>
		/// <param name="parameters">A dictionary that contains name/value pairs that correspond to the parameters of the method to call.</param>
		/// <returns>The <see cref="T:Sys.Net.WebRequest" /> that was created to invoke the method.</returns>
		public extern static WebRequest invoke(string servicePath, string methodName, bool useGet, object parameters);

        /// <summary>
		/// Invokes the specified Web service method.
		/// </summary>
		/// <param name="servicePath">The Web service URL.</param>
		/// <param name="methodName">The name of the Web service method to invoke.</param>
		/// <param name="useGet">false if the Web request HTTP verb is POST; otherwise, true. The default is false.</param>
		/// <param name="parameters">A dictionary that contains name/value pairs that correspond to the parameters of the method to call.</param>
		/// <param name="successCallback">The function invoked as a callback if the Web service method call returns successfully. If no callback function is provided, no action is taken when the Web service method finishes successfully.</param>
		/// <param name="failedCallback">The function invoked as a callback if the Web service method call fails. If no callback function is provided, no action is taken if an error occurs during the Web service method call.</param>
		/// <param name="userContext">Any user-specific information to be passed to either callback.</param>
		/// <returns>The <see cref="T:Sys.Net.WebRequest" /> that was created to invoke the method.</returns>
		public extern static WebRequest invoke(string servicePath, string methodName, bool useGet, object parameters, WebServiceSuccessCallback successCallback, WebServiceFailureCallback failedCallback, object userContext);

        /// <summary>
		/// Invokes the specified Web service method.
		/// </summary>
		/// <param name="servicePath">The Web service URL.</param>
		/// <param name="methodName">The name of the Web service method to invoke.</param>
		/// <param name="useGet">false if the Web request HTTP verb is POST; otherwise, true. The default is false.</param>
		/// <param name="parameters">A dictionary that contains name/value pairs that correspond to the parameters of the method to call.</param>
		/// <param name="successCallback">The function invoked as a callback if the Web service method call returns successfully. If no callback function is provided, no action is taken when the Web service method finishes successfully.</param>
		/// <param name="failedCallback">The function invoked as a callback if the Web service method call fails. If no callback function is provided, no action is taken if an error occurs during the Web service method call.</param>
		/// <param name="userContext">Any user-specific information to be passed to either callback.</param>
		/// <param name="timeout">The time in milliseconds after which the request is timed out and aborted.</param>
		/// <returns>The <see cref="T:Sys.Net.WebRequest" /> that was created to invoke the method.</returns>
        public extern static WebRequest invoke(string servicePath, string methodName, bool useGet, object parameters, WebServiceSuccessCallback successCallback, WebServiceFailureCallback failedCallback, object userContext, int timeout);
	}
}
