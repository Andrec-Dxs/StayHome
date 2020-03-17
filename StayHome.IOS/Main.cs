using System;
using GalaSoft.MvvmLight.Ioc;
using StayHome.Core.Interfaces;
using StayHome.IOS.Services;
using StayHome.IOS.ViewControllers;
using StayHome.ViewModels;
using UIKit;

namespace StayHome.IOS
{
    public class Application
    {
        private static UINavigationController _navigationController;
        public static UINavigationController NavigationController
        {
            get
            {
                var a = Locator.ToString();
                if (_navigationController == null)
                {
                    _navigationController = new UINavigationController(new LoginViewController());
                    //_navigationController = new UINavigationController(new AgendaViewController());
                }
                return _navigationController;
            }

            set
            {
                _navigationController = value;
            }
        }

        public static nfloat TopSafeArea
        {
            get
            {
                var version = UIDevice.CurrentDevice.SystemVersion.Split(new char[] { '.' })[0];
                if (int.Parse(version) >= 11)
                    return UIApplication.SharedApplication.KeyWindow.SafeAreaInsets.Top;
                return 0;
            }
        }

        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                if (_locator == null)
                {
                    _locator = new ViewModelLocator();

                    var nav = new ClearStackNavigationService();

                    nav.Configure(ViewModelLocator.LoginView, typeof(LoginViewController));
                    nav.Configure(ViewModelLocator.AddUserView, typeof(AddUserViewController));
                    nav.Configure(ViewModelLocator.UserListView, typeof(UserListViewController));
                    nav.Configure(ViewModelLocator.EditUserView, typeof(EditUserViewController));

                    SimpleIoc.Default.Register<IMyNavigationService>(() => nav);

                }

                return _locator;
            }
        }



        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}