using System;
using Android.Support.Design.Widget;
using Android.Support.V7.Widget;

namespace StayHome.Droid.Activities
{
    public partial class UserListActivity
    {

        private RecyclerView _usersRecycler;
        public RecyclerView UsersRecycler
        {
            get
            {
                return _usersRecycler
                    ?? (_usersRecycler = FindViewById<RecyclerView>(Resource.Id.users_recycler));
            }
        }

        private FloatingActionButton _addUserBtn;
        public FloatingActionButton AddUserBtn
        {
            get
            {
                return _addUserBtn
                    ?? (_addUserBtn = FindViewById<FloatingActionButton>(Resource.Id.fab));
            }
        }
    }
}
