using Foundation;
using System;
using UIKit;
using RaysHotDogs.core.Model;
using RaysHotDogs.core;

namespace IOSRaysHotDogs
{
    public partial class HotDogDetailViewController : UIViewController
    {

        public HotDog SelectedHotDog { get; set; }
        HotDogsDataService hotDogsDataService = new HotDogsDataService();

        public HotDogDetailViewController (IntPtr handle) : base (handle)
        {
            //get amy hotdog to fill the view


            SelectedHotDog = hotDogsDataService.GetHotDog(1);
        }

        //Specify here how the View is going to represent the data

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            DataUIBind();

            //eventhandlers
            btAddToCart.TouchUpInside += (object sender, EventArgs e) =>
            {
                UIAlertView message = new UIAlertView { Title = "Ray's HotDogs", Message = "That hot dog is a perfect choice !" };
                message.AddButton("Ok");
                message.Show();
            };


            btCancel.TouchUpInside += (object sender, EventArgs e) =>
            {
                UIAlertView errorMessage = new UIAlertView { Title = "Ray's HotDogs", Message = "Method not implemented" };
                errorMessage.AddButton("Close");
                errorMessage.Show();
            };
        }




        //default hotdot when opens
        private void DataUIBind()
        {
            UIImage htImage = UIImage.FromFile(SelectedHotDog.ImagePath);
            hotdogImage.Image = htImage;
            hotdogTitle.Text = SelectedHotDog.Name;
            hotdogShortDescription.Text = SelectedHotDog.ShortDescription;
            hotdogDescription.Text = SelectedHotDog.Description;
            hotdogPrice.Text = SelectedHotDog.price.ToString();


        }
    }
}