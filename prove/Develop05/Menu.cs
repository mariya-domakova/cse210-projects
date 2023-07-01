using JsonSubTypes;
using Newtonsoft.Json;

public class Menu
{
    private const string FILENAME = "goals.json";
    [JsonProperty]
    private int _points;
    [JsonProperty]
    private List<Goal> _goals = new List<Goal>();

    public void DisplayMenu()
    {
        Console.WriteLine($"You have {_points} points\n");
        Console.WriteLine("Menu options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Record Event");
        Console.WriteLine(" 5. Save and Quit");
        Console.Write("Select a choice from the menu: ");
        int option = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (option)
        {
            case 1:
                _goals.Add(CreateGoal());
                DisplayMenu();
                break;
            case 2:
                Console.WriteLine("The goals are:");
                ListGoals(_goals);
                DisplayMenu();
                break;
            case 3:
                SaveGoals();
                DisplayMenu();
                break;
            case 4:
                _points += RecordEvent(_goals.ToArray());
                DisplayMenu();
                break;
            case 5:
                SaveGoals();
                return;
            default:
                Console.WriteLine($"Invalid option {option}.");
                DisplayMenu();
                break;
        }
    }

    public Goal CreateGoal(bool allowChecklist = true)
    {
        var newGoal = SelectGoalType(allowChecklist);
        SetName(newGoal);
        SetDescription(newGoal);
        SetPoints(newGoal);

        if (newGoal is RepeatableGoal repeatable)
        {
            SetRepeatableGoalProperties(repeatable);
        }

        if (newGoal is ChecklistGoal checklist)
            SetChecklistGoals(checklist);

        return newGoal;
    }

    private void SetRepeatableGoalProperties(RepeatableGoal repeatable)
    {
        Console.Write("How many times does this goal need to be accomplished? ");
        int maxCount = int.Parse(Console.ReadLine());
        repeatable.SetMaxCount(maxCount);

        Console.Write("What is the amount for accomplishing it each time? ");
        int bonusPoints = int.Parse(Console.ReadLine());
        repeatable.SetBonusPoints(bonusPoints);
    }

    private void SetChecklistGoals(ChecklistGoal checklist)
    { 
        Console.Write("You are going to create multiple subgoals. Press enter to continue");
        while (string.IsNullOrEmpty(Console.ReadLine()))
        {
            checklist.AddGoal(CreateGoal(true));
            Console.Write("Press enter to continue or type 'done' when finished ");
        }
    }

    private static void SetName(Goal newGoal)
    {
        Console.Write("What is the name of your goal? ");
        var input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        { 
            newGoal.SetName(input);
            return;
        }
        Console.WriteLine("Invalid input. Try again");
        SetName(newGoal);
    }

    private static void SetDescription(Goal newGoal)
    {
        Console.Write("What is a short description of it? ");
        var input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            newGoal.SetDescription(input);
            return;
        }
        Console.WriteLine("Invalid input. Try again");
        SetDescription(newGoal);
    }

    private static void SetPoints(Goal newGoal)
    {
        Console.Write("What is the amount of points for accomplishing this goal? ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int points))
        {
            newGoal.SetPoints(points);
            return;
        }
        Console.WriteLine("Invalid input. Try again");
        SetPoints(newGoal);
    }

    private static void SetMaxCount(RepeatableGoal newGoal)
    {
        Console.Write("How many times do you need to repeat this goal? ");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int count))
        {
            newGoal.SetMaxCount(count);
            return;
        }
        Console.WriteLine("Invalid input. Try again");
        SetMaxCount(newGoal);
    }

    private static Goal SelectGoalType(bool allowChecklist)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Repeatable Goal");
        if (allowChecklist)
            Console.WriteLine(" 4. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result <= (allowChecklist ? 4 : 3))
            return result switch
            {
                1 => new Goal(),
                2 => new EternalGoal(),
                3 => new RepeatableGoal(),
                _ => new ChecklistGoal()
            };
        else
            Console.WriteLine("Invalid input. Try again\n");

        return SelectGoalType(allowChecklist);
    }

// IList can accept both List and Array and still has indexer
    public void ListGoals(IList<Goal> goals)
	{
	    for (int i = 0; i < goals.Count; i++)
	    {
	        var isComplete = goals[i].IsComplete() ? 'X' : ' ';
	        Console.WriteLine($"{i + 1}. [{isComplete}] {goals[i]}");

			if (goals[i] is ChecklistGoal checklist)
            {
                foreach (var subgoal in checklist.GetGoals())
                {
					var isCompleteSub = subgoal.IsComplete() ? 'X' : ' ';
					Console.WriteLine($"\t[{isCompleteSub}] {subgoal}");
				}
            }
		}
	}

	public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(FILENAME))
        {
            outputFile.Write(Newtonsoft.Json.JsonConvert.SerializeObject(this));
        }
    }

    public static Menu AutoLoad()
    {
        if (!File.Exists(FILENAME)) 
            return new Menu();

        var lines = System.IO.File.ReadAllText(FILENAME);
        var deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<Menu>(lines);
        return deserialized;
    }

    public int RecordEvent(IList<Goal> goals)
    {
        Console.WriteLine("Which goal did you accomplish? ");
        ListGoals(goals);
        var input = Console.ReadLine();
        if (int.TryParse(input, out int selection) && selection > 0 && selection <= goals.Count)
        {
            var goal = goals[selection - 1];
            var bonusPoints = 0;
			if (goal is ChecklistGoal checklist)
            {
				bonusPoints = RecordEvent(checklist.GetGoals());
            }
            
            return goal.RecordEvent() + bonusPoints;
        }
        Console.WriteLine("Invalid input. Try again");
        return RecordEvent(goals);
    }
}