namespace PortableBlacksmith.EF.Models
{
    public class UserEnergyDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Current { get; set; }
        public DateTime Updated { get; set; }
    }
}
