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

namespace PRI.ProductivityExtensions.DrawTreeNodeEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DrawTreeNodeEventHandler">DrawTreeNodeEventHandler</seealso>
	/// </summary>
	public static partial class DrawTreeNodeEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// drawtreenodeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DrawTreeNodeEventHandler drawtreenodeeventhandler, Object sender, DrawTreeNodeEventArgs e, AsyncCallback callback)
		{
			if(drawtreenodeeventhandler == null) throw new ArgumentNullException("drawtreenodeeventhandler");

			return drawtreenodeeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif