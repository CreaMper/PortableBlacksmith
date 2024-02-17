using PortableBlacksmith.Common.Utils;
using System.IO.Pipes;

namespace PortableBlacksmith.Blazor.Services
{
    public static class ApiHostDataRecieverService
    {
        public async static Task<ApiHostData> GetApiHostData()
        {
            using (var client = new NamedPipeClientStream(".", "ApiHostDataBroadcast", PipeDirection.In))
            {
                while (true)
                {
                    try
                    {
                        client.Connect(2500);
                        using (var reader = new StreamReader(client))
                        {
                            while (true) 
                            {
                                var broadcastString = await reader.ReadLineAsync();
                                if (!string.IsNullOrEmpty(broadcastString))
                                {
                                    return new ApiHostData()
                                    {
                                        Port = new Uri(broadcastString).Port.ToString(),
                                        Host = "localhost",
                                        IsHttps = false
                                    };
                                }
                                Console.WriteLine("Awaiting for host data...");
                                Thread.Sleep(500);
                            }

                        }
                    }
                    catch(TimeoutException)
                    {
                        Console.WriteLine("Unable to connect to WebAPI. Retrying...");
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine($"Error during connection to WebAPI: {ex.Message}");
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
    }
}
