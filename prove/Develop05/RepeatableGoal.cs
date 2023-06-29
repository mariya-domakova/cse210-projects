using JsonSubTypes;
using Newtonsoft.Json;

public class RepeatableGoal : Goal
{

	[JsonProperty]
	private int _count;
	[JsonProperty]
	private int _maxCount;
	[JsonProperty]
	private int _bonusPoints;

	public RepeatableGoal()
	{
	}

	public void SetMaxCount(int maxCount) => _maxCount = maxCount;

	public void SetBonusPoints(int bonusPoints) => _bonusPoints = bonusPoints;


	public RepeatableGoal(string name, string description, int points) : base(name, description, points)
	{
	}

	public override int RecordEvent()
	{
		if (_count == _maxCount)
			return 0;
		_count++;
		return _bonusPoints + (_count == _maxCount ? base.RecordEvent() : 0);
	}

	public override string ToString()
	{
		return $"{_name} ({_description}) -- Currently completed: {_count}/{_maxCount}";
	}

	public override string ToStringDetailed()
	{
		string completedMessage = _isComplete ? "Goal completed" : $"Complete to get {_points} points";
		return $"{_name} {_count}/{_maxCount}\n{_description}\n{completedMessage}";
	}
}