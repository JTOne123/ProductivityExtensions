//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace PRI.ProductivityExtensions.AsyncCallbackExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.AsyncCallback">AsyncCallback</seealso>
	/// </summary>
	public static partial class AsyncCallbackable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// asynccallback.BeginInvoke(ar, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this AsyncCallback asynccallback, IAsyncResult ar, AsyncCallback callback)
		{
			if(asynccallback == null) throw new ArgumentNullException("asynccallback");

			return asynccallback.BeginInvoke(ar, callback, null);
		}

	}
}
