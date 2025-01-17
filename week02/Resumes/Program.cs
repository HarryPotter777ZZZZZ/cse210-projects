using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        // job1 instantiation
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // job1.Display();
        // job2 instantiation
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        // job2.Display();

        // Resume instantiation
        Resume myResume = new Resume();
        myResume._name = "Harry Ushenin";
        // Add job1 and job2
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        // recommended in Learning Activity to use: myResume._jobs[0]._jobTitle.Display();
        myResume.Display();

    }
}