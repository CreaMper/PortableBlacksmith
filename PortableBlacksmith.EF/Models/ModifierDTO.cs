using System.ComponentModel.DataAnnotations.Schema;

namespace PortableBlacksmith.EF.Models
{
    public class ModifierDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Value { get; set; }
        public int? Tier { get; set; }

        public int? PrefixModifierId { get; set; }
        public ItemHasModifiersDTO? PrefixModifier { get; set; }

        public int? SuffixModifierId { get; set; }
        public ItemHasModifiersDTO? SuffixModifier { get; set; }

        public int? BaseModifierId { get; set; }
        public ItemHasModifiersDTO? BaseModifier { get; set; }
    }
}
