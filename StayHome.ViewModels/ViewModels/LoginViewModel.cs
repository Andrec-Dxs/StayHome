using GalaSoft.MvvmLight.Command;
using System;

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

        private string _emailPhone;
        public string EmailPhone
        {
            get { return _emailPhone; }
            set { Set(() => EmailPhone, ref _emailPhone, value); }
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
                return _loginCommand ?? (_loginCommand = new RelayCommand(async() =>
                {
                    _navigationService.NavigateTo(ViewModelLocator.UserListView);
                }));
            }
        }
    }
}
