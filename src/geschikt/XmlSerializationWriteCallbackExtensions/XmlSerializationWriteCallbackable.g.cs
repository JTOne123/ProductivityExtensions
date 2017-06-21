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

namespace PRI.ProductivityExtensions.XmlSerializationWriteCallbackExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.Serialization.XmlSerializationWriteCallback">XmlSerializationWriteCallback</seealso>
	/// </summary>
	public static partial class XmlSerializationWriteCallbackable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// xmlserializationwritecallback.BeginInvoke(o, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this XmlSerializationWriteCallback xmlserializationwritecallback, Object o, AsyncCallback callback)
		{
			if(xmlserializationwritecallback == null) throw new ArgumentNullException("xmlserializationwritecallback");

			return xmlserializationwritecallback.BeginInvoke(o, callback, null);
		}

	}
}
#endif