using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace PasswordKeeperMvvmCross.Droid
{
    [Activity(
        Label = "PasswordKeeperMvvmCross"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
