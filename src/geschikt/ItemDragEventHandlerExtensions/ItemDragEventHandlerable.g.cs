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
using System.Windows.Forms;

namespace PRI.ProductivityExtensions.ItemDragEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.ItemDragEventHandler">ItemDragEventHandler</seealso>
	/// </summary>
	public static partial class ItemDragEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// itemdrageventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ItemDragEventHandler itemdrageventhandler, Object sender, ItemDragEventArgs e, AsyncCallback callback)
		{
			if(itemdrageventhandler == null) throw new ArgumentNullException("itemdrageventhandler");

			return itemdrageventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif