using System;
using Android.App;
using Android.Content.PM;
using StayHome.ViewModels.ViewModels;

namespace StayHome.Droid.Activities
{
    [Activity(Label = "Login", Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait, MainLauncher = true)]
    public class LoginActivity : BaseActivity<LoginViewModel>
    {
        public LoginActivity()
        {
        }
    }
}
