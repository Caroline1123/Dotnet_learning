public class BankAccount {
    private int? balance;
    private string? client;
    private string? type;

    public int? Balance {
        get {return balance; }
        set { 
            if (value < 0) {
                throw new ArgumentException("The balance may not be negative.")
            }
            balance = value;
        }
    }

    public string? Client {
        get { return client; }
        set { client = value; }
    }

    public string? Type {
        get { return type; }
        set { string[] accountTypes= {"business", "eco", "trading"};
            // bool typeExists = accountTypes.Any(t => t.Equals(value => StringComparison.OrdinalIgnoreCase));
            bool typeExists = accountTypes.Contains(value.ToLower());
            if (typeExists) {
                type = value.ToLower(); }
        }
    }

    public BankAccount(int balance, string client, string type) {
        this.Balance = balance;
        this.Client = client;
        this.Type = type;
    }

    public void CheckBalance {
        //  Do something...
    }

    public void Withdraw {
        //  Do something...
    }

    public void Deposit {
        //  Do something...
    }

}

