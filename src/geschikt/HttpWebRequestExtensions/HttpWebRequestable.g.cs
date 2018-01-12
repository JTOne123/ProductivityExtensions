#if (NETSTANDARD2_0 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Net;

namespace PRI.ProductivityExtensions.HttpWebRequestExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Net.HttpWebRequest">HttpWebRequest</seealso>
	/// </summary>
	public static partial class HttpWebRequestable
	{
		/// <summary>
		/// Extends BeginGetRequestStream so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// httpwebrequest.BeginGetRequestStream(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginGetRequestStream(this HttpWebRequest httpwebrequest, AsyncCallback callback)
		{
			if(httpwebrequest == null) throw new ArgumentNullException("httpwebrequest");

			return httpwebrequest.BeginGetRequestStream(callback, null);
		}

		/// <summary>
		/// Extends BeginGetResponse so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// httpwebrequest.BeginGetResponse(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginGetResponse(this HttpWebRequest httpwebrequest, AsyncCallback callback)
		{
			if(httpwebrequest == null) throw new ArgumentNullException("httpwebrequest");

			return httpwebrequest.BeginGetResponse(callback, null);
		}

	}
}
#endif