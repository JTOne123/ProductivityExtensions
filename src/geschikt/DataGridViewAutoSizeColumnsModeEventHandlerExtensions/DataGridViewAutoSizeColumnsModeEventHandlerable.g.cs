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

namespace PRI.ProductivityExtensions.DataGridViewAutoSizeColumnsModeEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DataGridViewAutoSizeColumnsModeEventHandler">DataGridViewAutoSizeColumnsModeEventHandler</seealso>
	/// </summary>
	public static partial class DataGridViewAutoSizeColumnsModeEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datagridviewautosizecolumnsmodeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewAutoSizeColumnsModeEventHandler datagridviewautosizecolumnsmodeeventhandler, Object sender, DataGridViewAutoSizeColumnsModeEventArgs e, AsyncCallback callback)
		{
			if(datagridviewautosizecolumnsmodeeventhandler == null) throw new ArgumentNullException("datagridviewautosizecolumnsmodeeventhandler");

			return datagridviewautosizecolumnsmodeeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif