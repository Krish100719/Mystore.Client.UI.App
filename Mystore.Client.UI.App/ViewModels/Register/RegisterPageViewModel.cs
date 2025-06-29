using Mystore.Client.UI.App.Views.Pages;
using Mystore.SIS.Client.Common.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mystore.Client.UI.App.ViewModels
{
    public class RegisterPageViewModel
    {
        private RegisterUserModel _registerUserModel;
        public RegisterUserModel RegisterUserModel
        {
            get => _registerUserModel;
            set
            {
                _registerUserModel = value;
            }
        }
        public RegisterPageViewModel()
        {
            RegisterUserModel = new RegisterUserModel(); // prevent null binding issues
        }
        public ICommand CommandRegisterUser => new Command(RegisterUserClicked);


        private async void RegisterUserClicked()
        {
            if (string.IsNullOrWhiteSpace(RegisterUserModel.Email) ||
                string.IsNullOrWhiteSpace(RegisterUserModel.Password) ||
                string.IsNullOrWhiteSpace(RegisterUserModel.ConfirmPassword) ||
                string.IsNullOrWhiteSpace(RegisterUserModel.UserName))
            {
                // Show error message for empty fields
                await Shell.Current.DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }
            await Shell.Current.GoToAsync("//LoginPage");

        }
    }
}
