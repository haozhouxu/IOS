using System;
using System.Collections.Generic;
using System.IO;
using Foundation;
using UIKit;

namespace LoginBestPractice.iOS
{
    public class TableSource : UITableViewSource
    {
        string[] TableItems;
        string CellIndentifier = "TableCell";

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIndentifier);
            string item = TableItems[indexPath.Row];

            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIndentifier);
            }

            cell.TextLabel.Text = item;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Length;
        }

        public TableSource(string[] items)
        {
            TableItems = items;
        }
    }
}
