using System;
using Foundation;
using UIKit;

namespace StayHome.IOS.Services
{
    /// <summary>
    /// A base class to be used with the <see cref="NavigationService" /> when
    /// using Storyboards.
    /// </summary>
    ////[ClassInfo(typeof(INavigationService))]
    [Obsolete("This class is not needed anymore. Instead, use a normal UIViewController, and then use NavigationService.GetAndRemoveParameter to retrieve the navigation parameter.")]
    public class ControllerBase : UIViewController
    {

        /// <summary>
        /// The parameter passed to this controller by the
        /// <see cref="NavigationService.NavigateTo(string, object)"/>  method.
        /// </summary>
        public object NavigationParameter
        {

            get;
            set;
        }

        public ControllerBase(NSCoder coder) : base(coder)
        {

        }

        public ControllerBase(NSObjectFlag t) : base(t)
        {

        }

        public ControllerBase(string nibName, NSBundle bundle) : base(nibName, bundle)
        {

        }

        public ControllerBase()
        {

        }

        protected internal ControllerBase(IntPtr handle) : base(handle)
        {

        }
    }
}
