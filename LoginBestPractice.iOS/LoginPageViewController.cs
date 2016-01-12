using System;
using System.Security.Cryptography;
using System.Text;
using UIKit;

namespace LoginBestPractice.iOS
{
	partial class LoginPageViewController : UIViewController
	{
        //Create an event when a authentication is successful
        public event EventHandler OnLoginSuccess;
        private string name = "";
        private string pw = "";
        private EAEAService.EAEAService service = new EAEAService.EAEAService();

        public LoginPageViewController (IntPtr handle) : base (handle)
		{
        }

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            //Validate our Username & Password.
            //This is usually a web service call.
            //sender.SetTitle("正在登录...",UIControlState.Normal);
            if(IsUserNameValid() && IsPasswordValid())
            {
                name = UserNameTextView.Text.Trim();
                pw = PasswordTextView.Text.Trim();
                //We have successfully authenticated a the user,
                //Now fire our OnLoginSuccess Event.
                if (Login_service(name, stringToMD5(pw)) &&OnLoginSuccess != null)
                {
                    OnLoginSuccess(sender, new EventArgs());
                }
                else
                {
                    //sender.SetTitle("登录", UIControlState.Normal);
                    new UIAlertView("登陆失败", "帐号或密码不正确", null, "确认", null).Show();
                }
            }
            else
            {
                //sender.SetTitle("登录", UIControlState.Normal);
                new UIAlertView("登陆失败", "帐号和密码都不能为空", null, "确认", null).Show();
            }
        }

        private bool IsUserNameValid()
        {
            return !String.IsNullOrEmpty(UserNameTextView.Text.Trim());
        }

        private bool IsPasswordValid()
        {
            return !String.IsNullOrEmpty(PasswordTextView.Text.Trim());
        }

        private bool Login_service(string name, string pw)
        {
            service.MySoapHeaderValue = SoapHeader();
            var ss = service.UserLogin(name, pw);
            return ss;
        }

        public static EAEAService.MySoapHeader SoapHeader()
        {
            EAEAService.MySoapHeader header = new EAEAService.MySoapHeader();
            header.username = "genesysinfo";
            header.password = "genesysinfo";
            return header;
        }

        public static string stringToMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
            StringBuilder sb = new StringBuilder(16);
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString().ToUpper();
        }
    }
}
