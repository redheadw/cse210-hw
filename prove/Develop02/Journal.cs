using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    //creat the list for entries
      public Journal()
    {
        _entries = new List<Entry>();
        
    }
    //How to store the entries
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    //Display lines
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries");
            return;            
            
        }
        foreach (var entry in _entries)
        {
            entry.Display(); 
        }
        
    }
    public void SaveToFile()
    {
        string file = "C:/Users/thort/Downloads/cse 210/cse210-hw/prove/Develop02/journal.csv";
        using(StreamWriter outputFile = new StreamWriter(file))
        {            
            outputFile.WriteLine("Date,Prompt,EntryText");
            foreach(var entry in _entries)
            {
                string sanitizedEntryText = entry._entryText.Replace(",", ";");

                outputFile.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{sanitizedEntryText}\"");
            }
            Console.WriteLine($"Journal saved to {file}");

        }
    }
    public void LoadFromFile()
    {
        string file = "C:/Users/thort/Downloads/cse 210/cse210-hw/prove/Develop02/journal.csv";
       
       if (File.Exists(file))       
    
       {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        for (int i = 1; i < lines.Length; i++)
        
        {
           string[] parts = lines[i].Split(',');

           if (parts.Length >= 3)
           {
            string date = parts[0];
            string prompt = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry(date, prompt, entryText);
            _entries.Add(entry);

           }          
                    
        }      
       } 
    }
}