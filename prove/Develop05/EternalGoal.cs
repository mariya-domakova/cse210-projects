using Newtonsoft.Json;

public class EternalGoal : Goal
{
	[JsonProperty]
	private DateTime _lastRecorded;

	public EternalGoal(string name, string description, int points) : base(name, description, points)
	{
	}

	public EternalGoal()
	{
	}

	public override int RecordEvent()
	{
		_lastRecorded = DateTime.Now;
		return _points;
	}

	public override bool IsComplete()
	{
		return _lastRecorded.Date.Equals(DateTime.Now.Date);
	}

	public override string ToStringDetailed()
	{
		string completedMessage = _isComplete ? "Goal completed today" : $"Complete to get {_points} points";
		return $"{_name}\n{_description}\n{completedMessage}";
	}
}