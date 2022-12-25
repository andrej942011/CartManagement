using CartManagement.MauiApp.ViewModes;

namespace CartManagement.MauiApp.Pages;

public partial class TerminalPage : ContentPage
{
    public TerminalPage(TerminalViewModel terminalViewModel)
    {
        InitializeComponent();
        BindingContext = terminalViewModel;
    }
}