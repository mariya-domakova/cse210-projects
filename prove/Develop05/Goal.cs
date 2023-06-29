using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Data;


[JsonConverter(typeof(JsonSubtypes), "type")]
public class Goal
{
	[JsonProperty]
	private string type => GetType().Name;

	[JsonProperty]
	protected string _name;
	[JsonProperty]
	protected string _description;
	[JsonProperty]
	protected int _points;
	[JsonProperty]
	protected bool _isComplete;

	public Goal(string name, string description, int points)
	{
		_name = name;
		_description = description;
		_points = points;
	}

	public Goal()
	{
	}

	public void SetName(string name) => _name = name;

	public void SetDescription(string description) => _description = description;

	public void SetPoints(int points) => _points = points;

	public virtual int RecordEvent()
	{
		if (_isComplete)
			return 0;
		_isComplete = true;
		return _points;
	}

	public virtual bool IsComplete()
	{
		return _isComplete;
	}

	public override string ToString() => $"{_name} ({_description})";

	public virtual string ToStringDetailed()
	{
		string completedMessage = _isComplete ? "Goal completed" : $"Complete to get {_points} points";
		return $"{_name}\n{_description}\n{completedMessage}";
	}
}
