using System;
using GalaSoft.MvvmLight.Command;

namespace StayHome.ViewModels.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {

        }

        public override void Cleanup()
        {
            base.Cleanup();
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { Set(() => PhoneNumber, ref _phoneNumber, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { Set(() => Password, ref _password, value); }
        }

        private RelayCommand _loginCommand;
        public RelayCommand LoginCommand
        {
            get
            {   //Continue from here
                return _loginCommand;
            }
        }
    }
}
