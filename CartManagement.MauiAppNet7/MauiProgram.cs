using MauiAppNet7.Pages;
using MauiAppNet7.Service.Abstractions;
using MauiAppNet7.Services;
using MauiAppNet7.ViewModes;
using Microsoft.Extensions.Logging;

namespace MauiAppNet7
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            var services = builder.Services;

            services.AddSingleton<ICommandService, CommandService>();
            services.AddSingleton<CartControlPage>();
            services.AddSingleton<MainPage>();

            services.AddSingleton<CartControlViewModel>();

            //builder.Services.AddHostedService<RepeatingService>();

            return builder.Build();
        }
    }
}