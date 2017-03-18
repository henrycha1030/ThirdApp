using Xamarin.Forms;
using ThirdApp.iOS;
using UIKit;

[assembly: Dependency(typeof(DisplayAlertIOS))]

namespace ThirdApp.iOS
{
    public class DisplayAlertIOS : IDisplayAlert
    {
        public void DisplayAlert()
        {
            UIAlertController alert = UIAlertController.Create("Say Cheese", "Cheese!", UIAlertControllerStyle.Alert);

            alert.AddAction(UIAlertAction.Create("Okay", UIAlertActionStyle.Default, null));
            alert.AddAction(UIAlertAction.Create("Block", UIAlertActionStyle.Cancel, null));
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);
        }
    }
}