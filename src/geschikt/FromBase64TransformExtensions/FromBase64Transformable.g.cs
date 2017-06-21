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
using System.Security.Cryptography;

namespace PRI.ProductivityExtensions.FromBase64TransformExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Security.Cryptography.FromBase64Transform">FromBase64Transform</seealso>
	/// </summary>
	public static partial class FromBase64Transformable
	{
		/// <summary>
		/// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// frombase64transform.TransformBlock(inputBuffer, outputBuffer, outputOffset);
		/// </example>
		/// </summary>
		public static Int32 TransformBlock(this FromBase64Transform frombase64transform, Byte[] inputBuffer, Byte[] outputBuffer, Int32 outputOffset)
		{
			if(frombase64transform == null) throw new ArgumentNullException("frombase64transform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return frombase64transform.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
		}

		/// <summary>
		/// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// frombase64transform.TransformFinalBlock(inputBuffer);
		/// </example>
		/// </summary>
		public static Byte[] TransformFinalBlock(this FromBase64Transform frombase64transform, Byte[] inputBuffer)
		{
			if(frombase64transform == null) throw new ArgumentNullException("frombase64transform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return frombase64transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
		}

	}
}
#endif