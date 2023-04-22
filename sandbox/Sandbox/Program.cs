//Make code to introduce the user as just like James Bond.//

Console.WriteLine("What is your first name? ");
string f_name = Console.ReadLine();

Console.WriteLine("What is your last name? ");
string l_name = Console.ReadLine();

Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}.");

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