QuickAndDirtyCollViewDemo
=========================


* All is setup in a Storyboard and uses size classes: this demo works on all iOS devices
* Using the "EstimatedCellSize" as described here http://blog.xamarin.com/new-collection-view-features-in-ios-8/ does not work for me when using Storyboards. Could be a bug in Unified API.
* I use the iOS7 compatible version - not much of a hassle.
* Special: view contains two UICollectionViews and the controller is a standard UIViewController and not a UICollectionViewController
* Data is provided by a delegating data source
* Behavior (cell size) is provided by a delegating collection view delegate.
* Cells are designed in Storyboard and have a reuse ID which has to match the one used in code for the delegating data source.

Enjoy.
