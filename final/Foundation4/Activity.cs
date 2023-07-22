public abstract class Activity
{
    private DateTime _date;
    protected  double _lengthInMins;

	public abstract string Name { get; }

	public Activity(DateTime date, double lengthInMins)
    {
        _date = date;
        _lengthInMins = lengthInMins;
    }

	public abstract double GetDistance();
	public abstract double GetSpeed();
	public abstract double GetPace();

	public string GetSummary() => $"{_date:dd MMM yyyy} {this.Name} ({_lengthInMins} min): " +
			$"Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
}