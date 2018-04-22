using System.ComponentModel;
using System.Threading.Tasks;
using SmartHotel.Mvvm.Commands;
using SmartHotel.Services;
using SmartHotel.ViewModels.Base;

namespace SmartHotel.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }


        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }


        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(Login, CanLogin)
                .ObservesProperty(() => Username)
                .ObservesProperty(() => Password);
        }

        public DelegateCommand LoginCommand { get; }

        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(Username)
                   && !string.IsNullOrEmpty(Password);
        }

        private void Login()
        {
            if (Username == "abc" && Password == "12345")
            {
                NavigationService.NavigateToAsync<MainViewModel>();
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            return base.InitializeAsync(navigationData);
        }


    }
}
