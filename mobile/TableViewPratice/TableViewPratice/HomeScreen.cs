using System;
using CoreGraphics;
using System.Collections.Generic;
using UIKit;

namespace TableViewPratice
{
    public partial class HomeScreen : UITableViewController
    {

        string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };


        public HomeScreen (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TableView.Source = new TableSource(tableItems, "");


            //table = new UITableView(new CGRect(0, 20, View.Bounds.Width, View.Bounds.Height - 20)); // defaults to Plain style
            //table.AutoresizingMask = UIViewAutoresizing.All;
            //table.Source = new TableSource(tableItems, this);
            //Add(table);
        }
    }
}