using System;
using Android.Content;
using StayHome.Core;

namespace StayHome.Droid.Services
{
    public class ClearStackNavigationService : AppCompatNavigationService
    {
        override public void NavigateTo(string pageKey, object parameter, NavigationStackMode mode)
        {
            AppCompatDispatcherHelper.CheckBeginInvokeOnUI(() =>
            {
                if (AppCompatActivityBase.CurrentActivity == null)
                    throw new InvalidOperationException("No CurrentActivity found");

                lock (_pagesByKey)
                {
                    if (!_pagesByKey.ContainsKey(pageKey))
                        throw new ArgumentException($"No such page: {pageKey}. Did you forget to call NavigationService.Configure?", nameof(pageKey));

                    Intent intent = new Intent(AppCompatActivityBase.CurrentActivity, _pagesByKey[pageKey]);
                    if (parameter != null)
                    {
                        lock (_parametersByKey)
                        {
                            var guid = Guid.NewGuid().ToString();
                            _parametersByKey.Add(guid, parameter);
                            intent.PutExtra(ParameterKeyName, guid);
                        }
                    }

                    if (mode == NavigationStackMode.CLEAR_STACK)
                    {
                        intent.SetFlags(ActivityFlags.NewTask | ActivityFlags.ClearTask);
                    }
                    else if (mode == NavigationStackMode.CLEAR_HIDDEN)
                    {
                        intent.SetFlags(ActivityFlags.NewTask | ActivityFlags.ClearTask);
                    }
                    else if (mode == NavigationStackMode.POP_PARENT)
                    {
                        intent.SetFlags(ActivityFlags.NoHistory);
                    }
                    else if (mode == NavigationStackMode.RELOAD)
                    {
                        intent.SetFlags(ActivityFlags.NoAnimation);
                        AppCompatActivityBase.CurrentActivity.Finish();
                    }

                    AppCompatActivityBase.CurrentActivity.StartActivity(intent);
                    AppCompatActivityBase.NextPageKey = pageKey;
                }
            });
        }
    }
}
