using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http.Features;
using PortableBlacksmith.EF;
using PortableBlacksmith.WebAPI.Converters;
using PortableBlacksmith.WebAPI.Converters.Interface;
using PortableBlacksmith.WebAPI.Services;
using PortableBlacksmith.WebAPI.Services.Interfaces;

namespace PortableBlacksmith.WebAPI.Configuration
{
    public static class ServiceCollection
    {
        public static void ConfigureInternalServices(this IServiceCollection services)
        {
            services.AddTransient<DatabaseInitializationService>();
            services.AddTransient<IFactory, Factory>();
            services.AddTransient<IItemConverter, ItemConverter>();
            services.AddTransient<IModifierService, ModifierService>();
            services.AddTransient<IBaseModifierService, BaseModifierService>();
            services.AddTransient<ApiHostDataBroadcastService>();
            services.AddSingleton(provider =>
            {
                return provider.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>();
            });
        }
    }
}
