using System;

namespace Learning02
{class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Programmer";
        job1._company = "Microsoft";
        job1._startYear = 1992;
        job1._endYear = 2001;
        
        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Assistant Custodian";
        job2._startYear = 1920;
        job2._endYear = 2022;

        job1.DisplyFullJobDetails();
        job2.DisplyFullJobDetails();

        Resume myResume = new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine("Die");
        Console.WriteLine(myResume._jobs);

    }
}}