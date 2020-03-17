using System;
using GalaSoft.MvvmLight.Views;

namespace StayHome.Core.Interfaces
{
    public interface IMyNavigationService : INavigationService
    {
        void NavigateTo(string pageKey, object parameter, NavigationStackMode mode);
    }
}
