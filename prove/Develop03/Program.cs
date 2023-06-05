using System;

namespace Develop03
{
   class Program
   {
    static void Main(string[] args)
    {
        Reference reference1 = new Reference();
        Scripture scripture_main = new Scripture(reference1, "For God so loved the world that he gave his only son");
        Word word = new Word();

        string reference_format = reference1.FormatReference();
        Console.WriteLine(reference_format);
        Console.WriteLine(scripture_main.GetSacredText());

        

        while (true)
        {
            Console.Write("Press Enter to hide words, otherwise type 'quit' to exit.");
            string response = Console.ReadLine();
            
            if (response == "quit")
            {
                Console.WriteLine("Loop ends");
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(reference_format);
                Console.WriteLine("New Scripture");
                string hidden_scripture = scripture_main.HideRandomWords();
                Console.WriteLine(hidden_scripture);

                
            }
        }
        
        


    }
   }
}