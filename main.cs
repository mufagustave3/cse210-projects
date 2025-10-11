public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                newEntry._prompt = prompt;
                newEntry._response = response;

                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("Enter a filename to save your journal: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load your journal: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye! Keep writing your story. 😊");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
