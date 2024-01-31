namespace RPGClassLibrary
{
    public class Item
    {
        public string? Name { get; set; }
        public ItemType Type { get; set; }

        /// <summary>
        /// No-Arg Constructor
        /// </summary>
        public Item()
        {
            Name = string.Empty;
            Type = ItemType.Weapon;
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="type">Type of item (of ItemType value)</param>
        public Item(string name, ItemType type)
        {
            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name} ({Type})";
        }
    }
}
