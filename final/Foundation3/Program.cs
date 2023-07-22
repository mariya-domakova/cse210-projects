using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
		List<Event> events = new List<Event>();

		Lecture lecture = new Lecture("Psychology Training", "Lecture description", DateTime.Parse("01.12.2023"), DateTime.Parse("12:00"), new("4 Random St.", "New York", "NY", "USA"), "John Smith", 100);
		events.Add(lecture);

		Reception reception = new Reception("Wedding Celebration", "Reception description", DateTime.Parse("10.10.2023"), DateTime.Parse("13:00"), new("11 Wedding St.", "Salt Lake City", "UT", "USA"), "celebration@example.com");
		events.Add(reception);

		OutdoorGathering outdoorEvent = new OutdoorGathering("Charity Concert", "Outdoor activity description", DateTime.Parse("15.08.2023"), DateTime.Parse("19:00"), new("6 Concert St.", "Toronto", "ON", "Canada"), "Clear skies with a gentle breeze");
		events.Add(outdoorEvent);

		foreach (Event ev in events)
		{
			Console.WriteLine("Standard Details:");
			Console.WriteLine(ev.GetStandardDetails());

			Console.WriteLine("\nFull Details:");
			Console.WriteLine(ev.GetFullDetails());

			Console.WriteLine("\nShort Description:");
			Console.WriteLine(ev.GetShortDescription());
			Console.WriteLine("-------------------------------------------");
		}

		
	}
}