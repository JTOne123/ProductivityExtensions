#if (NETSTANDARD2_0 || NETSTANDARD1_6 || NETSTANDARD1_5 || NETSTANDARD1_4 || NETSTANDARD1_3 || NETSTANDARD1_2 || NETSTANDARD1_1 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.IO.Compression;

namespace PRI.ProductivityExtensions.GZipStreamExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.IO.Compression.GZipStream">GZipStream</seealso>
	/// </summary>
	public static partial class GZipStreamable
	{
#if (NETSTANDARD2_0 || NET45 || NET40 || NET451 || NET452 || NET46 || NET461 || NET462)
		/// <summary>
		/// Extends BeginRead so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// gzipstream.BeginRead(array, offset, count, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginRead(this GZipStream gzipstream, Byte[] array, Int32 offset, Int32 count, AsyncCallback asyncCallback)
		{
			if(gzipstream == null) throw new ArgumentNullException("gzipstream");

			return gzipstream.BeginRead(array, offset, count, asyncCallback, null);
		}

		/// <summary>
		/// Extends BeginRead so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// gzipstream.BeginRead(array, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginRead(this GZipStream gzipstream, Byte[] array, AsyncCallback asyncCallback)
		{
			if(gzipstream == null) throw new ArgumentNullException("gzipstream");

			if(array == null) throw new ArgumentNullException("array");

			return gzipstream.BeginRead(array, 0, array.Length, asyncCallback);
		}

		/// <summary>
		/// Extends BeginWrite so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// gzipstream.BeginWrite(array, offset, count, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginWrite(this GZipStream gzipstream, Byte[] array, Int32 offset, Int32 count, AsyncCallback asyncCallback)
		{
			if(gzipstream == null) throw new ArgumentNullException("gzipstream");

			return gzipstream.BeginWrite(array, offset, count, asyncCallback, null);
		}

		/// <summary>
		/// Extends BeginWrite so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// gzipstream.BeginWrite(array, asyncCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginWrite(this GZipStream gzipstream, Byte[] array, AsyncCallback asyncCallback)
		{
			if(gzipstream == null) throw new ArgumentNullException("gzipstream");

			if(array == null) throw new ArgumentNullException("array");

			return gzipstream.BeginWrite(array, 0, array.Length, asyncCallback);
		}
#endif
	}
}
#endif