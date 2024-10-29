// Derived class Cycling
public class Cycling : Activity
{
    public double SpeedKph { get; set; }
    public Cycling(DateTime date, int lengthMinutes, double speedKph) : base(date, lengthMinutes)
    {
        SpeedKph = speedKph;
    }
    public override double GetSpeed() => SpeedKph;
    public override double GetDistance() => (SpeedKph * LengthMinutes) / 60;
    

}