using System;

class Program
{
    static void Main(string[] args)
    {
        // magic number game
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 100);

        int guess = -1;
        int guessCount = 0;

        Console.WriteLine("Can you guess the number?");
        // loop
        while (guess != magicnumber)
        {
            Console.WriteLine("What is your guess? ");  
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (magicnumber > guess)
            {
                Console.WriteLine("Higher");
            } 
            else if (magicnumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine($"You guessed {guessCount} times");
        Console.Write("Do you want to play again? (yes/no):  ");
        
    Console.WriteLine("Thanks for playing!");    
        
    }
}