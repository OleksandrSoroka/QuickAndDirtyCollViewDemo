// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace CollViewDemo
{
	[Register ("CollViewDemoViewController")]
	partial class CollViewDemoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UICollectionView collViewBottom { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UICollectionView collViewTop { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (collViewBottom != null) {
				collViewBottom.Dispose ();
				collViewBottom = null;
			}
			if (collViewTop != null) {
				collViewTop.Dispose ();
				collViewTop = null;
			}
		}
	}
}
