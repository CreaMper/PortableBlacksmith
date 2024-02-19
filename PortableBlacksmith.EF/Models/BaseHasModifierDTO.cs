namespace PortableBlacksmith.EF.Models
{
    public class BaseHasModifierDTO
    {
        public int Id { get; set; }
        public int BaseId { get; set; }
        public BaseDTO Base { get; set; }
        public int ModifierId { get; set; }
        public ModifierDTO Modifier { get; set; }
    }
}
