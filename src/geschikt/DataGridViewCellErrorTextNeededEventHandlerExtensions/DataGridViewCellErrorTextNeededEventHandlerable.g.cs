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

namespace PRI.ProductivityExtensions.DataGridViewCellErrorTextNeededEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DataGridViewCellErrorTextNeededEventHandler">DataGridViewCellErrorTextNeededEventHandler</seealso>
	/// </summary>
	public static partial class DataGridViewCellErrorTextNeededEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datagridviewcellerrortextneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewCellErrorTextNeededEventHandler datagridviewcellerrortextneededeventhandler, Object sender, DataGridViewCellErrorTextNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcellerrortextneededeventhandler == null) throw new ArgumentNullException("datagridviewcellerrortextneededeventhandler");

			return datagridviewcellerrortextneededeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif