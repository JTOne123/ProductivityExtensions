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

namespace PRI.ProductivityExtensions.DrawToolTipEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DrawToolTipEventHandler">DrawToolTipEventHandler</seealso>
	/// </summary>
	public static partial class DrawToolTipEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// drawtooltipeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DrawToolTipEventHandler drawtooltipeventhandler, Object sender, DrawToolTipEventArgs e, AsyncCallback callback)
		{
			if(drawtooltipeventhandler == null) throw new ArgumentNullException("drawtooltipeventhandler");

			return drawtooltipeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif