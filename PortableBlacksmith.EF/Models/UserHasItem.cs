namespace PortableBlacksmith.EF.Models
{
    public class UserHasItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public int ItemId { get; set; }
        public ItemDTO Item { get; set; }
    }
}
