using System;
using GalaSoft.MvvmLight.Command;

namespace StayHome.ViewModels.ViewModels
{
    public class AddUserViewModel : BaseViewModel
    {
       
        public AddUserViewModel()
        {
        }

        public override void Cleanup()
        {
            base.Cleanup();
        }

        private string _county;
        public string County
        {
            get { return _county; }
            set { Set(() => County, ref _county, value); }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { Set(() => PhoneNumber, ref _phoneNumber, value); }
        }

        private string _parish;
        public string Parish
        {
            get { return _parish; }
            set { Set(() => Parish, ref _parish, value); }
        }

        private string _district;
        public string District
        {
            get { return _district; }
            set { Set(() => District, ref _district, value); }
        }

        private float _fever;
        public float Fever
        {
            get { return _fever; }
            set { Set(() => Fever, ref _fever, value); }
        }

        private bool _hasBodyPain;
        public bool HasBodyPain
        {
            get { return _hasBodyPain; }
            set { Set(() => HasBodyPain, ref _hasBodyPain, value); }
        }

        private bool _wasInContactWithIllness;
        public bool WasInContactWithIllness
        {
            get { return _wasInContactWithIllness; }
            set { Set(() => WasInContactWithIllness, ref _wasInContactWithIllness, value); }
        }

        private bool _isRiskPatient;
        public bool IsRiskPatient
        {
            get { return _isRiskPatient; }
            set { Set(() => IsRiskPatient, ref _isRiskPatient, value); }
        }

        private RelayCommand _submitNewUserCommand;
        public RelayCommand SubmitNewUserCommand
        {
            get
            {   //Continue from here
                return _submitNewUserCommand ?? (_submitNewUserCommand = new RelayCommand(async () =>
                {
                    if(CanEnroll())
                        _navigationService.GoBack();
                }));
            }
        }

        private bool CanEnroll()
        {
            return _district != string.Empty && _county != string.Empty && _parish != string.Empty;
        }
    }
}
