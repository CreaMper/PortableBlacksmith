using PortableBlacksmith.EF.Models;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Converters
{
    public interface IUserConverter
    {
        UserDto Convert(UserDTO user, UserEnergyDTO energy);
    }
}