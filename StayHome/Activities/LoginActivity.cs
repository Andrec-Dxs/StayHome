using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using StayHome.ViewModels.ViewModels;

namespace StayHome.Droid.Activities
{
    [Activity(MainLauncher = true, Theme = "@style/AppTheme.NoActionBar", ScreenOrientation = ScreenOrientation.Portrait)]
    public partial class LoginActivity : BaseActivity<LoginViewModel>
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);

            SetBindings();
        }

        protected override void SetBindings()
        {
            base.SetBindings();

            _bindings.Add(this.SetBinding(() => ViewModel.EmailPhone, () => EmailPhoneEt.Text, BindingMode.TwoWay));
            _bindings.Add(this.SetBinding(() => ViewModel.Password, () => PasswordEt.Text, BindingMode.TwoWay));

            LoginBtn.SetCommand(ViewModel.LoginCommand);
        }    
    }
}
