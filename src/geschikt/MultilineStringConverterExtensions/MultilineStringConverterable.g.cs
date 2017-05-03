//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;

namespace PRI.ProductivityExtensions.MultilineStringConverterExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.ComponentModel.MultilineStringConverter">MultilineStringConverter</seealso>
	/// </summary>
	public static partial class MultilineStringConverterable
	{
		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// multilinestringconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this MultilineStringConverter multilinestringconverter, ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(multilinestringconverter == null) throw new ArgumentNullException("multilinestringconverter");

			return (T)multilinestringconverter.ConvertTo(context, culture, value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this MultilineStringConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

	}
}
