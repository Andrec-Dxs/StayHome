using System;
using Android.Views;

namespace StayHome.Droid.Converters
{
    public static class VisibilityConverter
    {
        public static ViewStates Convert(bool isVisible)
        {
            return isVisible ? ViewStates.Visible : ViewStates.Gone;
        }

        public static ViewStates InvertConvert(bool isVisible)
        {
            return isVisible ? ViewStates.Gone : ViewStates.Visible;
        }

        public static ViewStates ConvertInvisible(bool isVisible)
        {
            return isVisible ? ViewStates.Visible : ViewStates.Invisible;
        }
    }
}
