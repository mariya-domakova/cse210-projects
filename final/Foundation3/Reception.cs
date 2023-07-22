public class Reception : Event
{
    private string _rsvpEmail;

	public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail)
		: base(title, description, date, time, address)
	{
		_rsvpEmail = rsvpEmail;
	}

	public override string GetFullDetails() => base.GetFullDetails() + $"\nRSVP Email: {_rsvpEmail}";
}