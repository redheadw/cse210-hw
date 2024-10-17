using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Choose an Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathinActivity breathinActivity = new BreathinActivity();
                    breathinActivity.PerformActivity();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.PerformActivity();
                    break;    
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.PerformActivity();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

}