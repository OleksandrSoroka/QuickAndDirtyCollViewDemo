using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace CollViewDemo
{
	// Used in Storyboard.
	partial class DemoCellBottom : UICollectionViewCell
	{
		public DemoCellBottom (IntPtr handle) : base (handle)
		{
	
		}

		public string Title
		{
			set
			{
				this.lblTitle.Text = value;
			}

		}
	}
}
