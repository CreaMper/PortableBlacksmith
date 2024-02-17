namespace PortableBlacksmith.WebAPI.Services.Interfaces
{
    public interface IModifierService
    {
        int GetValueForModifierTier(string modifier, int tier);
    }
}