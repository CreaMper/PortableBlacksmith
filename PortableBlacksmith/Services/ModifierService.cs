using PortableBlacksmith.WebAPI.Services.Interfaces;

namespace PortableBlacksmith.WebAPI.Services
{
    public class ModifierService : IModifierService
    {
        public int GetValueForModifierTier(string modifier, int tier)
        {
            if (modifier.Equals("IMPL_PHYS_FLAT"))
            {
                if (tier == 1) return 6;
                if (tier == 2) return 12;
                if (tier == 3) return 20;
                if (tier == 4) return 33;
                if (tier == 5) return 54;
                if (tier == 6) return 80;
                throw new ArgumentException();
            }

            if (modifier.Equals("IMPL_PHYS_TO_FIRE"))
            {
                if (tier == 1) return 1;
                if (tier == 2) return 2;
                if (tier == 3) return 4;
                if (tier == 4) return 6;
                if (tier == 5) return 8;
                if (tier == 6) return 11;
                throw new ArgumentException();
            }

            throw new ArgumentException();
        }
    }
}
