﻿namespace PortableBlacksmith.EF.Models
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public int BaseId { get; set; }
        public BaseDTO Base { get; set; }
    }
}
