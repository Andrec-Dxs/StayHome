using System;
using StayHome.Core;
using StayHome.Droid.Services;

namespace StayHome.Droid.NavService
{
    public class StateKeepNavigationService : ClearStackNavigationService
    {
        public override void NavigateTo(string pageKey)
        {
            base.NavigateTo(pageKey);
        }

        public override void GoBack()
        {
            //    var activity = AppCompatActivityBase.CurrentActivity;
            base.GoBack();
        }

        public override void NavigateTo(string pageKey, object parameter)
        {
            base.NavigateTo(pageKey, parameter);
        }

        public override void NavigateTo(string pageKey, object parameter, NavigationStackMode mode)
        {
            base.NavigateTo(pageKey, parameter, mode);
        }
    }
}
