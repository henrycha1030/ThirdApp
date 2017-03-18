using Android.App;
using Android.Widget;
using ThirdApp.Droid;
using Xamarin.Forms;


[assembly: Dependency(typeof(DisplayAlertDroid))]

namespace ThirdApp.Droid
{
    public class DisplayAlertDroid : IDisplayAlert
    {

        public void DisplayAlert()
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(Forms.Context);
            alert.SetTitle("Say cheese");
            alert.SetMessage("Cheese!");
            alert.SetPositiveButton("Okay", (senderAlert, args) => { });
            alert.SetNegativeButton("Block", (senderAlert, args) => { Toast.MakeText(Forms.Context, "Cheese was blocked", ToastLength.Short).Show(); });
            Dialog dialog = alert.Create();
            dialog.Show();
        }
    }
}