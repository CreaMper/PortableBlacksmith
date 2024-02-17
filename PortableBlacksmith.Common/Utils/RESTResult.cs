using System.Net;

namespace PortableBlacksmith.Common.Utils
{
    public class RESTResult<T> : IRESTResult<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public Uri? RequestUri { get; set; }
        public T? Result { get; set; }
        public bool IsSuccess { get; set; }
        public string Method { get; set; }
    }
}
