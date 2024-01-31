namespace RPGClassLibrary
{
    public class Character
    {
        protected string Name { get; set; } = string.Empty;
        protected double HP { get; set; }
        protected int AC { get; set; }
        protected int Speed { get; set; }
        protected double Damage { get; set; }

        public Character() { }

        public Character(string name, double hp, int ac, int speed, double damage)
        {
            Name = name;
            HP = hp;
            AC = ac;
            Speed = speed;
            Damage = damage;
        }

        public void Attack(Character target)
        {
            target.TakeDamage(this.Damage);
        }

        public void TakeDamage(double damage)
        {
            HP -= damage;
        }

        public override string ToString()
        {
            return
                $"""
                    Name:       {Name}
                    HP:         {HP} 
                    Defense:    {AC} 
                    Speed:      {Speed} 
                    Damage:     {Damage} 
                """;
        }
    }
}
