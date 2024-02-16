using PortableBlacksmith.EF;
using PortableBlacksmith.WebAPI.Converters;
using PortableBlacksmith.WebAPI.Converters.Interface;

namespace PortableBlacksmith.WebAPI.Configuration
{
    public static class ServiceCollection
    {
        public static void ConfigureInternalServices(this IServiceCollection services)
        {
            services.AddTransient<IFactory, Factory>();
            services.AddTransient<IItemConverter, ItemConverter>();
        }
    }
}
