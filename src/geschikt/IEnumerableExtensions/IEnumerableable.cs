﻿#if (NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETSTANDARD2_0 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
#if (NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETSTANDARD2_0 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
using System.Reflection;
#endif
#if NETSTANDARD1_0
using PRI.ProductivityExtensions.ICollectionableExtensions;
#endif

namespace PRI.ProductivityExtensions.IEnumerableExtensions
{
	/// <summary>
	/// class that contains extension methods that extend <seealso cref="IEnumerable{T}"/>
	/// </summary>
	public static partial class IEnumerableable
	{
#if NETSTANDARD1_0
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'IEnumerableable.ToCollection<T>(IEnumerable<T>)'
		public static Collection<T> ToCollection<T>(this IEnumerable<T> enumerable)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'IEnumerableable.ToCollection<T>(IEnumerable<T>)'
		{
			if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));

			var list = enumerable as IList<T>;
			if (list != null)
			{
				return new Collection<T>(list);
			}
			var collection = new Collection<T>();
			collection.AddRange(enumerable);

			return collection;
		}
#endif

#if (NETSTANDARD2_0 || NETSTANDARD1_6 || NETSTANDARD1_5 || NETSTANDARD1_4 || NETSTANDARD1_3 || NETCOREAPP1_0 || NETCOREAPP1_1 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'IEnumerableable.ToAssemblies(IEnumerable<string>)'
		public static IEnumerable<Assembly> ToAssemblies(this IEnumerable<string> filenames)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'IEnumerableable.ToAssemblies(IEnumerable<string>)'
		{
			foreach (var f in filenames)
			{
				Assembly loadFrom;
#if (NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETCOREAPP1_0 || NETCOREAPP1_1)
				var dir = Directory.GetCurrentDirectory();
#endif
				try
				{
#if (NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETCOREAPP1_0 || NETCOREAPP1_1)
					Directory.SetCurrentDirectory(Path.GetDirectoryName(f));
					loadFrom = Assembly.Load(new AssemblyName(Path.GetFileNameWithoutExtension(f)));
#elif (!NETSTANDARD1_0 && ! NETSTANDARD1_1 && !NETSTANDARD1_2)
					loadFrom = Assembly.LoadFrom(f);
#endif
				}
				catch (BadImageFormatException)
				{
					// ignore anything that can't be loaded
					continue;
				}
				catch (ReflectionTypeLoadException)
				{
					// ignore anything that can't be loaded
					continue;
				}
#if (NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6 || NETCOREAPP1_0 || NETCOREAPP1_1)
				finally
				{
					Directory.SetCurrentDirectory(dir);
				}
#endif
				yield return loadFrom;
			}
		}
#endif

					//#if NETSTANDARD1_0
					//#if (NETSTANDARD1_0 || NETSTANDARD1_1 || NETSTANDARD1_2 || NETSTANDARD1_3 || NETSTANDARD1_4 || NETSTANDARD1_5 || NETSTANDARD1_6)
					/// <summary>
					/// Create a single multicast delegate from a collection of delegates
					/// </summary>
					/// <typeparam name="T">Type of parameter to delegate</typeparam>
					/// <param name="coll"></param>
					/// <returns>The collection of delegates</returns>
					public static Action<T> Sum<T>(this IEnumerable<Action<T>> coll)
		{
			if (coll == null || !coll.Any())
			{
				return _ => { };
			}
			Action<T> result = coll.ElementAt(0);
			foreach (var d in coll.Skip(1))
				result += d;
			return result;
		}

		/// <summary>
		/// Create a single multicast delegate from a collection of delegates
		/// </summary>
		/// <typeparam name="T1">Type of parameter to delegate</typeparam>
		/// <typeparam name="T2">Type of return of the delegate</typeparam>
		/// <param name="coll">The collection of delegates</param>
		/// <returns></returns>
		public static Func<T1, T2> Sum<T1, T2>(this IEnumerable<Func<T1, T2>> coll)
		{
			if (coll == null || !coll.Any())
			{
				throw new ArgumentException("Collection should not be empty or null.", nameof(coll));
			}
			Func<T1, T2> result = coll.ElementAt(0);
			foreach (var d in coll.Skip(1))
				result += d;
			return result;
		}
//#endif
//#endif
	}
}
#endif