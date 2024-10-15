using System;

class Program
{
    static void Main(string[] args)
    {
       // Test MathAssignment//
       MathAssignment mathAssignment = new MathAssignment("Gwyn Wright", "Fractions", "5.02", "6-17");
       Console.WriteLine(mathAssignment.GetSummary());
       Console.WriteLine(mathAssignment.GetHomeworkList());

       // Test WritingAssingment
       WritingAssignment writingAssignment = new WritingAssignment("Gwyn Wright", "Programing with Classes", "Inheritance");
       Console.WriteLine(writingAssignment.GetSummary());
       Console.WriteLine(writingAssignment.GetWritingInformation()); 
    }
}