using System;


Random randomGenerator = new Random();
int magicNum = randomGenerator.Next(1, 100);

string userWill = "yes";
while (userWill == "yes")
{
    Console.Write("Please enter your guess: ");
    int userNum = int.Parse(Console.ReadLine());

    int guessNumber = 0;

    while (userNum != magicNum)
    {
        if (userNum > magicNum)
        {
            Console.WriteLine("Lower");
        }
        else if (userNum < magicNum)
        {
            Console.WriteLine("Higher");
        }

        Console.Write("Please enter your guess: ");
        userNum = int.Parse(Console.ReadLine());

        guessNumber += 1;
    }

    Console.WriteLine($"You guessed it in {guessNumber} tries.");
    Console.Write("Would you like to play again?(yes/no) ");
    userWill = Console.ReadLine().ToLower();
}

Console.WriteLine("Have a nice day");

//Make sure this structure is here when creating your own project file in C#, we should always have a visable starting point in our program. 