using System;
using System.Collections.Generic;
using System.IO;
using Foundation;
using UIKit;

namespace Table
{
    public class TableSource : UITableViewSource
    {
        protected List<string> tableItems;
        protected string CellIndentifier = "TableCell";
        protected NSString cellIdentifier = new NSString("TableCell");
        ViewController owner;

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //UITableViewCell cell = tableView.DequeueReusableCell(CellIndentifier);
            //string item = tableItems[indexPath.Row];

            //if (cell == null)
            //{
            //    //cell = new UITableViewCell(UITableViewCellStyle.Default, CellIndentifier);
            //    cell = new UITableViewCell(UITableViewCellStyle.Subtitle, CellIndentifier);
            //    //cell = new UITableViewCell (UITableViewCellStyle.Value1, CellIndentifier);
            //    //cell = new UITableViewCell (UITableViewCellStyle.Value2, CellIndentifier);
            //}

            ////cell.TextLabel.Text = item;
            //cell.TextLabel.Text = tableItems[indexPath.Row];
            //cell.DetailTextLabel.Text = tableItems[indexPath.Row];
            //cell.ImageView.Image = indexPath.Row % 2 == 0 ? UIImage.FromFile("4.png") : UIImage.FromFile("3.png"); // don't use for Value2
            ////cell.TextLabel.Text = tableItems[indexPath.Row].Heading;
            ////cell.DetailTextLabel.Text = tableItems[indexPath.Row].SubHeading;
            ////cell.ImageView.Image = UIImage.FromFile("Images/" + tableItems[indexPath.Row].ImageName); // don't use for Value2

            ////cell.Accessory = UITableViewCellAccessory.Checkmark;
            ////cell.Accessory = UITableViewCellAccessory.DetailButton;
            ////cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
            //cell.Accessory = UITableViewCellAccessory.DetailDisclosureButton; // implement AccessoryButtonTapped
            ////cell.Accessory = UITableViewCellAccessory.None; // to clear the accessory

            //return cell;

            var cell = tableView.DequeueReusableCell(cellIdentifier) as CustomVegeCell;
            if (cell == null)
                cell = new CustomVegeCell(cellIdentifier);
            cell.UpdateCell(tableItems[indexPath.Row]
                    , tableItems[indexPath.Row]
                    , UIImage.FromFile("4.png"));
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }

        public TableSource(List<string> items, ViewController own)
        {
            tableItems = items;
            this.owner = own;
        }

        //public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        //{
        //    //base.RowSelected(tableView, indexPath);
        //    UIAlertController okAlertController = UIAlertController.Create("Row Selected", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
        //    okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
        //    //ItemViewController ivc = new ItemViewController(tableItems[indexPath.Row]);
        //    owner.PresentViewController(okAlertController, true,null);
        //    tableView.DeselectRow(indexPath, true);
        //}

        public override void AccessoryButtonTapped(UITableView tableView, NSIndexPath indexPath)
        {
            //base.AccessoryButtonTapped(tableView, indexPath);
            UIAlertController okAlertController = UIAlertController.Create("Row Selected", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            owner.PresentViewController(okAlertController, true, null);
            tableView.DeselectRow(indexPath, true);
        }
    }
}
