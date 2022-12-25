using CartManagement.Service;
using CartManagement.Service.Abstraction;

namespace CartManagement.MauiApp.Extentions
{
    public static class ServiceRegistrationExtentions
    {
        public static IServiceCollection AddBaseService(this IServiceCollection services)
        {
            return services
                .AddSingleton<ICommandService, CommandService>();
        }
    }
}
