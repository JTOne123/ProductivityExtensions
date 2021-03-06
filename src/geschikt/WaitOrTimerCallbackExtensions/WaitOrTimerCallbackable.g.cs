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
using System.Threading;

namespace PRI.ProductivityExtensions.WaitOrTimerCallbackExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Threading.WaitOrTimerCallback">WaitOrTimerCallback</seealso>
	/// </summary>
	public static partial class WaitOrTimerCallbackable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// waitortimercallback.BeginInvoke(state, timedOut, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this WaitOrTimerCallback waitortimercallback, Object state, Boolean timedOut, AsyncCallback callback)
		{
			if(waitortimercallback == null) throw new ArgumentNullException("waitortimercallback");

			return waitortimercallback.BeginInvoke(state, timedOut, callback, null);
		}

	}
}
#endif