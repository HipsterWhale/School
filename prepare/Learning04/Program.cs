using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Assignment class
        Assignment assignment = new Assignment("John Doe", "Mathematics");
        Console.WriteLine(assignment.GetSummary());

        // Create an instance of the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Jane Smith", "Algebra", "Section 5.2", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}