using System;
using Android.Support.Design.Widget;
using Android.Widget;

namespace StayHome.Droid.Activities
{
    public partial class LoginActivity
    {
        private TextInputEditText _emailPhoneEt;
        public TextInputEditText EmailPhoneEt
        {
            get
            {
                return _emailPhoneEt
                    ?? (_emailPhoneEt = FindViewById<TextInputEditText>(Resource.Id.email_phone_input));
            }
        }

        private TextInputEditText _passwordEt;
        public TextInputEditText PasswordEt
        {
            get
            {
                return _passwordEt
                    ?? (_passwordEt = FindViewById<TextInputEditText>(Resource.Id.password_input));
            }
        }

        private Button _loginBtn;
        public Button LoginBtn
        {
            get
            {
                return _loginBtn
                    ?? (_loginBtn = FindViewById<Button>(Resource.Id.login_btn));
            }
        }

        
    }
}
