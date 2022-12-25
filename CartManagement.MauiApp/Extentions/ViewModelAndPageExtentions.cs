using CartManagement.MauiApp.Pages;
using CartManagement.MauiApp.ViewModes;

namespace CartManagement.MauiApp.Extentions
{
    public static class ViewModelAndPageExtentions
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            return services
                .AddSingleton<CartControlViewModel>()
                .AddSingleton<TerminalViewModel>();
        }

        public static IServiceCollection AddPages(this IServiceCollection services)
        {
            return services
                .AddSingleton<MainPage>()
                .AddSingleton<CartControlPage>()
                .AddSingleton<SettingsPage>()
                .AddSingleton<TerminalPage>(); ;
        }
    }
}
