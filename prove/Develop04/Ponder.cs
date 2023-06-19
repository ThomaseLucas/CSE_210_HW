using System;
using System.Collections.Generic;

namespace Develop04
{
    class Ponder: Activity
    {
        List<string> _questions;
        List<string> _ponderprompts;

        public Ponder()
        {
            _questions = new List<string>();
            _ponderprompts = new List<string>();
        }

        public void DisplayPonderQuestion()
        {
            _questions.Add("Think of a time when you stood up for someone else.");
            _questions.Add("Think of a time when you did something really difficult.");
            _questions.Add("Think of a time when you helped someone in need.");
            _questions.Add("Think of a time when you did something truly selfless.");
            Random random = new Random();
            int randomindex = random.Next(1, _questions.Count);
            Console.WriteLine(_questions[randomindex]);
        }

        public void AnswerPonderQuestions()
        {
            
            DateTime _usertime = PromptTime();
            _ponderprompts.Add("Why was this experience meaningful to you?");
            _ponderprompts.Add("Have you ever done anything like this before?");
            _ponderprompts.Add("How did you get started?");
            _ponderprompts.Add("How did you feel when it was complete?");
            _ponderprompts.Add("What made this time different than other times when you were not as successful?");
            _ponderprompts.Add("What is your favorite thing about this experience?");
            _ponderprompts.Add("What could you learn from this experience that applies to other situations?");
            _ponderprompts.Add("What did you learn about yourself through this experience?");
            
            
            DisplayPonderQuestion();
            while(DateTime.Now < _usertime)
            {
                Random random = new Random();
                int randomindex = random.Next(1, _ponderprompts.Count);
                Console.WriteLine(_ponderprompts[randomindex]);
                Console.ReadLine();
            }

        }
    }
}