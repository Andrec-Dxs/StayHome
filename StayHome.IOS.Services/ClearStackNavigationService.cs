using System;
using CoronaStatusUpdateIOSServices;
using StayHome.Core;
using UIKit;

namespace StayHome.IOS.Services
{
    public class ClearStackNavigationService : CustomNavigationService
    {
        override public void NavigateTo(string pageKey, object parameter, NavigationStackMode mode)
        {
            lock (_pagesByKey)
            {

                Exception creationException = null;
                var done = false;
                TypeActionOrKey item;

                if (_pagesByKey.ContainsKey(pageKey))
                {
                    item = _pagesByKey[pageKey];
                }
                else
                {
                    item = new TypeActionOrKey
                    {
                        StoryboardControllerKey = pageKey
                    };
                }

                UIViewController controller = null;

                if (item.CreateControllerAction != null)
                {
                    try
                    {
                        controller = item.CreateControllerAction(parameter);
                        done = true;
                    }
                    catch (Exception ex)
                    {
                        creationException = ex;
                    }
                }

                if (!string.IsNullOrEmpty(item.StoryboardControllerKey))
                {

                    if (NavigationController == null)
                    {
                        throw new InvalidOperationException(
                            "Unable to navigate: Did you forget to call NavigationService.Initialize?");
                    }

                    if (NavigationController.Storyboard == null)
                    {
                        throw new InvalidOperationException(
                            "Unable to navigate: No storyboard found. You need to call NavigationService.Configure!");
}
try
{
                        controller = NavigationController.Storyboard.InstantiateViewController(item.StoryboardControllerKey);
                        done = true;
                    }
                    catch (Exception ex)
                    {

                        creationException = ex;
                    }

                    if (parameter != null)
                    {

                        var casted = controller as ControllerBase;
                        if (casted != null)
                        {
                            casted.NavigationParameter = parameter;
                        }

                        //Save parameter in list for later
                        _parametersByController.Add(new WeakReference(controller), parameter);
                    }
                }


                if (!done && item.ControllerType != null)
                {
                    try
                    {
                        controller = MakeController(item.ControllerType, parameter);

                        if (controller == null)
                        {
                            throw new InvalidOperationException("No suitable constructor found for page" + pageKey);
                        }
                    }
                    catch (Exception ex)
                    {
                        creationException = ex;
                    }
                }

                if (controller == null)
                {

                    throw new InvalidOperationException(string.Format("Unable to create a controller for key{0}", pageKey), creationException);
                }

                if (item.ControllerType == null)
                {

                    item.ControllerType = controller.GetType();
                }

                if (mode == NavigationStackMode.CLEAR_STACK)
                {

                    UIViewController[] clearStack = { controller };
                    NavigationController.PushViewController(controller, true);
                    NavigationController.ViewControllers = clearStack;
                }
                else if (mode == NavigationStackMode.POP_PARENT)
                {
                    (controller as HistoryBaseViewController).NoHistory = true;
                    PushViewWithHistory(controller, true);
                }
                else if (mode == NavigationStackMode.RELOAD)
{
                    NavigationController.PopViewController(false);
                    PushViewWithHistory(controller, false);
                }
                else if (mode == NavigationStackMode.CLEAR_HIDDEN)
                {
                    UIViewController[] clearStack = { controller };
NavigationController.PushViewController(controller, false);
                    NavigationController.ViewControllers = clearStack;
}
                else
                {
                    PushViewWithHistory(controller, true);
                }

            }
        }

    }
}
