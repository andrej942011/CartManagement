using System.Diagnostics;
using MauiAppNet7.Pages;

namespace MauiAppNet7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            Debug.WriteLine("ttt");
        }

        private async void ToCarControl_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartControlPage());
        }

        private async void ToCarControlSettings_OnClicked_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
    }
}