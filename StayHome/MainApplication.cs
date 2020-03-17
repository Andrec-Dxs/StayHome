using System;
using Android.App;
using Android.Runtime;
using GalaSoft.MvvmLight.Ioc;
using StayHome.Core.Interfaces;
using StayHome.Droid.Activities;
using StayHome.Droid.NavService;
using StayHome.ViewModels;

namespace StayHome.Droid
{
    public class MainApplication : Application
    {
        public static int currentPosition = -1;

        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                if (_locator == null)
                {
                    _locator = new ViewModelLocator();
                    var nav = new StateKeepNavigationService();

                    nav.Configure(
                        ViewModelLocator.LoginView,
                        typeof(LoginActivity));
                    nav.Configure(
                        ViewModelLocator.AddUserView,
                        typeof(AddUserActivity));
                    nav.Configure(
                        ViewModelLocator.EditUserView,
                        typeof(EditUserActivity));
                    nav.Configure(
                        ViewModelLocator.UserListView,
                        typeof(UserListActivity));

                    SimpleIoc.Default.Register<IMyNavigationService>(() => nav);
                }

                return _locator;
            }
        }

        public MainApplication(IntPtr handle, JniHandleOwnership transer) : base(handle, transer)
        {

        }
    }
}
