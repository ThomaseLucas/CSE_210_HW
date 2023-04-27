using System;


    Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
    int numberChoice = 1;//Declare the variable
    List<int> userNumInput = new List<int>();//Make the list outside of the loop so it's a global list

    while (numberChoice != 0)
    {
        Console.Write("Enter number: ");
        numberChoice = int.Parse(Console.ReadLine());
        userNumInput.Add(numberChoice);
        //Console.WriteLine(userNumInput);  
    }
    //This is how to integrate through a list using indexes.
    int sumOfNumbers = 0;
    int largestNum = int.MinValue;
    int smallestNumPos = int.MaxValue;

    foreach(int number in userNumInput)
    {
        sumOfNumbers += number;
        if (number > largestNum)
        {
            largestNum = number;
        }
        if (number > 0 && number < smallestNumPos)
        {
            smallestNumPos = number;
        }
    }
    
    if (smallestNumPos != -1)
    {
        Console.WriteLine($"The smallest positive number is: {smallestNumPos}");
    }
    else
    {
        Console.WriteLine($"There are no positive numbers.");
    }
    
    userNumInput.Sort();

    Console.WriteLine("List of numbers from lowest to highest: ");
    foreach (int number in userNumInput)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine($"This is the largest number: {largestNum}");
    Console.WriteLine($"The sum of numbers is: {sumOfNumbers}");

    double averageNumber = (double)sumOfNumbers / userNumInput.Count;
    Console.WriteLine($"The average number is: {averageNumber:F2}");