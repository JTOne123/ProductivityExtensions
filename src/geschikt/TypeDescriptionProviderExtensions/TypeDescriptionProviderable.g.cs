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
using System.ComponentModel;

namespace PRI.ProductivityExtensions.TypeDescriptionProviderExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.ComponentModel.TypeDescriptionProvider">TypeDescriptionProvider</seealso>
	/// </summary>
	public static partial class TypeDescriptionProviderable
	{
		/// <summary>
		/// Extends CreateInstance so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typedescriptionprovider.CreateInstance&lt;int&gt;(provider, argTypes, args);
		/// </example>
		/// </summary>
		public static T CreateInstance<T>(this TypeDescriptionProvider typedescriptionprovider, IServiceProvider provider, Type[] argTypes, Object[] args)
		{
			if(typedescriptionprovider == null) throw new ArgumentNullException("typedescriptionprovider");

			return (T)typedescriptionprovider.CreateInstance(provider, typeof(T), argTypes, args);
		}

	}
}
#endif