using System;

class Program
{
    static async void Main(string[] args)
    {
        string scriptureText = await ScriptureLibrary.GetScripture("1 Nephi", 3, 7);
        Console.WriteLine(scriptureText);
    
    //loop
         while (true)
        {
            Console.Clear();
            Console.WriteLine(ScriptureText);

            //if (scripture.IsCompletelyHidden())
            
            //    Console.WriteLine("\nGreat job memerizing, Good bye.");
            //    break;
            
            Console.WriteLine("\nPress Enter to hide more words or type quit to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
        }   // scripture.HideRandomWords(3);
    }
}