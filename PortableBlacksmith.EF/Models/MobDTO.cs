namespace PortableBlacksmith.EF.Models
{
    public class MobDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicalDefence { get; set; }
        public int MagicDefence { get; set; }
        public int MobRewardId { get; set; }
        public CurrencyDTO MobReward { get; set; }
    }
}
