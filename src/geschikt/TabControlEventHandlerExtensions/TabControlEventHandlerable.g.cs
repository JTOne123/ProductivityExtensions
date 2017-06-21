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

namespace PRI.ProductivityExtensions.TabControlEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.TabControlEventHandler">TabControlEventHandler</seealso>
	/// </summary>
	public static partial class TabControlEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// tabcontroleventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TabControlEventHandler tabcontroleventhandler, Object sender, TabControlEventArgs e, AsyncCallback callback)
		{
			if(tabcontroleventhandler == null) throw new ArgumentNullException("tabcontroleventhandler");

			return tabcontroleventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif