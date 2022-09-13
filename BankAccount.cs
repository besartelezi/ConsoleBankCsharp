using System.Dynamic;

namespace a;

public class BankAccount
{
    private int id;

    public int myId
    {
        get { return id; }
        set { id = value; }
    }

    public BankAccount(int myId)
    {
        this.myId = myId;
    }

    public string tellID
    {
        
    }

}