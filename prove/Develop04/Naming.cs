using System;
using System.Collections.Generic;
namespace Develop04
{
    class Naming: Activity
    {
        private List<string> _prompts;

        public Naming()
        {
            _prompts = new List<string>();
        }

        public void DisplayPrompt()
        {
            Random randomint = new Random();
            

            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");

            int randomindex = randomint.Next(1, _prompts.Count);

            Console.WriteLine (_prompts[randomindex]);
        }

        public void TakeUserList()
        {
            DateTime _usertime = PromptTime();
            DisplayPrompt();
            Console.WriteLine("Now enter as many things as you can: ");
            int i = 0;
            while (DateTime.Now < _usertime)
            {
                
                Console.ReadLine();
                i++;
            }
            Console.WriteLine($"You wrote {i} things!");

        }
    }
}