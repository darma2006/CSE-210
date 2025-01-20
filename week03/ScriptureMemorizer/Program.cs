class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his only begotten Son");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            scripture.HideRandomWords(1);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden! Memorization complete.");
                break;
            }
        }
    }
}
