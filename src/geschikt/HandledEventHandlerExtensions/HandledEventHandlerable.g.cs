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
using System.ComponentModel;

namespace PRI.ProductivityExtensions.HandledEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.ComponentModel.HandledEventHandler">HandledEventHandler</seealso>
	/// </summary>
	public static partial class HandledEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// handledeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this HandledEventHandler handledeventhandler, Object sender, HandledEventArgs e, AsyncCallback callback)
		{
			if(handledeventhandler == null) throw new ArgumentNullException("handledeventhandler");

			return handledeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif