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

namespace PRI.ProductivityExtensions.InvalidateEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.InvalidateEventHandler">InvalidateEventHandler</seealso>
	/// </summary>
	public static partial class InvalidateEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// invalidateeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this InvalidateEventHandler invalidateeventhandler, Object sender, InvalidateEventArgs e, AsyncCallback callback)
		{
			if(invalidateeventhandler == null) throw new ArgumentNullException("invalidateeventhandler");

			return invalidateeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif