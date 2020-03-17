using System;
using GalaSoft.MvvmLight.Ioc;
using StayHome.ViewModels.ViewModels;

namespace StayHome.ViewModels
{
    public class ViewModelLocator
    {
        public static string AddUserView = "AddUserView";
        public static string UserListView = "UserListView";
        public static string EditUserView = "EditUserView";
        public static string LoginView = "LoginView";

        public T GetViewModel<T>() where T : BaseViewModel
        {
            return SimpleIoc.Default.GetInstance<T>();
        }

        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<AddUserViewModel>();
            SimpleIoc.Default.Register<UserListViewModel>();
            SimpleIoc.Default.Register<EditUserViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
        }

        public AddUserViewModel AddUserViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<AddUserViewModel>();
            }
        }

        public UserListViewModel UserListViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<UserListViewModel>();
            }
        }

        public LoginViewModel LoginViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<LoginViewModel>();
            }
        }

        public EditUserViewModel EditUserViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<EditUserViewModel>();
            }
        }
    }
}
