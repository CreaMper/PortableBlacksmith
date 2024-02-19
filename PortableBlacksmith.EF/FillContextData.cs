
using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.EF
{
    public static class FillContextData
    {
        public static void FillWithData(PBDBContext context)
        {
            var defaultUser = context.User.Add(new UserDTO
            {
                Name = $"Player #{new Random().Next(1000, 9999)}",
                Wallet = new CurrencyDTO()
                {
                    Gold = 10,
                    Mithrill = 1,
                    Steel = 0,
                    Warcraftium = 0
                }
            });

            context.SaveChanges();

            context.UserEnergy.Add(new UserEnergyDTO()
            {
                Current = 10,
                Max = 100,
                Min = 0,
                UserId = defaultUser.Entity.Id,
                Updated = DateTime.UtcNow
            });

            context.SaveChanges();
        }
    }
}
