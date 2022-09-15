namespace ConsoleBankCsharp;

public class BankAccount
{
    //properties
    private string _clientName;
    private int _balance;
    private string _type;

    //constructor
    public BankAccount(string clientName, int balance, string type)
    {
        _clientName = clientName;
        _balance = balance;
        _type = type;
    }

    //getters and setters
    public string ClientName
    {
        get => _clientName;
        set => _clientName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Balance
    {
        get => _balance;
        set => _balance = value;
    }

    public string Type
    {
        get => _type;
        set => _type = value ?? throw new ArgumentNullException(nameof(value));
    }

    //methods
    public void Withdraw()
    {
        //make it impossible to withdraw amount higher than current balance
        int withdrawAmount;
        Console.WriteLine("How much euros would you like to withdraw?");

        withdrawAmount = Convert.ToInt32(Console.ReadLine());
        _balance -= withdrawAmount;

        Console.WriteLine($"You have successfully withdrawn: {withdrawAmount} euros.");
        HandleBanking();
    }
    
    public void Deposit()
    {
        //make it impossible to deposit negative numbers
        int depositAmount;
        Console.WriteLine("How much euros would you like to deposit?");

        depositAmount = Convert.ToInt32(Console.ReadLine());
        _balance += depositAmount;

        Console.WriteLine($"You have successfully deposited: {depositAmount} euros.");
        HandleBanking();
    }
    
    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance is: {_balance}");
        HandleBanking();
    }

    public void CloseBanking()
    {
        Console.WriteLine($"Have a good day {_clientName}");
    }

    public void HandleBanking()
    {
        Console.WriteLine($"What would you like to do now {_clientName}? \n a. Check your balance \n b. Deposit money \n c. Withdraw money \n d. Close the banking console");
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
            CloseBanking();
        }
    }
}
