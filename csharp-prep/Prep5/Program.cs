using System;
//Use static in front of all of your standalone functions

/*
DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.
*/

static void DisplayWelcome()
{
    Console.WriteLine("Welcome to the Program!");
}

static string PromptUserName()
{
    Console.Write("Enter your name: ");
    string userName = Console.ReadLine();

    return userName;
}

static int PromptUserNumber()
{
    Console.Write("Please enter your favorite number: ");
    int userNum = int.Parse(Console.ReadLine());

    return userNum;
}

static int SquareNumber(int originalNum)
{
    int numSquared = originalNum * originalNum;
    return numSquared;
}

static void DisplayResult(string endNum, string endName)
{
    Console.WriteLine($"Your name is {endName} and the square number is {endNum}");
}

static void main()
{
    DisplayWelcome();
    string finalName = PromptUserName();
    int finalNum = PromptUserNumber();
    int numSquared = SquareNumber(finalNum);
    DisplayResult(numSquared.ToString(), finalName);
}

main();