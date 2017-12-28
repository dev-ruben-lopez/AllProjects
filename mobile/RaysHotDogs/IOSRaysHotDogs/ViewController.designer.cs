// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace IOSRaysHotDogs
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btAddToCart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btCancel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView hotdogDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView hotdogImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField hotdogPrice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel hotdogShortDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel hotdogTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txQuantity { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btAddToCart != null) {
                btAddToCart.Dispose ();
                btAddToCart = null;
            }

            if (btCancel != null) {
                btCancel.Dispose ();
                btCancel = null;
            }

            if (hotdogDescription != null) {
                hotdogDescription.Dispose ();
                hotdogDescription = null;
            }

            if (hotdogImage != null) {
                hotdogImage.Dispose ();
                hotdogImage = null;
            }

            if (hotdogPrice != null) {
                hotdogPrice.Dispose ();
                hotdogPrice = null;
            }

            if (hotdogShortDescription != null) {
                hotdogShortDescription.Dispose ();
                hotdogShortDescription = null;
            }

            if (hotdogTitle != null) {
                hotdogTitle.Dispose ();
                hotdogTitle = null;
            }

            if (txQuantity != null) {
                txQuantity.Dispose ();
                txQuantity = null;
            }
        }
    }
}