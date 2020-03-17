using System;
using Android.App;
using Android.Content.PM;
using StayHome.ViewModels.ViewModels;

namespace StayHome.Droid.Activities
{
    [Activity(Label = "Edit User", Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait, MainLauncher = true)]
    public class EditUserActivity : BaseActivity<EditUserViewModel>
    {
        public EditUserActivity()
        {
        }
    }
}
