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

namespace PRI.ProductivityExtensions.DataGridViewColumnStateChangedEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DataGridViewColumnStateChangedEventHandler">DataGridViewColumnStateChangedEventHandler</seealso>
	/// </summary>
	public static partial class DataGridViewColumnStateChangedEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datagridviewcolumnstatechangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewColumnStateChangedEventHandler datagridviewcolumnstatechangedeventhandler, Object sender, DataGridViewColumnStateChangedEventArgs e, AsyncCallback callback)
		{
			if(datagridviewcolumnstatechangedeventhandler == null) throw new ArgumentNullException("datagridviewcolumnstatechangedeventhandler");

			return datagridviewcolumnstatechangedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif