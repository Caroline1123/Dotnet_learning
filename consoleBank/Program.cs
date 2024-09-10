public class Program {
    public static void Main()
    {
        BankAccount bankAccount = new BankAccount(100, new Client("Paolo"), "business");
        bankAccount.CheckBalance();
    }
}