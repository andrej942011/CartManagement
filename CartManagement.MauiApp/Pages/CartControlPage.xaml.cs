using CartManagement.MauiApp.ViewModes;

namespace CartManagement.MauiApp.Pages;

public partial class CartControlPage : ContentPage
{
	public CartControlPage(CartControlViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
    }
}