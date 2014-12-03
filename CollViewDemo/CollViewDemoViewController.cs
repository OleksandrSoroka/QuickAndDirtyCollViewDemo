using System;
using System.Drawing;

using Foundation;
using UIKit;
using CoreGraphics;

namespace CollViewDemo
{
	public partial class CollViewDemoViewController : UIViewController
	{
		string[] topData;
		string[] bottomData;


		public CollViewDemoViewController (IntPtr handle) : base (handle)
		{
			// Create some data for the two collection views.
			this.topData = new string[100];
			for (int i = 0; i < this.topData.Length; i++)
			{
				this.topData [i] = "Up " + (i + 1);
			}

			this.bottomData = new string[100];
			for (int i = 0; i < this.topData.Length; i++)
			{
				this.bottomData [i] = "Down " + (i + 1);
			}
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Delegating collection view delegate. Couldn't get the iOS8 style to work, so this works for iOS7 too.
			// (Using EstimatedCellSize of UICollectionViewFlowLayout gives me an incosistency exception...sigh...I presume a bug in the Unified API). 
			// You can also try for iOS8 (but no Storyboard): http://blog.xamarin.com/new-collection-view-features-in-ios-8/
			this.collViewTop.Delegate = new DemoCollViewDelegate
			{
				CellSize = indexPath => new CGSize(150, 170)
			};

			// Differnt sizes for bottom view.
			this.collViewBottom.Delegate = new DemoCollViewDelegate
			{
				CellSize = indexPath => new CGSize(220, 240)
			};

			// Assign data sources. These are also delegate sources.
			this.collViewTop.DataSource = new DemoDataSource ("DEMO_CELL_TOP")
			{
				ItemCount = section => (nint)this.topData.Length,
				UpdateCell = (cell, indexPath) => {
					var demoCell = cell as DemoCellTop;
					if(demoCell != null)
					{
						demoCell.Title = this.topData[indexPath.Row];
					}
				}
			};

			this.collViewBottom.DataSource = new DemoDataSource ("DEMO_CELL_BOTTOM")
			{
				ItemCount = section => (nint)this.topData.Length,
				UpdateCell = (cell, indexPath) => {
					var demoCell = cell as DemoCellBottom;
					if(demoCell != null)
					{
						demoCell.Title = this.topData[indexPath.Row];
					}
				}
			};
		}
	}
}

