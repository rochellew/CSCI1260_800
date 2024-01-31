namespace RPGClassLibrary
{
    public class Player : Character, IKillable
    {
        public List<Item>? Inventory { get; set; } 
        public int Level { get; set; }

        public Player() : base()
        {
            Inventory = new List<Item>();
            Level = 0;
        }

        public Player(string name, double hp, int ac, int speed, double damage, List<Item> inventory, int level) : base(name, hp, ac, speed, damage)
        {
            Inventory = inventory;
            Level = level;
        }

        // We HAVE TO implement this because we are using the 
        // IKillable interface.
        public string DyingWords(string message)
        {
            if (HP <= 0) return $"The hero's last words were: {message}";
            else return $"It's not your time, hero.";
        }

        public override string ToString()
        {
            return
                $"""
                {base.ToString()}
                    Inventory:  {string.Join(',', Inventory.Select(x => x.ToString()))}
                    Level:      {Level}
                """;
        }
    }
}
