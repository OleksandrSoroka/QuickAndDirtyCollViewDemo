using System;
using UIKit;
using Foundation;

namespace CollViewDemo
{
	// Delegating data source.
	public class DemoDataSource : UICollectionViewDataSource
	{
		public Action<UICollectionViewCell, NSIndexPath> UpdateCell;
		public Func<nint, nint> ItemCount;

		public DemoDataSource (string cellId) : base()
		{
			this.cellId = new NSString (cellId);
		}

		NSString cellId;

		public override UICollectionViewCell GetCell (UICollectionView collectionView, Foundation.NSIndexPath indexPath)
		{
			UICollectionViewCell cell = collectionView.DequeueReusableCell (this.cellId, indexPath) as UICollectionViewCell;
			this.UpdateCell (cell, indexPath);

			return cell;
		}

		public override nint GetItemsCount (UICollectionView collectionView, nint section)
		{
			return this.ItemCount (section);
		}

		public override nint NumberOfSections (UICollectionView collectionView)
		{
			return 1;
		}
	}
}

