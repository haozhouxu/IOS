using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Table
{
    public class vegeTableCell : UITableViewCell
    {
        public const string Identifier = "Reuse";
        private UILabel headerLabel;
        private UILabel textLabel;
        private UIView seperator;

        protected internal vegeTableCell(IntPtr handle) : base(handle)
        {
            headerLabel = new UILabel();
            headerLabel.TextColor = UIColor.Black;
            textLabel.Lines = 0;
            textLabel.LineBreakMode = UILineBreakMode.WordWrap;
            headerLabel.Font = UIFont.SystemFontOfSize(18);

            textLabel = new UILabel();
            textLabel.TextColor = UIColor.Black;
            textLabel.Lines = 0;
            textLabel.LineBreakMode = UILineBreakMode.WordWrap;
            textLabel.Font = UIFont.SystemFontOfSize(14);

            seperator = new UIView();
            seperator.BackgroundColor = UIColor.FromRGB(211, 211, 211);

            ContentView.AddSubviews(headerLabel, textLabel, seperator);
        }
        public void UpdateCell(string headerLabel, string textLabel)
        {
            this.headerLabel.Text = headerLabel;
            this.textLabel.Text = textLabel;
        }
    }
}
