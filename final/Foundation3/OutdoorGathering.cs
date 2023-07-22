public class OutdoorGathering : Event
{
    private string _weatherStatement;

	public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weatherStatement)
		: base(title, description, date, time, address)
	{
		_weatherStatement = weatherStatement;
	}

	public override string GetFullDetails() => base.GetFullDetails() + $"\nWeather: {_weatherStatement}";
}