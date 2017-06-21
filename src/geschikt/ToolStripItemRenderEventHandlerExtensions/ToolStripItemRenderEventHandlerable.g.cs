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

namespace PRI.ProductivityExtensions.ToolStripItemRenderEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.ToolStripItemRenderEventHandler">ToolStripItemRenderEventHandler</seealso>
	/// </summary>
	public static partial class ToolStripItemRenderEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// toolstripitemrendereventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripItemRenderEventHandler toolstripitemrendereventhandler, Object sender, ToolStripItemRenderEventArgs e, AsyncCallback callback)
		{
			if(toolstripitemrendereventhandler == null) throw new ArgumentNullException("toolstripitemrendereventhandler");

			return toolstripitemrendereventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif