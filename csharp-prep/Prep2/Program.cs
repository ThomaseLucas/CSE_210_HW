using System;
//make code to give a letter grade to a student.//

Console.Write("What is your percentage grade? "); 
string percentageGrade = Console.ReadLine();
int numberPercentage = int.Parse(percentageGrade);

string letterGrade;

if (numberPercentage >= 90)
{
    letterGrade = "A";
}
else if (numberPercentage >= 80)
{
    letterGrade = "B";
}

else if (numberPercentage >= 70)
{
    letterGrade = "C";
}

else if (numberPercentage >= 60)
{
    letterGrade = "D";
}

else
{
    letterGrade = "F";
}

string letterSign;
int lastDigit = numberPercentage % 10;
if (lastDigit > 6)
{
    letterSign = "+";
}

else if (lastDigit < 3)
{
    letterSign = "-";
}

else
{
    letterSign = " ";
}

Console.WriteLine($"Your letter grade is: {letterGrade}{letterSign}");

Console.WriteLine("do a math equation");
string testFunction = Console.ReadLine();
int newNumber = int.Parse(testFunction);

int mathEquation = newNumber % 10;

Console.WriteLine(mathEquation);