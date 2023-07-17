using System;

namespace Develop05
{
    public abstract class Goal
    {
        private string _goalName;
        private bool _completed; 

        void MarkComplete()
        {
            
        }

        int CalculatePoints()
        {
            return 1;
        }

        public int ChooseGoal()
        {
            Console.WriteLine("Which type of goal would you like to create?");
            Console.WriteLine("  1. Simple");
            Console.WriteLine("  2. Checklist");
            Console.WriteLine("  3. Eternal");
            string goalChoice = Console.ReadLine();
            int goalChoiceInt = int.Parse(goalChoice);

            return goalChoiceInt;

            
        }


        public abstract void SetGoal();
    }


}