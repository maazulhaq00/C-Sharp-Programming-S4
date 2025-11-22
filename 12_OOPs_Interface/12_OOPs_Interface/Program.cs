namespace _12_OOPs_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailNotification em = new EmailNotification();
            em.Send("Order placed successfully");

            SMSNotification sms = new SMSNotification();
            sms.Send("SAR for the month of November");
        }
    }
}
