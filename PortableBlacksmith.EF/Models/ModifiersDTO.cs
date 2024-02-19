namespace PortableBlacksmith.EF.Models
{
    public class ModifiersDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identifier { get; set; }
        public int ModifierTierId { get; set; }
        public List<ModifierTierDTO> ModifierTier { get; set; }
    }
}
