using Mystore.Client.UI.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystore.Client.UI.App.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private readonly AuthService _authService;

        public LoginPage(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            _authService.Login();
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}