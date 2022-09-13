namespace a;

public class BankAccount
{
    //properties
    private string clientName;
    private int balance;
    private string type;

    //constructor
    public BankAccount(string clientName, int balance, string type)
    {
        this.clientName = clientName;
        this.balance = balance;
        this.type = type;
    }

    //getters and setters
    public string _clientName
    {
        get { return clientName; }
        set { clientName = value; }
    }

    public int _balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public string _type
    {
        get { return type; }
        set { type = value; }
    }

    //methods
    public string CheckBalance
    {
        get { return "your current balance is " + balance; }
    }

    public int Withdraw
    {
        set { balance -= value; }
    }

    public int Deposit
    {
        set { balance += value; }
    }
}