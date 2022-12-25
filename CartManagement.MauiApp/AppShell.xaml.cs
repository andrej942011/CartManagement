using CartManagement.MauiApp.Pages;

namespace CartManagement.MauiApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(CartControlPage), typeof(CartControlPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(TerminalPage), typeof(TerminalPage));
        }
    }
}