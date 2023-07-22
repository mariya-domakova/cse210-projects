using System;
using System.Globalization;

class Program
{
	static void Main(string[] args)
	{
		CultureInfo.CurrentCulture = new CultureInfo("en-US");

		List<Activity> activities = new List<Activity>
		{
			new Running(DateTime.Parse("03 Nov 2023"), 30, 3),
			new Cycling(DateTime.Parse("12 Jan 2024"), 45, 20),
			new Swimming(DateTime.Parse("30 Jun 2024"), 60, 10)
		};

		foreach (var activity in activities)
		{
			Console.WriteLine(activity.GetSummary());
		}
	}
}