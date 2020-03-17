using System;
using GalaSoft.MvvmLight.Command;

namespace StayHome.ViewModels.ViewModels
{
    public class UserListViewModel : BaseViewModel
    {
        public UserListViewModel()
        {
        }

        public override void Cleanup()
        {
            base.Cleanup();
        }

        private RelayCommand _addUserCommand;
        public RelayCommand AddUserCommand
        {
            get
            {   //Continue from here
                return _addUserCommand ?? (_addUserCommand = new RelayCommand(async () =>
                {
                    _navigationService.NavigateTo(ViewModelLocator.AddUserView);
                }));
            }
        }
    }
}
