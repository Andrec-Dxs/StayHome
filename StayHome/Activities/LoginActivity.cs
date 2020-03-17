using System;
using Android.App;
using Android.Content.PM;
using StayHome.ViewModels.ViewModels;

namespace StayHome.Droid.Activities
{
    [Activity(MainLauncher = true, Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class LoginActivity : BaseActivity<LoginViewModel>
    {
        public LoginActivity()
        {

        }
    }
}
