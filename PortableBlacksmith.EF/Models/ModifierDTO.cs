namespace PortableBlacksmith.EF.Models
{
    public class ModifierDTO
    {
        public int Id { get; set; }
        public int ModifierTypeId { get; set; }
        public ModifierTypeDTO ModifierType { get; set; }
        public int ModifiersId { get; set; }
        public ModifiersDTO Modifiers { get; set; }
        public int Value { get; set; }
    }
}
