using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mystore.Client.UI.App.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _errorMessage;
        private bool _hasError;
        public string AppVersion { get; private set; } = string.Empty;

        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set { _errorMessage = value; OnPropertyChanged(); }
        }

        public bool HasError
        {
            get => _hasError;
            set { _hasError = value; OnPropertyChanged(); }
        }
        public ICommand CommandForgotPassword => new Command(ForgotPassword);
        public ICommand LoginCommand => new Command(Login);  
        public ICommand RegisterCommand => new Command(Register);
        public LoginPageViewModel()
        {   
            AppVersion = VersionTracking.CurrentVersion;
        }

        private async void ForgotPassword()
        {
           
        }

        private async void Login()
        {
            HasError = false;

            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                ErrorMessage = "Please enter both username and password.";
                HasError = true;
                return;
            }

            if (Username == "admin" && Password == "1234")
            {
                await Shell.Current.DisplayAlert("Success", "Login Successful!", "OK");
                await Shell.Current.GoToAsync("//ProfilePage");
                // Navigate to home/dashboard if needed
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
                HasError = true;
            }
        }

        private async void Register()
        {
            await Shell.Current.GoToAsync("//RegisterUser"); // Assumes route is registered
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
