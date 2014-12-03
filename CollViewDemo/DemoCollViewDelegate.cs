using System;
using UIKit;
using CoreGraphics;
using Foundation;

namespace CollViewDemo
{
	public class DemoCollViewDelegate : UICollectionViewDelegateFlowLayout
	{
		public DemoCollViewDelegate () : base()
		{
		}

		public Func<NSIndexPath, CGSize> CellSize;

		public override CoreGraphics.CGSize GetSizeForItem (UICollectionView collectionView, UICollectionViewLayout layout, Foundation.NSIndexPath indexPath)
		{
			return CellSize (indexPath);
		}

	}
}

