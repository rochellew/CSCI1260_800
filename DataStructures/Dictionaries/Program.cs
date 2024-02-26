public class Program
{
    static Dictionary<string, string> contactBook = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating Dictionaries with a Contact Book Simulation...");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1. Add contact");
            Console.WriteLine("2. Retrieve contact information");
            Console.WriteLine("3. List all contacts");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddContact();
                    break;
                case "2":
                    RetrieveContactInfo();
                    break;
                case "3":
                    ListAllContacts();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddContact()
    {
        Console.Write("\nEnter contact name: ");
        string contactName = Console.ReadLine().Trim().ToUpper();

        Console.Write("Enter contact number: ");
        string contactNumber = Console.ReadLine().Trim().ToUpper();

        // Add the contact to the dictionary
        contactBook[contactName] = contactNumber;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Contact added: " + contactName);
    }

    static void RetrieveContactInfo()
    {
        Console.Write("\nEnter contact name: ");
        string contactName = Console.ReadLine().Trim().ToUpper(); 

        if (contactBook.ContainsKey(contactName))
        {
            // Retrieve and display contact information
            string contactNumber = contactBook[contactName];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Contact Information for " + contactName + ": " + contactNumber);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Contact not found.");
        }
    }

    static void ListAllContacts()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nListing all contacts:");

        foreach (var contact in contactBook)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}");
        }
    }
}