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

namespace PRI.ProductivityExtensions.DataTableNewRowEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Data.DataTableNewRowEventHandler">DataTableNewRowEventHandler</seealso>
	/// </summary>
	public static partial class DataTableNewRowEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datatablenewroweventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataTableNewRowEventHandler datatablenewroweventhandler, Object sender, DataTableNewRowEventArgs e, AsyncCallback callback)
		{
			if(datatablenewroweventhandler == null) throw new ArgumentNullException("datatablenewroweventhandler");

			return datatablenewroweventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif