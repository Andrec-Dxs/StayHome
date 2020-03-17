using System;
using Android.Support.Design.Widget;
using Android.Widget;

namespace StayHome.Droid.Activities
{
    public partial class AddUserActivity
    {
        private TextInputEditText _parishEditText;
        public TextInputEditText ParishEditText
        {
            get
            {
                return _parishEditText
                    ?? (_parishEditText = FindViewById<TextInputEditText>(Resource.Id.parish_et));
            }
        }

        private TextInputEditText _countyEditText;
        public TextInputEditText CountyEditText
        {
            get
            {
                return _countyEditText
                    ?? (_countyEditText = FindViewById<TextInputEditText>(Resource.Id.county_et));
            }
        }

        private TextInputEditText _districtEditText;
        public TextInputEditText DistrictEditText
        {
            get
            {
                return _districtEditText
                    ?? (_districtEditText = FindViewById<TextInputEditText>(Resource.Id.district_et));
            }
        }

        private TextInputEditText _phoneNumberEditText;
        public TextInputEditText PhoneNumberEditText
        {
            get
            {
                return _phoneNumberEditText
                    ?? (_phoneNumberEditText = FindViewById<TextInputEditText>(Resource.Id.phone_et));
            }
        }

        private TextInputEditText _feverEditText;
        public TextInputEditText FeverEditText
        {
            get
            {
                return _feverEditText
                    ?? (_feverEditText = FindViewById<TextInputEditText>(Resource.Id.fever_et));
            }
        }

        private CheckBox _hasBodyPain;
        public CheckBox HasBodyPainCb
        {
            get
            {
                return _hasBodyPain
                    ?? (_hasBodyPain = FindViewById<CheckBox>(Resource.Id.body_pain_cb));
            }
        }

        private CheckBox _wasInContactWithIllness;
        public CheckBox WasInContactWithIllnessCb
        {
            get
            {
                return _wasInContactWithIllness
                    ?? (_wasInContactWithIllness = FindViewById<CheckBox>(Resource.Id.contact_cb));
            }
        }

        private CheckBox _isRiskPatient;
        public CheckBox IsRiskPatientCb
        {
            get
            {
                return _isRiskPatient
                    ?? (_isRiskPatient = FindViewById<CheckBox>(Resource.Id.risk_patient_cb));
            }
        }

        private Button _submitNewUserBtn;
        public Button SubmitNewuserButton
        {
            get
            {
                return _submitNewUserBtn
                    ?? (_submitNewUserBtn = FindViewById<Button>(Resource.Id.submit_new_user_btn));
            }
        }
    }
}
