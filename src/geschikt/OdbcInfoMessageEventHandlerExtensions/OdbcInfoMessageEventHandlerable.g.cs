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
using System.Data.Odbc;

namespace PRI.ProductivityExtensions.OdbcInfoMessageEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Data.Odbc.OdbcInfoMessageEventHandler">OdbcInfoMessageEventHandler</seealso>
	/// </summary>
	public static partial class OdbcInfoMessageEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// odbcinfomessageeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this OdbcInfoMessageEventHandler odbcinfomessageeventhandler, Object sender, OdbcInfoMessageEventArgs e, AsyncCallback callback)
		{
			if(odbcinfomessageeventhandler == null) throw new ArgumentNullException("odbcinfomessageeventhandler");

			return odbcinfomessageeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif