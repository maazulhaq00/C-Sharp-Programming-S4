namespace _11_OOPs_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment creditpay = new CreditCardPayment(123.567);

            creditpay.MakePayment();
            creditpay.ShowRecipt();

            CashPayement cashpay = new CashPayement(444.567);

            cashpay.MakePayment();
            cashpay.ShowRecipt();




            Console.WriteLine("Hello, World!");
        }
    }
}
