using PortableBlacksmith.Common.Models;
using PortableBlacksmith.Common.Utils;
using PortableBlacksmith.EF.Models;
using PortableBlacksmith.WebAPI.Services.Interfaces;

namespace PortableBlacksmith.WebAPI.Services
{
    public class BaseModifierService : IBaseModifierService
    {
        private readonly IModifierService _modifierService;
        public BaseModifierService( IModifierService modifierService )
        {
            _modifierService = modifierService;
        }

        public ModifierDTO GetBaseModifierForBaseName(string baseName)
        {
            if (baseName.Equals("Golden Fork"))
            {
                return new ModifierDTO()
                {
                    Name = ModList.IMPL_PHYS_FLAT,
                    Tier = 1,
                    Value = _modifierService.GetValueForModifierTier(ModList.IMPL_PHYS_FLAT, 1)
                };
            }
            else if (baseName.Equals("Empty Mug"))
            {
                return new ModifierDTO()
                {
                    Name = ModList.IMPL_PHYS_TO_FIRE,
                    Tier = 1,
                    Value = _modifierService.GetValueForModifierTier(ModList.IMPL_PHYS_TO_FIRE, 1)
                };
            }

            return null;
        }

        public bool BaseAllowed(string name)
        {
            var allowedBaseTypes = new List<string>()
            {
                "Golden Fork",
                "Empty Mug"
            };

            return allowedBaseTypes.Contains(name);
        }
    }
}
