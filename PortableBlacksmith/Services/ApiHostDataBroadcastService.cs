using Microsoft.AspNetCore.Hosting.Server.Features;
using System.IO.Pipes;

namespace PortableBlacksmith.WebAPI.Services
{
    public class ApiHostDataBroadcastService
    {
        private readonly IServerAddressesFeature _serverAddresses;

        public ApiHostDataBroadcastService(IServerAddressesFeature serverAddresses)
        {
            _serverAddresses = serverAddresses;
        }

        public async Task Start()
        {
            using (var server = new NamedPipeServerStream("ApiHostDataBroadcast", PipeDirection.Out))
            {
                await server.WaitForConnectionAsync();
                using (var writer = new StreamWriter(server))
                {
                    var address = _serverAddresses.Addresses.FirstOrDefault();
                    writer.WriteLine(address);
                }
            }
        }
    }
}
