using System;
using System.Collections.Generic;
using System.Text;

namespace GamingApp.ViewModels
{
    public class LoginUserViewModel : BaseViewModel
    {
        private string password;

        private string username;

        public LoginUserViewModel()
        {
            
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (!string.Equals(this.username, value))
                {
                    username = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (!string.Equals(this.password, value))
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }
        }
    }
}
