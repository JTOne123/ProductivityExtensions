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
using System.Xml.Serialization;

namespace PRI.ProductivityExtensions.XmlElementEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.Serialization.XmlElementEventHandler">XmlElementEventHandler</seealso>
	/// </summary>
	public static partial class XmlElementEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// xmlelementeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this XmlElementEventHandler xmlelementeventhandler, Object sender, XmlElementEventArgs e, AsyncCallback callback)
		{
			if(xmlelementeventhandler == null) throw new ArgumentNullException("xmlelementeventhandler");

			return xmlelementeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif