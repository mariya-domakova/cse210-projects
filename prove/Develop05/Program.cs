using System;

class Program
{
	static void Main(string[] args)
	{
		Menu menu = Menu.AutoLoad();
		menu.DisplayMenu();
	}
}

// Exceeding Requirements:
// 1. I continued working with JSON files, but this time I added the GetType property that supports serializing polymorphic classes.
// 2. Instead of including the Load feature, I implemented an autoload feature.
// 3. I renamed the original ChecklistGoal to RepeatableGoal and introduced a new type of goal called ChecklistGoal,
// which allows the creation of multiple subgoals.
