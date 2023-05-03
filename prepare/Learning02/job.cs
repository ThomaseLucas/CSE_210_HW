//The class for the Job will be made in this file
using System;
public class job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Disply(string companyName, string jobTitle, int beginningYear, int endingYear)
    {
        //"Job Title (Company) StartYear-EndYear", 
        //for example: "Software Engineer (Microsoft) 2019-2022".
        Console.WriteLine($"{jobTitle} ({companyName}) {beginningYear}-{endingYear}");

    }
}