using Blazored.Toast;
using Blazored.Toast.Services;
using PortableBlacksmith.Blazor.Services;
using PortableBlacksmith.Common.Utils;

namespace PortableBlacksmith.Blazor.Configuration
{
    public static class ServiceCollection
    {
        public async static void ConfigureInternalServices(this IServiceCollection services)
        {
            services.AddSingleton<IApiHostData>(await ApiHostDataRecieverService.GetApiHostData());

            services.AddTransient(sp => {
                var apiHostData = sp.GetRequiredService<IApiHostData>();
                return new HttpClient
                {
                    BaseAddress = new Uri($"https://{apiHostData.Host}:{apiHostData.Port}")
                };
            });
            services.AddTransient<IRESTService, RESTService>();
            services.AddTransient<IResponseService, ResponseService>();
            services.AddTransient<IToastService, ToastService>();

            services.AddBlazoredToast();


        }
    }
}
