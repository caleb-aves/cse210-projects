using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Congratulations, you get an 'A' grade.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Congratulacions, you get a 'B' grade.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you get a 'C' grade.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("You get a 'D' grade.");
        }
        else
        {
            Console.WriteLine("Sorry, you get an 'F' grade.");
        }
    }
}