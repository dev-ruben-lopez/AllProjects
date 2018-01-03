using Foundation;
using System;
using UIKit;
using RaysHotDogs.core;
using IOSRaysHotDogs.DataSources;

namespace IOSRaysHotDogs
{
    public partial class HotDogTableViewController : UITableViewController
    {

        HotDogsDataService dataService = new HotDogsDataService();

        public HotDogTableViewController (IntPtr handle) : base (handle)
        {
        }


        public override void ViewDidLoad() 
        {
            var hotDogs = dataService.GetAllHotDogs();
            var dataSource = new HotDogDataSource(hotDogs, this);

            TableView.Source = dataSource;

            this.NavigationItem.Title = "Ray's Hot Dog menu";

        }


        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {

            base.RowSelected(tableView, indexPath);

            UIAlertController okAlertController = UIAlertController.Create("Row Selected", "Selected  " + indexPath.Row, UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));        
        }

        //Prepare the data to pass throug the segue
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if(segue.Identifier == "HotDogDetailSegue")
            {
                var hotDogDetailViewController = segue.DestinationViewController as HotDogDetailViewController;

                if(hotDogDetailViewController == null)
                {
                    var source = TableView.Source as HotDogDataSource;
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var item = source.GetItem(rowPath.Row);

                    hotDogDetailViewController.SelectedHotDog = item;
                }

            }
        }


    }
}