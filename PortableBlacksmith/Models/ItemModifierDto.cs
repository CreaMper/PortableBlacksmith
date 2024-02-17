using PortableBlacksmith.WebAPI.Utils;

namespace PortableBlacksmith.WebAPI.Models
{
    public class ItemModifierDto
    {
        public string? Name { get; set; }
        public double Value { get; set; }
        public int Tier { get; set; }
        public ModifierTypes Type { get; set; }
    }
}
