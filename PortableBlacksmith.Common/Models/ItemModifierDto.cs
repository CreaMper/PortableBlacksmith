using PortableBlacksmith.Common.Utils;

namespace PortableBlacksmith.Common.Models
{
    public class ItemModifierDto
    {
        public string? Name { get; set; }
        public double Value { get; set; }
        public int Tier { get; set; }
        public ModifierTypes Type { get; set; }
    }
}
