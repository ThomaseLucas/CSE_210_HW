using System;

namespace Develop05
{
    public class Checklist: Goal
    {
        public Checklist()
        {
        }

        public override void SetGoal()
        {
            Console.WriteLine("This is where the user will set goals that have multiple completions");
        }
    }
}