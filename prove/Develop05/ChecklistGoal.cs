using Newtonsoft.Json;

public class ChecklistGoal : Goal
{
	[JsonProperty]
	private List<Goal> _goalList = new List<Goal>();

	public ChecklistGoal(string name, string description, int points) : base(name, description, points)
	{
	}

	public void AddGoal(Goal goal) => _goalList.Add(goal);

	public ChecklistGoal()
	{
	}

	public override int RecordEvent()
	{
		return IsComplete() ? _points : 0;
	}

	public override bool IsComplete()
	{
		return _goalList.All(g => g.IsComplete());
	}

	internal Goal[] GetGoals()
	{
		return _goalList.ToArray();
	}
}