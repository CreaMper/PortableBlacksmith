using PortableBlacksmith.EF.Models;
using PortableBlacksmith.WebAPI.Models;

namespace PortableBlacksmith.WebAPI.Converters
{
    public interface IUserConverter
    {
        UserDto Convert(UserDTO user, UserEnergyDTO energy);
    }
}