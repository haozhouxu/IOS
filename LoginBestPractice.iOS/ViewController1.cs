using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LoginBestPractice.iOS
{
	partial class ViewController1 : UIViewController
	{
		public ViewController1 (IntPtr handle) : base (handle)
		{

		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            //table1 = new UITableView(View.Bounds); // defaults to Plain style
            string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            table1.Source = new TableSource(tableItems, this);
        }
    }
}
