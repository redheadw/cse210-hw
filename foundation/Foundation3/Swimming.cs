//Derived class swimming
public class Swimming : Activity
{
    public int Laps { get; set; }
    private const double LapDistanceKm = 50 / 1000.0;
    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        Laps = laps;
    }
    public override double GetDistance() => Laps * LapDistanceKm;
   
}