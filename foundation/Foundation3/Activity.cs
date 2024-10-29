using System;
using System.Collections.Generic;

// Base class Activity
public class Activity
{
    public DateTime Date { get; set; }
    public int LengthMinutes { get; set; }
    public Activity(DateTime date, int lengthMinutes)
    {
        Date = date;
        LengthMinutes = lengthMinutes;
    }
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => (GetDistance() / LengthMinutes) * 60;
    public virtual double GetPace() => LengthMinutes / GetDistance();
    public virtual string GetSummary() =>
        $"{Date:dd MMM yyyy} {this.GetType().Name} ({LengthMinutes} min): Distance {GetDistance():F2} km," +
        $"Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
}