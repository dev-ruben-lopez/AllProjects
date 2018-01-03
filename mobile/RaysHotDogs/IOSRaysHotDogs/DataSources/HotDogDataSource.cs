using System;
using System.Collections.Generic;
using Foundation;
using IOSRaysHotDogs.Cells;
using RaysHotDogs.core.Model;
using UIKit;

namespace IOSRaysHotDogs.DataSources
{
    public class HotDogDataSource : UITableViewSource
    {

        private List<HotDog> hotDogs;
        NSString cellIdentifier = new NSString("HotDogCell");//this string will be the Identifyer in the Table View Cell properties

        public HotDogDataSource(List<HotDog> hotDogs, UITableViewController callingController)
        {
            this.hotDogs = hotDogs;    
        }



        //this method to get generic cells
        /*public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {

            //return an alreade created cell, and if not created then return a default one
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell;

            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            }

            var hotDog = hotDogs[indexPath.Row];
            cell.TextLabel.Text = hotDog.Name;
            cell.ImageView.Image = UIImage.FromFile(hotDog.ImagePath);

            return cell;
        }*/

        //This method to get a custom cell HotDogListCell
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {

            //return an alreade created cell, and if not created then return a default one
            HotDoglistCell cell = tableView.DequeueReusableCell(cellIdentifier) as HotDoglistCell;

            if (cell == null)
            {
                cell = new HotDoglistCell(cellIdentifier); //no need of style.default, as the cell is customized
            }

            cell.UpdateCell(hotDogs[indexPath.Row].Name, "$ " + hotDogs[indexPath.Row].price.ToString(), UIImage.FromFile(hotDogs[indexPath.Row].ImagePath)); 
            return cell;
        }


        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return hotDogs.Count;
        }

        public HotDog GetItem(int rowId)
        {
            return hotDogs[rowId];
        }


    }
}
