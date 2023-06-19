using System;
using System.Threading;

namespace Develop04
{
    class Breathing : Activity
    {
        private int _time;
        private DateTime _countdownlength;

        public void StartBreathing()
        {
            _countdownlength = PromptTime();

            while (DateTime.Now < _countdownlength)
            {
                BreatheIn();
                BreatheOut();
            }
        }
        public void CountDown()
        {
            for (_time = 5; _time > 0; _time--)
            {
                Console.Write(_time);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        public void BreatheIn()
        {
            Console.Write("Breathe in... ");
            CountDown();
            Console.Write("\n");
        }

        public void BreatheOut()
        {
            Console.Write("Breathe out... ");
            CountDown();
            Console.Write("\n");
        }

        //public string AnimateCountDown()
       // {

       // }
    }
}