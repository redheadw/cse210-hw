using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        //What is your letter grade?
        Console.Write("Enter number grade: ");
        string valuefromUser = Console.ReadLine();
        int x = int.Parse(valuefromUser);
        
        string letter = "";
        if (x >= 90)
        {
            letter = "A"; 
        }
        
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        

        if (x >= 70)
        {
            Console.WriteLine("Congradulation you pass!");
        }
        else 
        {
            Console.WriteLine("How can we help you improve your grade?");
        }

        // Stretch Challenge
        string sign= "";
        int lastDigit = x % 10;

        if (lastDigit > 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else 
        {
            sign = " ";
        }
        Console.WriteLine($"Your grade is: {letter} {sign}");
    }

}