using Blazored.Toast;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PortableBlacksmith.Blazor.Services;
using PortableBlacksmith.Common.Utils;

namespace PortableBlacksmith.Blazor.Configuration
{
    public static class ServiceCollection
    {
        public async static void ConfigureInternalServices(this WebAssemblyHostBuilder builder)
        {
            ConfigureInternalServices(builder.Services, builder);
        }

        public async static void ConfigureInternalServices(this IServiceCollection services, WebAssemblyHostBuilder builder)
        {
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            services.AddTransient<IRESTService, RESTService>();
            services.AddTransient<IResponseService, ResponseService>();
            services.AddTransient<IToastService, ToastService>();
            services.AddTransient<IApiHostData, ApiHostData>();
            services.AddMudServices();
            services.AddBlazoredToast();
        }
    }
}
