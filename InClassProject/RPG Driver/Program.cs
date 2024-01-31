using RPGClassLibrary;

public class Program
{
    private static List<Player> players = new List<Player>();
    private static List<Enemy> enemies = new List<Enemy>();

    public static void Main(string[] arg)
    {
        Seed();

        Console.WriteLine("Players in the Competition");
        Console.WriteLine("==================================");
        foreach (var p in players)
        {
            Console.WriteLine(p);
            Console.WriteLine("-----------------------------");
        }

        Console.WriteLine("Enemies in the Competition");
        Console.WriteLine("==================================");
        foreach(var e in enemies)
        {
            Console.WriteLine(e);
            Console.WriteLine("-----------------------------");
        }
    }

    public static void Seed()
    {
        // var is NOT NOT NOT NOT NOT NOT NOT NOT NOT NOT
        // NOT NOT NOT NOT NOT NOT NOT NOT NOT A DATA TYPE
        List<Item> zorosBag = new List<Item>()
        {
            new Item("Sword", ItemType.Weapon),
            new Item("Sword", ItemType.Weapon),
            new Item("Sword", ItemType.Weapon)
        };

        List<Item> zekesBag = new List<Item>()
        {
            new Item("Sword", ItemType.Weapon),
            new Item("Shield", ItemType.Weapon),
            new Item("Max Health Potion", ItemType.Potion)
        };

        List<Item> vampireDrops = new List<Item>()
        {
            new Item("Fancy Cape", ItemType.Armor),
            new Item("Fake Teeth", ItemType.Weapon)
        };

        List<Item> mummyDrops = new List<Item>()
        {
            new Item("Ankh", ItemType.Armor),
            new Item("Sarcophagus Lid", ItemType.Weapon),
            new Item("Mummified P***s", ItemType.Weapon)
        };

        players.Add(new Player("Roronoa Zoro", 666, 50, 999, 400, zorosBag, 99));
        players.Add(new Player("Zeke Jaeger", 1, 12, 34, 544, zekesBag, 13));

        enemies.Add(new Enemy("Vlad the Impaler", 10000, 15, 250000, 999999, vampireDrops, 10));        
        enemies.Add(new Enemy("Amumu", 100000000, 99999, 1, 50, mummyDrops, 3));
    }
}
