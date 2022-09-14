namespace a;

public class Bank
{
    private string bankName;

    public Bank(string bankName)
    {
        this.bankName = bankName;
    }

    public string BankName
    {
        get => bankName;
        set => bankName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void Greeting()
    {
        Console.WriteLine($"Welcome to {bankName}. We have noticed you are not registered with us already, would you like to register? y/n");
    }

    public void Register()
    {
        string responseRegistration;
        responseRegistration = Console.ReadLine();
        while (!(responseRegistration == "y" || responseRegistration == "n"))
        {
            Console.WriteLine("Please use words I can understand I am but a mere computer.");
            Console.WriteLine("Do you want to register? y/n");
            responseRegistration = Console.ReadLine();
        }

        if (responseRegistration == "no" || responseRegistration == "n")
        {
            Console.WriteLine("Well go to heck buddy, we don't need you!");
            return;
        }

        if (responseRegistration == "yes" || responseRegistration == "y")
        {
            Console.WriteLine();
        }
    }
    
}