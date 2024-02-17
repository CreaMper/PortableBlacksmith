using System.Net;

namespace PortableBlacksmith.Common.Utils
{
    public interface IRESTResult<T> : IRESTBaseResult
    {
        T? Result { get; set; }
    }
}