public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

	public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity)
		: base(title, description, date, time, address)
	{
		_speakerName = speaker;
		_capacity = capacity;
	}

	public override string GetFullDetails() => base.GetFullDetails() + $"\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
}