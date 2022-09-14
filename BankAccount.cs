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
    public void Withdraw()
    {
        int withdrawAmount;
        CheckBalance();
        Console.WriteLine("How much euros would you like to withdraw?");

        withdrawAmount = Convert.ToInt32(Console.ReadLine());
        balance -= withdrawAmount;

        Console.WriteLine($"You have successfully withdrawn: {withdrawAmount} euros.");
    }
    
    public void Deposit()
    {
        int depositAmount;
        CheckBalance();
        Console.WriteLine("How much euros would you like to deposit?");

        depositAmount = Convert.ToInt32(Console.ReadLine());
        balance += depositAmount;

        Console.WriteLine($"You have successfully deposited: {depositAmount} euros.");
    }
    
    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance is: {balance}");
    }
}
