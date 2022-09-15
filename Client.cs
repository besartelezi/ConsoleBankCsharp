namespace ConsoleBankCsharp;

public class Client
{
    //properties
    private int _id;
    private string _name;
    private string _dateJoined;

    public Client(int id, string name, string dateJoined)
    {
        _id = id;
        _name = name;
        _dateJoined = dateJoined;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string DateJoined
    {
        get => _dateJoined;
        set => _dateJoined = value ?? throw new ArgumentNullException(nameof(value));
    }
}