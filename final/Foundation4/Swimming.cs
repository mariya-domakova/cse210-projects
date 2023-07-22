public class Swimming : Activity
{
    protected int _laps;

	public override string Name => "Swimming";

	public Swimming(DateTime date, double lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

	public override double GetDistance() => _laps * 50d / 1000d;

	public override double GetSpeed() => (GetDistance() / base._lengthInMins) * 60;

	public override double GetPace() => base._lengthInMins / GetDistance();
}