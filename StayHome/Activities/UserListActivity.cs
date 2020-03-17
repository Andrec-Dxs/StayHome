using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using StayHome.ViewModels.ViewModels;

namespace StayHome.Droid.Activities
{
    [Activity(Label = "User List", Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public partial class UserListActivity : BaseActivity<UserListViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_user_list);

            SetBindings();
        }

        protected override void SetBindings()
        {
            base.SetBindings();

            AddUserBtn.SetCommand("Click",ViewModel.AddUserCommand);
        }
    }
}
