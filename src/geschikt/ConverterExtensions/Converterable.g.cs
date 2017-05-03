//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace PRI.ProductivityExtensions.ConverterExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Converter&lt;TInput,TOutput&gt;">Converter&lt;TInput,TOutput&gt;</seealso>
	/// </summary>
	public static partial class Converterable
	{
		/// <summary>
		/// Extends BeginInvoke&lt;TInput, TOutput&gt; so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// converter.BeginInvoke&lt;TInput, TOutput&gt;(input, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke<TInput, TOutput>(this Converter<TInput,TOutput> converter, TInput input, AsyncCallback callback)
		{
			if(converter == null) throw new ArgumentNullException("converter");

			return converter.BeginInvoke(input, callback, null);
		}

	}
}
