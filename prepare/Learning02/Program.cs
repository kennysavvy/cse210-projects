using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Intern";
        job1._startYear = 2016;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._company = "Lasalu Limited";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2017;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Eze Kenneth Nwangele";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobs();

        Console.WriteLine();
        

    }
}