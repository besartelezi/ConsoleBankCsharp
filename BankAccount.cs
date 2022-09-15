using System.Reflection.Metadata;

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
        //make it impossible to withdraw amount higher than current balance
        int withdrawAmount;
        Console.WriteLine("How much euros would you like to withdraw?");

        withdrawAmount = Convert.ToInt32(Console.ReadLine());
        balance -= withdrawAmount;

        Console.WriteLine($"You have successfully withdrawn: {withdrawAmount} euros.");
        handleBanking();
    }
    
    public void Deposit()
    {
        //make it impossible to deposit negative numbers
        int depositAmount;
        Console.WriteLine("How much euros would you like to deposit?");

        depositAmount = Convert.ToInt32(Console.ReadLine());
        balance += depositAmount;

        Console.WriteLine($"You have successfully deposited: {depositAmount} euros.");
        handleBanking();
    }
    
    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance is: {balance}");
        handleBanking();
    }

    public void closeBanking()
    {
        Console.WriteLine($"Have a good day {clientName}");
    }

    public void handleBanking()
    {
        Console.WriteLine($"What would you like to do now {clientName}? \n a. Check your balance \n b. Deposit money \n c. Withdraw money \n d. Close the banking console");
        string handleBankingAnswer;
        handleBankingAnswer = Console.ReadLine();
        while (!(handleBankingAnswer == "a" || handleBankingAnswer == "b"|| handleBankingAnswer == "c" || handleBankingAnswer == "d"))
        {
            Console.WriteLine("Please pick an appropriate answer. \n a. Check your balance \n b. Deposit money \n c. Withdraw money \n d. Close the banking console");
            handleBankingAnswer = Console.ReadLine();
        }

        if (handleBankingAnswer == "a")
        {
            CheckBalance();
        }

        if (handleBankingAnswer == "b")
        {
            Deposit();
        }

        if (handleBankingAnswer == "c")
        {
            Withdraw();
        }

        if (handleBankingAnswer == "d")
        {
            closeBanking();
        }
    }
}
