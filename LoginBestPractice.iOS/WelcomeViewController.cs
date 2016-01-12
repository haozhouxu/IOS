using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LoginBestPractice.iOS
{
	partial class WelcomeViewController : UIViewController
	{

        //Create an event when a authentication is successful
        public event EventHandler OnLogin;
        public event EventHandler OnRegister;

        public WelcomeViewController (IntPtr handle) : base (handle)
		{
		}

        partial void Login_TouchUpInside(UIButton sender)
        {
            if (OnLogin != null)
            {
                OnLogin(sender, new EventArgs());
            }
        }

        partial void Register_TouchUpInside(UIButton sender)
        {
            if (OnRegister != null)
            {
                OnRegister(sender, new EventArgs());
            }
        }
    }
}
