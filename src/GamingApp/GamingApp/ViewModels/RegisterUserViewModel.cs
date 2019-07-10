using GamingApp.Services;
using GamingApp.Services.Interfaces;

namespace GamingApp.ViewModels
{
    public class RegisterUserViewModel : BaseViewModel
    {
        private string username;

        private string password;

        private IUserService userService;

        public RegisterUserViewModel(IUserService userService)
        {
            this.userService = userService;
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (!string.Equals(this.username, value))
                {
                    username = value;
                    OnPropertyChanged(nameof(Username));
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
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public void Register()
        {
            var user = this.userService.Register(this.Username, this.Password);
        }
    }
}
