namespace PortableBlacksmith.EF.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WalletId { get; set; }
        public CurrencyDTO Wallet { get; set; }
    }
}
