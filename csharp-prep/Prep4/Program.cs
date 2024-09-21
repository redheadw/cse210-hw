using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    // Number list
    {
        List<int> numbers = new List<int>();
        int userNumber;

        Console.WriteLine("Enter a list of numbers, type O when finished: ");

        do 
        {
            Console.Write("Enter number: ");
          
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);    
        // sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
       

        // average
        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }
        //max
        int maxNumber = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }

    
            //sort
        numbers.Sort();    
        

         Console.WriteLine($"The sum is: {sum}");
         Console.WriteLine($"The average is: {average}");
         Console.WriteLine($"The largest number is: {maxNumber}");
         
         Console.WriteLine("The sorted list is.");
         foreach (int num in numbers)
         {
            Console.WriteLine(num);
         }
   
     
       
    }
}