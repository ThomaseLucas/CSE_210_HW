using System;
using System.Collections.Generic; 

namespace Develop02
{
    public class Prompts
    //The responsibility of this class is to store predefined prompts and output a random prompt
    {
        public List<string> promptList = new List<string>{"Who was the most interesting person you interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?","What was the worst thing that happened to you today?", "If there was one thing you could change about what you did today what would it be?", "Who made your day today?", "If you were to live in a place other than where you live, where would it be?"};

        public string GetRandomPrompt()
        {
            Random rnd = new Random();
            int randIndex = rnd.Next(promptList.Count);
            string randomPrompt = promptList[randIndex];

            return randomPrompt;
        }
    }
}

