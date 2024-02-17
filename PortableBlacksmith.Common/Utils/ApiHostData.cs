namespace PortableBlacksmith.Common.Utils
{
    public class ApiHostData : IApiHostData
    {
        public string? Port { get; set; }
        public string? Host { get; set; }
        public bool? IsHttps { get; set; }
    }
}
