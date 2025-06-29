using Mystore.Client.UI.App;
using Mystore.Client.UI.App.ViewModels;
using Mystore.Client.UI.App.Views.Pages;

namespace Mystore.Client.UI.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Register all routes
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));

        }
    }
}
