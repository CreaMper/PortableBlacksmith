using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.WebAPI.Models
{
    public class UserDto
    {
        public string Name { get; set; }
        public CurrencyDto Currency { get; set; }
        public EnergyDto Energy { get; set; }
    }
}
