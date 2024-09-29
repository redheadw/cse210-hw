using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        //working in the Journal
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            //Choices from video clip
            Console.WriteLine("\nPlease select an option");
            Console.WriteLine("\n1.Write");
            Console.WriteLine("\n2. Display");
            Console.WriteLine("\n3. Load");
            Console.WriteLine("\n4. Save");
            Console.WriteLine("\n5. Quit");
            Console.Write("What would yo like to do? ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt})");
                    Console.WriteLine("Record thought (type 'END' to finish):");
                    string entryText = "";
                    string line;
                    while ((line = Console.ReadLine()) != "END")
                    {
                        entryText += line + Environment.NewLine;
                    }
                    Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, entryText);
                    
                    journal.AddEntry(newEntry);

                    Console.WriteLine("Added");
                    break;
                    
                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    journal.LoadFromFile();
                    break;

                case "4":
                    journal.SaveToFile();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for sharing your thoughts. Goodbye");
                    break;

                default:
                    Console.WriteLine("Please select an option");
                    break;


            }
        }
        
    }
}