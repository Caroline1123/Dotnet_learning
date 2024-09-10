public class BankAccount {
    private int balance;
    private Client accountClient;
    private string type;

    public int Balance {
        get {return balance; }
    }

    public Client AccountClient{
        get { return accountClient; }
        set { accountClient = value; }
    }

    public string Type {
        get { return type; }
        set { string[] accountTypes= {"business", "eco", "trading"};
            bool typeExists = accountTypes.Contains(value.ToLower());
            if (typeExists) {
                type = value.ToLower(); }
        }
    }

    public BankAccount(int balance, Client client, string type) {
        this.balance = balance;
        this.AccountClient = client;
        this.Type = type;
    }

    public void CheckBalance()
    {
        Console.WriteLine($"{this.AccountClient.Name} currently has {this.Balance} EUR to their account.");
    }

    public void Withdraw(int amount) 
    {
        if (this.balance >= amount)
        {
            this.balance -= amount;
        }
        else
        {
            throw new ArgumentException("Balance may not be negative.");
        }
    }

    public void Deposit(int amount)
    {
        this.balance += amount;
    }

}

