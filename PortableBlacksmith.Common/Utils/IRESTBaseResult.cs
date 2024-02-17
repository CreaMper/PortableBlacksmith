using System.Net;

namespace PortableBlacksmith.Common.Utils
{
    public interface IRESTBaseResult
    {
        HttpStatusCode StatusCode { get; set; }
        bool IsSuccess { get; set; }
        Uri? RequestUri { get; set; }
        string Method { get; set; }
    }
}