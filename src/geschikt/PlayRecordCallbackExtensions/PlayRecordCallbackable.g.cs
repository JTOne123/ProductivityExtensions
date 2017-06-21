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
using System.Drawing.Imaging;

namespace PRI.ProductivityExtensions.PlayRecordCallbackExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Drawing.Imaging.PlayRecordCallback">PlayRecordCallback</seealso>
	/// </summary>
	public static partial class PlayRecordCallbackable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// playrecordcallback.BeginInvoke(recordType, flags, dataSize, recordData, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PlayRecordCallback playrecordcallback, EmfPlusRecordType recordType, Int32 flags, Int32 dataSize, IntPtr recordData, AsyncCallback callback)
		{
			if(playrecordcallback == null) throw new ArgumentNullException("playrecordcallback");

			return playrecordcallback.BeginInvoke(recordType, flags, dataSize, recordData, callback, null);
		}

	}
}
#endif