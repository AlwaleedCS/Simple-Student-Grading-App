using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Student Grade Calculator ===");

        Console.Write("Enter student name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter student score (0 - 100): ");
        double score = Convert.ToDouble(Console.ReadLine());

        string grade = GetGrade(score);

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine($"Student: {name}");
        Console.WriteLine($"Score: {score}");
        Console.WriteLine($"Grade: {grade}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static string GetGrade(double score)
    {
        if (score >= 90) return "A";
        else if (score >= 80) return "B";
        else if (score >= 70) return "C";
        else if (score >= 60) return "D";
        else return "F";
    }
}
