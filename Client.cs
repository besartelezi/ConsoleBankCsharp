namespace a;

public class Client
{
    //properties
    private int id;
    private string name;
    private string dateJoined;
    
    //constructor
    public Client(int id, string name, string dateJoined)
    {
        this.id = id;
        this.name = name;
        this.dateJoined = dateJoined;
    }
    
    //getters and setters
    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string DateJoined
    {
        get => dateJoined;
        set => dateJoined = value ?? throw new ArgumentNullException(nameof(value));
    }
}