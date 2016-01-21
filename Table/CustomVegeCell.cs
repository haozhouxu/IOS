using CoreGraphics;
using Foundation;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Table
{
    public class CustomVegeCell : UITableViewCell
    {
        UILabel headingLabel, subheadingLabel;
        UIImageView imageView;
        public CustomVegeCell(NSString cellId) : base(UITableViewCellStyle.Default, cellId)
        {
            SelectionStyle = UITableViewCellSelectionStyle.Gray;
            ContentView.BackgroundColor = UIColor.FromRGB(218, 255, 127);
            imageView = new UIImageView();
            headingLabel = new UILabel()
            {
                Font = UIFont.FromName("Cochin-BoldItalic", 22f),
                TextColor = UIColor.FromRGB(127, 51, 0),
                BackgroundColor = UIColor.Clear
            };
            headingLabel.LineBreakMode = UILineBreakMode.WordWrap;
            headingLabel.Lines = 0;
            subheadingLabel = new UILabel()
            {
                Font = UIFont.FromName("AmericanTypewriter", 12f),
                TextColor = UIColor.FromRGB(38, 127, 0),
                TextAlignment = UITextAlignment.Center,
                BackgroundColor = UIColor.Clear
            };
            ContentView.AddSubviews(new UIView[] { headingLabel, subheadingLabel, imageView });

        }
        public void UpdateCell(string caption, string subtitle, UIImage image)
        {
            imageView.Image = image;
            headingLabel.Text = caption;
            subheadingLabel.Text = subtitle;
        }
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            //imageView.Frame = new CGRect(ContentView.Bounds.Width - 63, 5, 33, 33);
            //headingLabel.Frame = new CGRect(5, 4, ContentView.Bounds.Width - 63, 80);
            //subheadingLabel.Frame = new CGRect(100, 18, 100, 20);
        }
    }
}
