using System;
using Android.App;
using Android.Content.PM;
using StayHome.ViewModels.ViewModels;

namespace StayHome.Droid.Activities
{
    [Activity(Label = "User List", Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public class UserListActivity : BaseActivity<UserListViewModel>
    {
        public UserListActivity()
        {

        }
    }
}
