namespace PortableBlacksmith.Common.Utils
{
    public interface IApiHostData
    {
        string? Host { get; set; }
        bool? IsHttps { get; set; }
        string? Port { get; set; }
    }
}