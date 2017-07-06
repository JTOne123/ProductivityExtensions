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
using System.Data;

namespace PRI.ProductivityExtensions.FillErrorEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Data.FillErrorEventHandler">FillErrorEventHandler</seealso>
	/// </summary>
	public static partial class FillErrorEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// fillerroreventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this FillErrorEventHandler fillerroreventhandler, Object sender, FillErrorEventArgs e, AsyncCallback callback)
		{
			if(fillerroreventhandler == null) throw new ArgumentNullException("fillerroreventhandler");

			return fillerroreventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif