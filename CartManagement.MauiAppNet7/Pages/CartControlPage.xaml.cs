using MauiAppNet7.ViewModes;

namespace MauiAppNet7.Pages;

public partial class CartControlPage : ContentPage
{
	public CartControlPage(CartControlViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
    }
}