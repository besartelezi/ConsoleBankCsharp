namespace ConsoleBankCsharp;

public class BankAccount
{
    //properties
    private Client _client;
    private int _balance;
    private string _type;

    public BankAccount(Client client, int balance, string type)
    {
        _client = client;
        _balance = balance;
        _type = type;
    }

    public Client Client
    {
        get => _client;
        set => _client = value ?? throw new ArgumentNullException(nameof(value));
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
        int withdrawAmount;
        Console.WriteLine("How much euros would you like to withdraw?");
        withdrawAmount = Convert.ToInt32(Console.ReadLine());
        
        while (withdrawAmount > _balance)
        {
            Console.WriteLine("I'm sorry, but you can't withdraw an amount that's higher than your current balance. \n Please select a new amount you'd like to withdraw.");
            withdrawAmount = Convert.ToInt32(Console.ReadLine());
        }
        
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
        while (depositAmount <=0)
        {
            Console.WriteLine("I'm sorry, but you can't deposit an amount that's lower than or equal to zero. \n Please select a new amount you'd like to deposit.");
            depositAmount = Convert.ToInt32(Console.ReadLine());
        }
        
        _balance += depositAmount;

        Console.WriteLine($"You have successfully deposited: {depositAmount} euros.");
        HandleBanking();
    }
    
    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance is: {_balance}");
        HandleBanking();
    }

    public void CheckProfile()
    {
        Console.WriteLine($"Your name is: {Client.Name} \nYou joined on {Client.DateJoined} and your ID number is {Client.Id}");
        HandleBanking();
    }

    public void CloseBanking()
    {
        Console.WriteLine($"Have a good day {Client.Name}");
    }

    public void HandleBanking()
    {
        Console.WriteLine($"What would you like to do now {_client.Name}? \n a. Check your balance \n b. Deposit money \n c. Withdraw money \n d. Check your profile \n e. Close the banking console");
        string handleBankingAnswer;
        handleBankingAnswer = Console.ReadLine();
        while (!(handleBankingAnswer == "a" || handleBankingAnswer == "b"|| handleBankingAnswer == "c" || handleBankingAnswer == "d" || handleBankingAnswer == "e"))
        {
            Console.WriteLine("Please pick an appropriate answer. \n a. Check your balance \n b. Deposit money \n c. Withdraw money \n d. Check your profile \n e. Close the banking console");
            handleBankingAnswer = Console.ReadLine();
        }

        switch (handleBankingAnswer)
        {
            case "a":
                CheckBalance();
                break;
            case "b":
                Deposit();
                break;
            case "c":
                Withdraw();
                break;
            case "d":
                CheckProfile();
                break;
            case "e":
                CloseBanking();
                break;
        }
    }
}
