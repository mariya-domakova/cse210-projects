public class Cycling : Activity
{
    protected double _speed;

	public override string Name => "Cycling";

	public Cycling(DateTime date, double lengthInMins, double speed) : base(date, lengthInMins)
    {
        _speed = speed;
    }

	public override double GetDistance() => (_speed * base._lengthInMins) / 60;

	public override double GetSpeed() => _speed;

	public override double GetPace() => 60 / _speed;
}
