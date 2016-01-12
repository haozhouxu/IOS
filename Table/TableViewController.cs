using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Table
{
	partial class TableViewController : UITableViewController
	{
       

		public TableViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            table = new UITableView(View.Bounds); // defaults to Plain style
            string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            this.Source = new TableSource(tableItems);
            Add(table);
        }
    }
}
