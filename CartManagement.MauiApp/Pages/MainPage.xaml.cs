namespace CartManagement.MauiApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void ToCarControl_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CartControlPage));
    }

    private async void ToCarControlSettings_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
    }

    private async void ToCarTerminal_OnClicked_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TerminalPage));
    }
}