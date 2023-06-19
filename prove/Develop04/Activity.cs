using System;
using System.Threading;
using System.Collections.Generic;

namespace Develop04
{
    class Activity
    {  
        private int _usertime;

        public DateTime PromptTime()
        {
            Console.Write("How long, in seconds, do you need for your session? ");
            string amountoftime = Console.ReadLine();
            _usertime = int.Parse(amountoftime);
            DateTime endtime = DateTime.Now.AddSeconds(_usertime);
            Console.Write("\n");
            return endtime; 
        }

        public void AnimateSpinner()
        {
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(3);
            int i = 0;
            

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");            
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");

            while (DateTime.Now < endTime)
            {
                string l = animationStrings[i];
                Console.Write(l);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                i++;

                if (i >= animationStrings.Count)
                {
                    i = 1;
                }
            }



            // Console.Clear();
            // string fowardslash = "\\";
            // while (true)
            // {
            // Console.Write("/");
            
            // Thread.Sleep(500);
            // Console.Write("\b \b");
            // Console.Write("-");
            
            // Thread.Sleep(500);
            // Console.Write("\b \b");
            // Console.Write(fowardslash);
            
            // Thread.Sleep(500);
            // Console.Write("\b \b");
            // Console.Write("|");
            
            // Thread.Sleep(500);
            // Console.Write("\b \b");


            
        }

        public void DisplayWelcomeMessage(string typeOfActivity, string activityDescription)
        {
            Console.WriteLine($"Welcome to the {typeOfActivity} activity. In this activity you will {activityDescription}");
            Console.Write("\n");
        }

        public void DisplayExitMessage(string typeOfActivity)
        {
            Console.Write("\n");
            Console.WriteLine($"Thank you for using the {typeOfActivity} activity. Have a good day!");
            Thread.Sleep(1500);
            Console.Clear();
            
        }
        
    }
}