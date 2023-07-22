public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private DateTime _time;
    private Address _address;

    public Event(string title, string description,  DateTime date, DateTime time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails() => 
        $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time:HH:mm}\nAddress: {_address}";

    public virtual string GetFullDetails() => GetStandardDetails();

    public string GetShortDescription() => $"Event Type: {GetType().Name}\nEvent Title: {_title}\nDate: {_date.ToShortDateString()}";
}