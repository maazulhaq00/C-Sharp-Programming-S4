namespace _2_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 2;
            //int remainder = a % b;
            //Console.WriteLine($"Remainder is {remainder}");
            //// int q = a++;
            //// int q = ++a;
            //Console.WriteLine($"a++ = {a++} "); // 5
            //Console.WriteLine(a); // 6

            //Console.WriteLine($"b-- = {b--} "); // 2
            //Console.WriteLine(b); // 1

            //int x = 13;
            //int y = 4;
            //Console.WriteLine(x += 2);  // x = x + 2 --> 15
            //Console.WriteLine(x += y);  // x = x + y --> 19
            //Console.WriteLine(y /= 2);  // y = y / 2 --> 2

            //Console.WriteLine(2 == 2); // T
            //Console.WriteLine(2 != 2); // F
            //Console.WriteLine(4 == 9); // F
            //Console.WriteLine(13 > 100); // F
            //Console.WriteLine(13 <= 100); // T
            //Console.WriteLine(100 < 100); // F

            Console.WriteLine("Enter Purchase Amount: ");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you a premium member (yes/no): ");
            string member = Console.ReadLine();

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

        }
    }
}
