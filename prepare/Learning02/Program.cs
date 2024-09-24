using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Users name 
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        //Resume with user name
        Resume resume = new Resume(userName);

        Console.Write("How many jobs would you like to add? ");
        int jobCount = int.Parse(Console.ReadLine());

        //Loop
        for (int i = 0; i < jobCount; i++)
        {
            Console.WriteLine($"\nEntering details for job {i + 1}:");

            //company name 
            Console.Write("Enter company: ");
            string company = Console.ReadLine();

            //title
            Console.Write("Enter job title: ");
            string title = Console.ReadLine();

            Console.Write("Enter start year: ");
            int startYear = int.Parse(Console.ReadLine());

            Console.Write("Enter end year: ");
            int endYear = int.Parse(Console.ReadLine());
            
            Job job = new Job(company, title, startYear, endYear);
            resume.AddJob(job);
        }
        resume.DisplayResume();
    }
}

public class Job
{
    //parts
    public string _company;
    public string _title;
    public int _startYear;
    public int _endYear;

    public Job(string company, string title, int startYear, int endYear)
    {
        _company = company;
        _title = title;
        _startYear = startYear;
        _endYear = endYear;

    }
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
    }

}
public class Resume
{   
    private string _name;
    private List<Job> _jobs;

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}