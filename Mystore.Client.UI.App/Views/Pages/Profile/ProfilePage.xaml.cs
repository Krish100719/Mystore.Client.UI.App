using Mystore.Client.UI.App.Services;
using Mystore.Client.UI.App.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystore.Client.UI.App.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private readonly AuthService _authService;

        public ProfilePage(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _authService.Logout();
            Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}