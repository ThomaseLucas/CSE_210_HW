using System;
namespace Develop04
{
class Program
{
    static void Main(string[] args)
    {
        Menu menuDisplay1 = new Menu();
        Activity activity1 = new Activity();
        Breathing breathingactivity1 = new Breathing();
        Naming namingactivity1 = new Naming();
        Ponder ponderactivity1 = new Ponder();


        while (true)
        {
            int userChoice = menuDisplay1.DisplayMenu();


            if (userChoice == 1)
            {
                breathingactivity1.AnimateSpinner();
                breathingactivity1.DisplayWelcomeMessage("breathing", "breathe in and out for a certain number of seconds in order to calm the heart and brain to have a more peaceful experience.");
                breathingactivity1.StartBreathing();
                breathingactivity1.DisplayExitMessage("breathing");
                breathingactivity1.AnimateSpinner();
            }
            else if (userChoice == 3)
            {
                namingactivity1.AnimateSpinner();
                namingactivity1.DisplayWelcomeMessage("naming", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
                namingactivity1.TakeUserList();
                namingactivity1.DisplayExitMessage("naming");
                namingactivity1.AnimateSpinner();
            }
            else if (userChoice == 2)
            {
                ponderactivity1.AnimateSpinner();
                ponderactivity1.DisplayWelcomeMessage("ponder", "reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
                ponderactivity1.AnswerPonderQuestions();
                ponderactivity1.DisplayExitMessage("ponder");
                ponderactivity1.AnimateSpinner();
            }
            else if (userChoice == 4)
            {
                
                Console.WriteLine("Thanks for spending time to stay mindfull! Have a good day!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
            }
        }
    }
}
}