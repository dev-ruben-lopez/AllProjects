using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace IOSRaysHotDogs.Cells
{
    public class HotDoglistCell : UITableViewCell
    {
        //Create the labels to use in this cell
        UILabel nameLabel;
        UILabel priceLabel;
        UIImageView imageView;

        public HotDoglistCell( NSString cellId) : base (UITableViewCellStyle.Default, cellId)
        {
            SelectionStyle = UITableViewCellSelectionStyle.Gray;
            ContentView.BackgroundColor = UIColor.FromRGB(254, 199, 69);
            imageView = new UIImageView();

            nameLabel = new UILabel()
            {
                Font = UIFont.FromName("Cochin-BoldItalic", 18f),
                TextColor = UIColor.FromRGB(228, 79, 61),
                BackgroundColor = UIColor.Clear
            };

            priceLabel = new UILabel()
            {
                Font = UIFont.FromName("AmericanTypewriter", 12f),
                TextColor = UIColor.FromName("blue"),
                TextAlignment = UITextAlignment.Center,
                BackgroundColor = UIColor.Clear
            };

            ContentView.Add(nameLabel);
            ContentView.Add(priceLabel);
            ContentView.Add(imageView);

        }

        //metod to give location and order to the cell
        public override void LayoutSubviews()
        {

            base.LayoutSubviews();

            imageView.Frame = new RectangleF((float)ContentView.Bounds.Width - 63, 5, 33, 33);
            nameLabel.Frame = new RectangleF(5, 4, (float)ContentView.Bounds.Width - 63, 25);
            priceLabel.Frame = new RectangleF(200, 10, 200, 20);

        }


        //Method to update data
        public void UpdateCell (string caption, string subtitle, UIImage image)
        {
            imageView.Image = image;
            nameLabel.Text = caption;
            priceLabel.Text = subtitle;

        }


    }
}
