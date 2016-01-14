using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Table
{
	partial class ItemViewController : UIViewController
	{
        private string name;

		public ItemViewController (IntPtr handle) : base (handle)
		{
		}
        public ItemViewController(string name):base()
        {
            this.name = name;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //this.Lavel1.Text = name;
        }
    }
}
