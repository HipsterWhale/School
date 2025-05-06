using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle = "Software Engineer";
        job2._jobTitle = "Mechatronics Engineer";
        job1._company = "Alta Trust Company";
        job2._company = "Zooks";
        job1._startYear = 2025;
        job2._startYear = 2019;
        job1._endYear = 2025;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Peter Piper";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}