#if (NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETSTANDARD2_0 || NET45 || NET451 || NET452 || NET46 || NET461 || NET462)
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRI.ProductivityExtensions.ActionExtensions
{
	/// <summary>
	/// Extensions methods on <seealso cref="Action{T}"/>
	/// </summary>
	public static partial class Actionable
	{
		/// <summary>
		/// Create a single multitask delegate from several actions.
		/// </summary>
		/// <typeparam name="T">The type of the parameter of the action that this action encapsulates. This type parameter is contravariant. That is, you can use either the type you specified or any type that is less derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.</typeparam>
		/// <param name="coll">The collection of <seealso cref="Action{T}"/> to create a multicast delegate from.</param>
		/// <returns></returns>
		public static Action<T> Sum<T>(this IEnumerable<Action<T>> coll)
		{
			Action<T> result = coll.ElementAt(0);
			foreach (var d in coll.Skip(1))
			{
				result += d;
			}

			return result;
		}
	}
}
#endif