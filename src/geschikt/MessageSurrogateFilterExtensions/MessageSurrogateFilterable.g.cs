#if (NET4O || NET45 || NET451 || NET452 || NET46 || NET461 || NET462)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.Remoting.Messaging;

namespace PRI.ProductivityExtensions.MessageSurrogateFilterExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Runtime.Remoting.Messaging.MessageSurrogateFilter">MessageSurrogateFilter</seealso>
	/// </summary>
	public static partial class MessageSurrogateFilterable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// messagesurrogatefilter.BeginInvoke(key, value, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this MessageSurrogateFilter messagesurrogatefilter, String key, Object value, AsyncCallback callback)
		{
			if(messagesurrogatefilter == null) throw new ArgumentNullException("messagesurrogatefilter");

			return messagesurrogatefilter.BeginInvoke(key, value, callback, null);
		}

	}
}
#endif