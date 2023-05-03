using System;

namespace Learning02
{class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        job job1 = new job();
        job1._jobTitle = "Programmer";
        job1._company = "Microsoft";
        job1._startYear = 1992;
        job1._endYear = 2001;
        
        job job2 = new job();
        job2._company = "Google";
        job2._jobTitle = "Assistant Custodian";
        job2._startYear = 1920;
        job2._endYear = 2022;

        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
    }
}}