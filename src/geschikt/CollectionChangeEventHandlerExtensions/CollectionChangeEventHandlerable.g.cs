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

namespace PRI.ProductivityExtensions.CollectionChangeEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.ComponentModel.CollectionChangeEventHandler">CollectionChangeEventHandler</seealso>
	/// </summary>
	public static partial class CollectionChangeEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// collectionchangeeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this CollectionChangeEventHandler collectionchangeeventhandler, Object sender, CollectionChangeEventArgs e, AsyncCallback callback)
		{
			if(collectionchangeeventhandler == null) throw new ArgumentNullException("collectionchangeeventhandler");

			return collectionchangeeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
#endif