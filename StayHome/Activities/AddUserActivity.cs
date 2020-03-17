using Android.App;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using StayHome.ViewModels.ViewModels;

namespace StayHome.Droid.Activities
{
    [Activity(Theme = "@style/AppTheme.NoActionBar")]
    public partial class AddUserActivity : BaseActivity<AddUserViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_add_user);

            SetBindings();
        }

        protected override void SetBindings()
        {
            base.SetBindings();

            _bindings.Add(this.SetBinding(() => ViewModel.Parish, () => ParishEditText.Text, BindingMode.TwoWay));
            _bindings.Add(this.SetBinding(() => ViewModel.County, () => CountyEditText.Text, BindingMode.TwoWay));
            _bindings.Add(this.SetBinding(() => ViewModel.District, () => DistrictEditText.Text, BindingMode.TwoWay));
            _bindings.Add(this.SetBinding(() => ViewModel.PhoneNumber, () => PhoneNumberEditText.Text, BindingMode.TwoWay));
            _bindings.Add(this.SetBinding(() => ViewModel.Fever, () => FeverEditText.Text, BindingMode.TwoWay));
            _bindings.Add(this.SetBinding(() => ViewModel.HasBodyPain, () => HasBodyPainCb.Checked, BindingMode.TwoWay));
            _bindings.Add(this.SetBinding(() => ViewModel.WasInContactWithIllness, () => WasInContactWithIllnessCb.Checked, BindingMode.TwoWay));
            _bindings.Add(this.SetBinding(() => ViewModel.IsRiskPatient, () => IsRiskPatientCb.Checked, BindingMode.TwoWay));

            SubmitNewuserButton.SetCommand(ViewModel.SubmitNewUserCommand);
        }
    }
}

