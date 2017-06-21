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

namespace PRI.ProductivityExtensions.CursorConverterExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.CursorConverter">CursorConverter</seealso>
	/// </summary>
	public static partial class CursorConverterable
	{
		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this CursorConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// cursorconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this CursorConverter cursorconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(cursorconverter == null) throw new ArgumentNullException("cursorconverter");

			return (T)cursorconverter.ConvertTo(context, culture, value, typeof(T));
		}

	}
}
#endif