using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using PortableBlacksmith.EF;
using PortableBlacksmith.WebAPI.Converters;
using PortableBlacksmith.WebAPI.Services;

namespace PortableBlacksmith.WebAPI.Configuration
{
    public static class ServiceCollection
    {
        public static void ConfigureInternalServices(this IServiceCollection services)
        {
            services.AddTransient<DatabaseInitializationService>();
            services.AddTransient<IFactory, Factory>();
            services.AddTransient<IUserConverter, UserConverter>();
            services.AddTransient<ApiHostDataBroadcastService>();
            services.AddSingleton(provider =>
            {
                return provider.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>();
            });
        }
    }
}
