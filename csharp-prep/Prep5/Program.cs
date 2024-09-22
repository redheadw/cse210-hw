using System;

class Program
{
    static void Main()
    {
        //Functions
        DisplayWelcome(); 
        string userName = PromptName();
        int userNumber = PromptNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }



    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptNumber()
    {
        Console.Write("Please enter you favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square ;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }
    


}