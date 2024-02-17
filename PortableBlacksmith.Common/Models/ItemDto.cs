﻿namespace PortableBlacksmith.Common.Models
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<ItemModifierDto>? Modifiers { get; set; }
    }
}