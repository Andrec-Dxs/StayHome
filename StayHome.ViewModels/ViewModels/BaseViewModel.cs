using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using StayHome.Core.Interfaces;

namespace StayHome.ViewModels.ViewModels
{
    public class BaseViewModel : ViewModelBase
    {
        public IMyNavigationService _navigationService;

        public BaseViewModel()
        {
            if (SimpleIoc.Default.IsRegistered<IMyNavigationService>())
                _navigationService = SimpleIoc.Default.GetInstance<IMyNavigationService>();

            BackCommand = CreateBackCommand();
        }

        private bool _isLoading;
        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                Set(() => IsLoading, ref _isLoading, value);
            }
        }

        public virtual async Task LoadDataAsync()
        {

        }

        public RelayCommand LogoutCommand { get; private set; }
        private RelayCommand CreateLogoutCommand()
        {
            return new RelayCommand(() => {
                LogoutApp();
            });
        }

        public RelayCommand BackCommand { get; private set; }
        private RelayCommand CreateBackCommand()
        {
            return new RelayCommand(async () => {

                _navigationService.GoBack();
            });
        }

        public void LogoutApp()
        {
            _navigationService.NavigateTo(ViewModelLocator.LoginView);
        }
    }
}
