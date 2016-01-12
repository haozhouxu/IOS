// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace LoginBestPractice.iOS
{
	[Register ("WelcomeViewController")]
	partial class WelcomeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton Login { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton Register { get; set; }

		[Action ("Login_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Login_TouchUpInside (UIButton sender);

		[Action ("Register_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Register_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (Login != null) {
				Login.Dispose ();
				Login = null;
			}
			if (Register != null) {
				Register.Dispose ();
				Register = null;
			}
		}
	}
}
