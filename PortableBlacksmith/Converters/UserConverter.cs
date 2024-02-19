using PortableBlacksmith.EF.Models;
using PortableBlacksmith.Common.Models;

namespace PortableBlacksmith.WebAPI.Converters
{
    public class UserConverter : IUserConverter
    {
        public UserDto Convert(UserDTO user, UserEnergyDTO energy)
        {
            return new UserDto()
            {
                Name = user.Name,
                Currency = new CurrencyDto()
                {
                    Gold = user.Wallet.Gold,
                    Mithrill = user.Wallet.Mithrill,
                    Steel = user.Wallet.Steel,
                    Warcraftium = user.Wallet.Warcraftium
                },
                Energy = new EnergyDto()
                {
                    Current = energy.Current,
                    Max = energy.Max,
                    Min = energy.Min,
                    Updated = energy.Updated
                }
            };
        }
    }
}
