public class Running : Activity
{
    private double _distance;

	public override string Name => "Running";

	public Running(DateTime date, double lengthInMins, double distance) : base(date, lengthInMins)
	{
		_distance = distance;
	}

	public override double GetDistance() => _distance;

	public override double GetSpeed() => (_distance / base._lengthInMins) * 60;

	public override double GetPace() => base._lengthInMins / _distance;
}