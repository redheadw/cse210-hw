// Derived class Running
public class Running : Activity
{
    public double DistanceKm { get; set; }
    public Running(DateTime date, int lengthMinutes, double distanceKm) : base(date, lengthMinutes)
    {
        DistanceKm = distanceKm;
    }
    public override double GetDistance() => DistanceKm;
    
}