using PortableBlacksmith.Common.Models;
using PortableBlacksmith.EF.Models;

namespace PortableBlacksmith.WebAPI.Services
{
    public interface IBaseModifierService
    {
        ModifierDTO GetBaseModifierForBaseName(string baseName);
        bool BaseAllowed(string name);
    }
}