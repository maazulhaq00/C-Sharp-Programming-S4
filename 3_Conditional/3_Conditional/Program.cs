namespace _3_Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Purchase Amount: ");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you a premium member (yes/no): ");
            string member = Console.ReadLine();

            Console.WriteLine("Enter your city (karachi, lahore, islamabad): ");
            string city = Console.ReadLine();

            double discount = 0;
            if (member == "yes" && amount > 5000)
            {
                discount = 0.2;
                Console.WriteLine("WOW! You got 20% discount!");
            }
            else if (member == "no" && amount > 8000)
            {
                discount = 0.1;
                Console.WriteLine("Yoy! You got 10% discount!");
            }
            else if (member == "yes" || amount > 3000)
            {
                discount = 0.05;
                Console.WriteLine("Yoy! You got 5% discount!");
            }
            else
            {
                Console.WriteLine("No discount yet... Amazing to have you as a customer");
            }

            double amountAfterDiscount = amount - (discount * amount);

            int deliveryCharges = 0;

            switch (city)
            {
                case "karachi":
                    deliveryCharges = 200;
                    break;
                case "lahore":
                    deliveryCharges = 250;
                    break;
                case "islamabad":
                    deliveryCharges = 300;
                    break;
                default:
                    deliveryCharges = 500;
                    break;
            }

            double totalAmount = amountAfterDiscount + deliveryCharges;

            Console.WriteLine($"Total Amount --------------- {amount}");
            Console.WriteLine($"Discount ------------------- {discount * 100}%");
            Console.WriteLine($"Amount After Discount ------ {amountAfterDiscount}");
            Console.WriteLine($"Delievery ------------------ {deliveryCharges}");
            Console.WriteLine($"Total ---------------------- {totalAmount}");

            Console.WriteLine("Thank you for shopping!!!");
     


        }
    }
}
