using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PRI.ProductivityExtensions.IEnumerableExtensions;

namespace PRI.ProductivityExtensions.ReflectionExtensions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Typeable'
	public static partial class Typeable
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Typeable'
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Typeable.IsStatic(Type)'
		public static bool IsStatic(this Type type)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Typeable.IsStatic(Type)'
		{
			if (type == null) throw new ArgumentNullException("type");
			return type.IsAbstract && type.IsSealed;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Typeable.IsOpenGenericType(Type)'
		public static bool IsOpenGenericType(this Type type)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Typeable.IsOpenGenericType(Type)'
		{
			return type.GetGenericTypeArguments().Length == 0 && type.IsGenericType;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Typeable.GetGenericTypeArguments(Type)'
		public static Type[] GetGenericTypeArguments(this Type type)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Typeable.GetGenericTypeArguments(Type)'
		{
#if NET_4_5
			return type.GenericTypeArguments;
#else
			if (type.IsGenericType && !type.IsGenericTypeDefinition)
				return type.GetGenericArguments();
			else
				return Type.EmptyTypes;
#endif
		}

#pragma warning disable CS1572 // XML comment has a param tag for 'TAttributes', but there is no parameter by that name
#pragma warning disable CS1571 // XML comment has a duplicate param tag for 'type'
		/// <summary>
		/// Tests if <param name="type"></param> has attribute <param name="TAttributes"></param>
		/// </summary>
		/// <typeparam name="TAttribute"></typeparam>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool HasAttribute<TAttribute>(this Type type) where TAttribute : Attribute
#pragma warning restore CS1571 // XML comment has a duplicate param tag for 'type'
#pragma warning restore CS1572 // XML comment has a param tag for 'TAttributes', but there is no parameter by that name
		{
			if (type == null) throw new ArgumentNullException("type");
			return type.HasAttribute(typeof (TAttribute));
		}

#pragma warning disable CS1571 // XML comment has a duplicate param tag for 'type'
		/// <summary>
		/// Tests if <param name="type"></param> has attribute <paramref name="attributeType"/>
		/// </summary>
		/// <param name="type"></param>
		/// <param name="attributeType"></param>
		/// <returns>true if attributed with <paramref name="attributeType"/>, false otherwise.</returns>
		public static bool HasAttribute(this Type type, Type attributeType)
#pragma warning restore CS1571 // XML comment has a duplicate param tag for 'type'
		{
			return type.GetCustomAttributes(attributeType, false).Length > 0;
		}

#pragma warning disable CS1570 // XML comment has badly formed XML -- 'End tag 'summary' does not match the start tag 'param'.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element 'summary'.'
		/// <summary>
		/// Test if <param name="type"> implements interface <typeparamref name="TInterface"/>
		/// </summary>
		/// <typeparam name="TInterface"></typeparam>
		/// <param name="type"></param>
		/// <returns></returns>
		public static bool ImplementsInterface<TInterface>(this Type type)
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element 'summary'.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'End tag 'summary' does not match the start tag 'param'.'
		{
			if (type == null) throw new ArgumentNullException("type");
			return typeof(TInterface).IsAssignableFrom(type);
		}

#pragma warning disable CS1570 // XML comment has badly formed XML -- 'End tag 'summary' does not match the start tag 'param'.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'End tag 'typeparam' does not match the start tag 'param'.'
#pragma warning disable CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element 'summary'.'
		/// <summary>
		/// tests if <param name="type"> implements interface <param name="interfaceType"></typeparam>
		/// </summary>
		/// <param name="type"></param>
		/// <param name="interfaceType"></param>
		/// <returns></returns>
		public static bool ImplementsInterface(this Type type, Type interfaceType)
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'Expected an end tag for element 'summary'.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'End tag 'typeparam' does not match the start tag 'param'.'
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'End tag 'summary' does not match the start tag 'param'.'
		{
			if (interfaceType == null) throw new ArgumentNullException("interfaceType");
			if (type == null) throw new ArgumentNullException("type");
			if (interfaceType.IsGenericType && interfaceType.ContainsGenericParameters)
			{
				return type.GetInterfaces().Any(t => t.IsGenericType && t.GetGenericTypeDefinition() == interfaceType);
			}
			return interfaceType.IsAssignableFrom(type);
		}

		private static IEnumerable<Type> ByPredicate(IEnumerable<Assembly> assemblies, Predicate<Type> predicate)
		{
			return from assembly in assemblies
				   from type in assembly.GetTypes()
				   where !type.IsAbstract && type.IsClass && predicate(type)
				   select type;
		}

#pragma warning disable CS1570 // XML comment has badly formed XML -- 'End tag 'typeparam' does not match the start tag 'param'.'
		/// <summary>
		/// Get a collection of types that implement interface <param name="interfaceType"></typeparam>
		/// </summary>
		/// <param name="interfaceType"></param>
		/// <returns></returns>
		public static IEnumerable<Type> ByImplementedInterface(this Type interfaceType)
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'End tag 'typeparam' does not match the start tag 'param'.'
		{
			if (!interfaceType.IsInterface) throw new ArgumentException("Type is not an interface", "interfaceType");
			var assemblies = AppDomain.CurrentDomain.GetAssemblies();
			return ByPredicate(assemblies, type => type.ImplementsInterface(interfaceType));
		}

#pragma warning disable CS1570 // XML comment has badly formed XML -- 'End tag 'typeparam' does not match the start tag 'param'.'
		/// <summary>
		/// Get a collection of types that implement interface <param name="interfaceType"></typeparam> within namespace named <paramref name="namespaceName"/>
		/// </summary>
		/// <param name="interfaceType"></param>
		/// <param name="namespaceName"></param>
		/// <returns></returns>
		public static IEnumerable<Type> ByImplementedInterface(this Type interfaceType, string namespaceName)
#pragma warning restore CS1570 // XML comment has badly formed XML -- 'End tag 'typeparam' does not match the start tag 'param'.'
		{
			if (string.IsNullOrWhiteSpace(namespaceName)) throw new ArgumentNullException("namespaceName");
			if (!interfaceType.IsInterface) throw new ArgumentException("Type is not an interface", "interfaceType");
			var assemblies = AppDomain.CurrentDomain.GetAssemblies();
			return ByPredicate(assemblies,
				type => (type.Namespace ?? string.Empty).StartsWith(namespaceName) && type.ImplementsInterface(interfaceType));
		}

		/// <summary>
		/// get a collection of types that implement <paramref name="interfaceType"/> for assemblies filenames matching <paramref name="wildcard"/> in directory <paramref name="directory"/>
		/// </summary>
		/// <param name="interfaceType"></param>
		/// <param name="directory"></param>
		/// <param name="wildcard"></param>
		/// <returns></returns>
		public static IEnumerable<Type> ByImplementedInterfaceInDirectory(this Type interfaceType, string directory, string wildcard)
		{
			if (!interfaceType.IsInterface) throw new ArgumentException("Type is not an interface", "TInterface");
			return ByPredicate(System.IO.Directory.GetFiles(directory, wildcard).ToAssemblies(), type => ImplementsInterface(type, interfaceType));
		}

		/// <summary>
		/// get a collection of types that implement <paramref name="interfaceType"/> for assemblies filenames matching <paramref name="wildcard"/> in directory <paramref name="directory"/> within namespace named <paramref name="namespaceName"/>
		/// </summary>
		/// <param name="interfaceType"></param>
		/// <param name="directory"></param>
		/// <param name="wildcard"></param>
		/// <param name="namespaceName"></param>
		/// <returns></returns>
		public static IEnumerable<Type> ByImplementedInterfaceInDirectory(this Type interfaceType, string directory, string wildcard, string namespaceName)
		{
			if (!interfaceType.IsInterface) throw new ArgumentException("Type is not an interface", "TInterface");
			return ByPredicate(System.IO.Directory.GetFiles(directory, wildcard).ToAssemblies(),
				type => (type.Namespace ?? string.Empty).StartsWith(namespaceName) && ImplementsInterface(type, interfaceType));
		}

		/// <summary>
		/// Gets the default constructor for <paramref name="type"/>
		/// </summary>
		/// <param name="type">The type to get the default destructor</param>
		/// <returns><seealso cref="ConstructorInfo"/> about the default constructor.</returns>
		public static ConstructorInfo GetConstructor(this Type type)
		{
			return type.GetConstructor(new Type[0]);
		}
	}
}