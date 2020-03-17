using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using StayHome.ViewModels.ViewModels;

namespace StayHome.Droid.Activities
{
    [Activity(Label = "Edit User", Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public partial class EditUserActivity : BaseActivity<EditUserViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void SetBindings()
        {
            base.SetBindings();
        }
    }
}
