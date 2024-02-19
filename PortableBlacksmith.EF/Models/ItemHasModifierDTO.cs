namespace PortableBlacksmith.EF.Models
{
    public class ItemHasModifierDTO
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public ItemDTO Item { get; set; }
        public int ModifierId { get; set; }
        public ModifierDTO Modifier { get; set; }
    }
}
