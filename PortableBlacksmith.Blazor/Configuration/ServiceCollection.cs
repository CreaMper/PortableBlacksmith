using PortableBlacksmith.Blazor.Data;

namespace PortableBlacksmith.Blazor.Configuration
{
    public static class ServiceCollection
    {
        public static void ConfigureInternalServices(this IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
        }
    }
}
