namespace PortableBlacksmith.EF.Models
{
    public class ItemHasModifiersDTO
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public List<ModifierDTO>? PrefixModifiers { get; set; }
        public List<ModifierDTO>? SuffixModifiers { get; set; }
        public List<ModifierDTO>? BaseModfiers { get; set; }
    }
}
