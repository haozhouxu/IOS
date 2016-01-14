using System;

using UIKit;
using Table.EAEAService;
using System.Linq;
using System.Collections.Generic;
using CoreGraphics;

namespace Table
{
    public partial class ViewController : UIViewController
    {
        private EAEAService.EAEAService service = new EAEAService.EAEAService();
        private int[] types = new int[] { 13 };
        private QuesAndAnswerFilter qf;
        List<string> tableItems = new List<string>();

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            //table1 = new UITableView(View.Bounds); // defaults to Plain style
            //tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            //tableItems.Add("Vegetables");
            //tableItems.Add("Fruits");
            //tableItems.Add("Flower Buds");
            GetDataFromService();
            //table1.SeparatorColor = UIColor.Blue;
            //TableView.SeparatorStyle = UITableViewCellSeparatorStyle.DoubleLineEtched;

            //table1.SeparatorEffect =UIBlurEffect.FromStyle(UIBlurEffectStyle.Dark);

            //var effect = UIBlurEffect.FromStyle(UIBlurEffectStyle.Light);
            //table1.SeparatorEffect = UIVibrancyEffect.FromBlurEffect(effect);

            table1.SeparatorInset.InsetRect(new CGRect(4, 4, 150, 2));

            table1.Source = new TableSource(tableItems, this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void GetDataFromService()
        {
            service.MySoapHeaderValue = SoapHeader();
            qf = new QuesAndAnswerFilter();
            qf.QuesCategoryIDs = types;
            int totalCount = 0;
            service.GetQuesAndAnswerByFilterNew(qf, 1, 10, out totalCount).ToList().ForEach(x =>
            {
                tableItems.Add(x.QuesName);
            });
        }

        public static EAEAService.MySoapHeader SoapHeader()
        {
            MySoapHeader header = new MySoapHeader();
            header.username = "genesysinfo";
            header.password = "genesysinfo";
            return header;
        }
    }
}