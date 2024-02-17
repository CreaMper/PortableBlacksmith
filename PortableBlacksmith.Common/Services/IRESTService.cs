using PortableBlacksmith.Common.Utils;

namespace PortableBlacksmith.Blazor.Services
{
    public interface IRESTService : IDisposable
    {
        Task<IRESTResult<T>> GetAsync<T>(string endpointRoute);
    }
}