public class Program
{
    /// <summary>
    /// The text stack, to be used in the Undo functionality of this program
    /// </summary>
    static Stack<string> textStack = new Stack<string>();

    /// <summary>
    /// The current text, updated on addition to and removal from the stack
    /// </summary>
    static string currentText = "INITIAL STRING";

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating Stacks with Undoing Text...");

        while(true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1.\tType Text");
            Console.WriteLine("2.\tUndo");
            Console.WriteLine("3.\tExit Program");
            Console.Write("Choose an option: ");

            string option = Console.ReadLine().Trim().ToUpper();

            switch(option)
            {
                case "1":
                    TypeText();
                    break;
                case "2":
                    Undo();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        static void TypeText()
        {
            Console.Write("\nEnter text: ");
            string input = Console.ReadLine().Trim().ToUpper();

            // save current text to stack before changing it
            textStack.Push(currentText);

            // update text with input
            currentText = input;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Text updated: " + currentText);
        }

        static void Undo()
        {
            if(textStack.Count > 0)
            {
                currentText = textStack.Pop();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Undo success! Text update: " + currentText);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Stack is empty...add text before trying to remove.");
            }
        }
    }
}