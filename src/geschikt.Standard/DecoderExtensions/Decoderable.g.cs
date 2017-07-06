//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Text;

namespace PRI.ProductivityExtensions.DecoderExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Text.Decoder">Decoder</seealso>
	/// </summary>
	public static partial class Decoderable
	{
		/// <summary>
		/// Extends GetCharCount so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// decoder.GetCharCount(bytes);
		/// </example>
		/// </summary>
		public static Int32 GetCharCount(this Decoder decoder, Byte[] bytes)
		{
			if(decoder == null) throw new ArgumentNullException("decoder");

			if(bytes == null) throw new ArgumentNullException("bytes");

			return decoder.GetCharCount(bytes, 0, bytes.Length);
		}

		/// <summary>
		/// Extends GetCharCount so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// decoder.GetCharCount(bytes, flush);
		/// </example>
		/// </summary>
		public static Int32 GetCharCount(this Decoder decoder, Byte[] bytes, Boolean flush)
		{
			if(decoder == null) throw new ArgumentNullException("decoder");

			if(bytes == null) throw new ArgumentNullException("bytes");

			return decoder.GetCharCount(bytes, 0, bytes.Length, flush);
		}

		/// <summary>
		/// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// decoder.GetChars(bytes, chars, charIndex);
		/// </example>
		/// </summary>
		public static Int32 GetChars(this Decoder decoder, Byte[] bytes, Char[] chars, Int32 charIndex)
		{
			if(decoder == null) throw new ArgumentNullException("decoder");

			if(bytes == null) throw new ArgumentNullException("bytes");

			return decoder.GetChars(bytes, 0, bytes.Length, chars, charIndex);
		}

		/// <summary>
		/// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// decoder.GetChars(bytes, chars, charIndex, flush);
		/// </example>
		/// </summary>
		public static Int32 GetChars(this Decoder decoder, Byte[] bytes, Char[] chars, Int32 charIndex, Boolean flush)
		{
			if(decoder == null) throw new ArgumentNullException("decoder");

			if(bytes == null) throw new ArgumentNullException("bytes");

			return decoder.GetChars(bytes, 0, bytes.Length, chars, charIndex, flush);
		}

		/// <summary>
		/// Extends Convert so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// decoder.Convert(bytes, chars, charIndex, charCount, flush, bytesUsed, charsUsed, completed);
		/// </example>
		/// </summary>
		public static void Convert(this Decoder decoder, Byte[] bytes, Char[] chars, Int32 charIndex, Int32 charCount, Boolean flush, out Int32 bytesUsed, out Int32 charsUsed, out Boolean completed)
		{
			if(decoder == null) throw new ArgumentNullException("decoder");

			if(bytes == null) throw new ArgumentNullException("bytes");

			decoder.Convert(bytes, 0, bytes.Length, chars, charIndex, charCount, flush, out bytesUsed, out charsUsed, out completed);
		}

	}
}