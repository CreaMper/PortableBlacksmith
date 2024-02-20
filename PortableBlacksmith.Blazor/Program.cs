using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PortableBlacksmith.Blazor.Configuration;

namespace PortableBlacksmith.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.ConfigureInternalServices();
            await builder.Build().RunAsync();
        }
    }
}