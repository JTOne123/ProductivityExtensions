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

namespace PRI.ProductivityExtensions.StateChangeEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Data.StateChangeEventHandler">StateChangeEventHandler</seealso>
	/// </summary>
	public static partial class StateChangeEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// statechangeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this StateChangeEventHandler statechangeeventhandler, Object sender, StateChangeEventArgs e, AsyncCallback callback)
		{
			if(statechangeeventhandler == null) throw new ArgumentNullException("statechangeeventhandler");

			return statechangeeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif