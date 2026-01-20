using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume._name = "Spencer Ehardt";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // job1.Display();
        // job2.Display();

        resume.DisplayResume();
    }
}