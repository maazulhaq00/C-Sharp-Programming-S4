namespace _10_BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba1 = new BankAccount("Ahmed", 1122, 200);

            // ba1.checkBalance(2233);
            
            ba1.checkBalance(1122);
            ba1.withdaw(1122, 300);
            ba1.deposit(1122, 1000);
            ba1.withdaw(1122, 300);

        }
    }
}
