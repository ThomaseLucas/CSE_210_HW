using System;
using System.Collections.Generic;
using System.IO;
namespace Develop02

{
class Program
{
    static void Main(string[] args)
    {
        Prompts randomPrompt = new Prompts();
        string promptRand = randomPrompt.GetRandomPrompt();
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            
            string userChoice = Console.ReadLine();
            int userChoiceNum = int.Parse(userChoice);

            if (userChoiceNum == 1)
            {
                //This is where the magic happens for writing a new entry and storing it into a an entry
                Entry myEntry = new Entry();
                myEntry.prompt = randomPrompt.GetRandomPrompt();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                myEntry.date = dateText;
                Console.WriteLine($"{myEntry.date}");

                Console.WriteLine(myEntry.prompt);
                myEntry.response = Console.ReadLine();


                myEntry.Hold($"{myEntry.prompt}", $"{myEntry.response}", $"{myEntry.date}");

                journal.AddEntry(myEntry);
            }  
            else if (userChoiceNum == 2)
            {
                //This is where it will display to the user what the entry says
                
                List<Entry> entries = journal.GetAllEntries();
                foreach (Entry entry in entries)
                {
                    string message = entry.ConvertToString();
                    Console.WriteLine(message);
                }
            }
            else if (userChoiceNum == 3)
            //This is where it will load a past entry
            {
                Console.Write("Please enter the name of the file to load: ");
                string userFile = Console.ReadLine();
                string fileName = userFile;

                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(";");
                        if (fields.Length >= 3)
                           {
                                Entry loadedEntry = new Entry();
                                loadedEntry.prompt = fields[0];
                                loadedEntry.response = fields[1];
                                loadedEntry.date = fields[2];

                                journal.AddEntry(loadedEntry);
                            } 
                    }

                    Console.WriteLine("Entries loaded successfully");
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
                
            }
            else if (userChoiceNum == 4)
            {
                //This is where it will save the file into a text document
                Console.Write("Please enter the name of your file: ");
                string userFile = Console.ReadLine();
                string fileName = @"C:\Users\thoma\Desktop\Programming with classes\CSE_210_HW\prove\Develop02\cool.txt";

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    List<Entry> entries = journal.GetAllEntries();
                    foreach (Entry entry in entries)
                    {
                        outputFile.WriteLine(entry.ConvertToString());
                    }
                }
            }
            else if (userChoiceNum == 5)
            {
                Console.Write("Please enter a date (MM/DD/YYYY): ");
                    string searchDateText = Console.ReadLine();
                    DateTime searchDate = DateTime.Parse(searchDateText);
                    List<Entry> entries = journal.GetEntriesByDate(searchDate);
                    foreach (Entry entry in entries)
                    {
                        string message = entry.ConvertToString();
                        Console.WriteLine(message);
                    }
            }
            else if (userChoiceNum == 6)
            {
                break;
            }



        }
    }
}
}

