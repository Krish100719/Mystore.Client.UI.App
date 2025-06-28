using Mystore.Client.UI.App.Services;
using Mystore.Client.UI.App.Views.Pages;
using Windows.Networking.NetworkOperators;

namespace Mystore.Client.UI.App.WinUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseSharedMauiApp();

            builder.Services.AddTransient<AuthService>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<ProfilePage>();

            return builder.Build();
        }
    }
}
