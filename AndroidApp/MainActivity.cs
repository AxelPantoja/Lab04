using Android.App;
using Android.Widget;
using Android.OS;
using PCLProyect;

namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            //Crear instancia e inyectar la dependencia:
            var Validator =
                new PCLProyect.AppValidator(new AndroidDialog(this));

            Validator.EMail = "";
            Validator.Password = "";
            Validator.Device =
                Android.Provider.Settings.Secure.GetString(
                    ContentResolver,
                    Android.Provider.Settings.Secure.AndroidId);

            Validator.Validate();
        }
    }
}

