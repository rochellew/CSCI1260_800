namespace RPGClassLibrary
{
    public class Enemy : Character, IKillable
    {
        public List<Item>? Drops { get; set; }
        public int Challenge { get; set; }

        public Enemy() : base()
        {
            Drops = new List<Item>();
            Challenge = 0;
        }

        public Enemy(string name, double hp, int ac, int speed, double damage, List<Item> drops, int challenge) : base(name, hp, ac, speed, damage)
        {
            Drops = drops;
            Challenge = challenge;
        }

        // We HAVE TO implement this because we are using the 
        // IKillable interface.
        public string DyingWords(string message)
        {
            return $"The creature croaks out feebly: {message}";
        }
    }
}
