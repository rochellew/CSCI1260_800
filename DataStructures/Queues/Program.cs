public class Program
{
    static Queue<string> jobs = new Queue<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating Queues with Printer Simulation...");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1. Add document to print queue");
            Console.WriteLine("2. Print document");
            Console.WriteLine("3. Job Count");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddToQueue();
                    break;
                case "2":
                    Print();
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{jobs.Count} jobs are in the queue...");
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

    static void AddToQueue()
    {
        Console.Write("Enter name of print job: ");
        string printJob = Console.ReadLine().Trim().ToUpper();

        jobs.Enqueue(printJob);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Job {printJob} added to the queue. ({jobs.Count()} jobs pending)");
    }

    static void Print()
    {
        if(jobs.Count > 0)
        {
            string currentJob = jobs.Dequeue();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Printing job {currentJob}...");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Print queue is empty. Add a job to the queue.");
        }
    }

}