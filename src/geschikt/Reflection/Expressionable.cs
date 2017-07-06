#if (NETSTANDARD2_0 || NETSTANDARD1_6 || NETSTANDARD1_5 || NETSTANDARD1_4 || NETSTANDARD1_3 || NETSTANDARD1_2 || NETSTANDARD1_1 || NETSTANDARD1_0 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
using System;
#if (NETSTANDARD2_0 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
using System.ComponentModel;
#endif
using System.Linq.Expressions;
using System.Reflection;

namespace PRI.ProductivityExtensions.Reflection
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Expressionable'
	public static class Expressionable
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Expressionable'
	{
#if NETSTANDARD1_0
		/// <summary>
		/// Converts the body of the lambda expression into the <see cref="T:System.Reflection.PropertyInfo" /> referenced by it.
		/// </summary>
		public static PropertyInfo ToPropertyInfo(this LambdaExpression expression)
		{
			var memberExpression = expression.Body as MemberExpression;
			var propertyInfo = memberExpression?.Member as PropertyInfo;

			if (propertyInfo == null) throw new ArgumentException(expression.ToString());

			return propertyInfo;
		}
#endif

#if (NETSTANDARD2_0 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
		/// <summary>
		/// Converts the body of the lambda expression into the <see cref="T:System.Reflection.PropertyInfo" /> referenced by it.
		/// </summary>
		public static PropertyDescriptor ToPropertyDescriptor(this LambdaExpression expression)
		{
			var memberExpression = expression.Body as MemberExpression;
			var propertyInfo = memberExpression?.Member as PropertyInfo;

			if (propertyInfo == null)
			{
				throw new ArgumentException(expression.ToString());
			}

			var type = propertyInfo.DeclaringType;
			return TypeDescriptor.GetProperties(type)[propertyInfo.Name];
		}
#endif
	}
}
#endif