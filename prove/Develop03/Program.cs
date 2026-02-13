using System;

// I added a library of scriptures to randomly select one for the user
// This will change it up every time so the user can practice memorizing different scriptures
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
            scriptures.Add(new Scripture(
            new Reference("1 Nephi", 3, 7, 8),
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. " +
            "And it came to pass that when my father had heard these words he was exceedingly glad, for he knew that I had been blessed of the Lord. "
            ));

            scriptures.Add(new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life. "
            ));

            scriptures.Add(new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. " + 
                "In all thy ways acknowledge him and he shall direct thy paths. "
            ));

            scriptures.Add(new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want."
            ));

            scriptures.Add(new Scripture(
                new Reference("3 Nephi", 27, 20),
                "Now this is the commandment: Repent, all ye ends of the earth, and come unto me and be baptized in my name, that ye may be sanctified by the reception of the Holy Ghost, that ye may stand spotless before me at the last day."
            ));

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            scripture.Display();

            if (scripture.AllHidden())
            {
                break;
            }
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Good luck memorizing the scriptures!");
                break;
            }
            scripture.HideWords(3);
        }
    }
}