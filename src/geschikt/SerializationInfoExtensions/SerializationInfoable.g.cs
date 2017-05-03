//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace PRI.ProductivityExtensions.SerializationInfoExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Runtime.Serialization.SerializationInfo">SerializationInfo</seealso>
	/// </summary>
	public static partial class SerializationInfoable
	{
		/// <summary>
		/// Extends GetValue so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// serializationinfo.GetValue&lt;int&gt;(name);
		/// </example>
		/// </summary>
		public static T GetValue<T>(this SerializationInfo serializationinfo, String name)
		{
			if(serializationinfo == null) throw new ArgumentNullException("serializationinfo");

			return (T)serializationinfo.GetValue(name, typeof(T));
		}

	}
}
