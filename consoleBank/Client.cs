public class Client {
    private int clientId;
    private string name;
    private DateTime dateJoined;

    static int nextId = 0;

    public int ClientId
    {
        get { return clientId; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public DateTime DateJoined
    {
        get { return dateJoined; }
    }

    public Client(string name) 
    { 
        this.clientId = Interlocked.Increment(ref nextId);
        this.Name = name;
        this.dateJoined = DateTime.Now;
    }
}