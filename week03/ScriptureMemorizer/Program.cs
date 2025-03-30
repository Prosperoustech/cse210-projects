using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture _scripture = new Scripture(1, "Corinthians", 6, 18, 20, "18. Flee fornication. Every sin that a man doeth is without the body; but he that committeth fornication sinneth against his own body.\n19. What? know ye not that your body is a temple of Holy Ghost which is in you, which ye have of God, and ye are not your own?\n20. For ye are bought with a price: therefore glorify God in yoour body, and in your spirit, which are God's.");

        Console.Clear();
        _scripture.RenderedDisplay();

        Console.WriteLine("\n\nPlease press 'enter' key to continue or type 'quit' to finish:");
        while (true)
        {
            string user_input = Console.ReadLine();
            if (user_input.ToLower() == "quit")
            {
                break;
            }
            if (!_scripture.HideWords())
            {
                break;
            }

            Console.Clear();
            _scripture.RenderedDisplay();
            Console.WriteLine("\n\nPlease press 'enter' key to continue or type 'quit' to finish:");
        }
    }
}