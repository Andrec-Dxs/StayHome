using System;
using System.Collections.Generic;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Ioc;
using StayHome.Core.Interfaces;
using StayHome.Droid.NavService;
using StayHome.Droid.Services;
using StayHome.ViewModels.ViewModels;

namespace StayHome.Droid.Activities
{
    public class BaseActivity<T> : AppCompatActivityBase where T : BaseViewModel
    {
        protected List<Binding> _bindings;
        protected T ViewModel
        {
            get;
            private set;
        }

        public BaseActivity()
        {
            _bindings = new List<Binding>();
            ViewModel = MainApplication.Locator.GetViewModel<T>();
        }

        protected virtual void SetBindings()
        {
            //_bindings.Add(this.SetBinding(() => ViewModel.IsLoading, () => LoadingLayer.Visibility).ConvertSourceToTarget(VisibilityConverter.Convert));
        }

        private StateKeepNavigationService _navigationService;
        protected StateKeepNavigationService NavigationService
        {
            get
            {
                if (_navigationService == null)
                {
                    _navigationService = (StateKeepNavigationService)SimpleIoc.Default.GetInstance<IMyNavigationService>();
                }
                return _navigationService;
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void OnRestart()
        {
            base.OnRestart();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            foreach (var binding in _bindings)
            {
                binding.Detach();
            }
            _bindings.Clear();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public override void OnBackPressed()
        {
            base.OnBackPressed();
            Finish();
        }
    }
}
