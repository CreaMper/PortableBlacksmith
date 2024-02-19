namespace PortableBlacksmith.EF.Models
{
    public class BaseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseTypeId { get; set; }
        public BaseTypeDTO BaseType { get; set; }
    }
}
