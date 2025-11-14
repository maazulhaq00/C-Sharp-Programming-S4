namespace _4_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1

            //Console.WriteLine("Enter a Number: ");
            //int num = int.Parse(Console.ReadLine());

            //int i = 1;

            //while(i <= 10)
            //{
            //    Console.WriteLine($"{num} x {i} = {num * i}");
            //    i++;
            //}

            // do-while with check if value is even or odd & terminate the loop if "q" is entered
            //string terminate = "";

            //do
            //{
            //    Console.WriteLine("Enter a number: ");

            //    int num1 = int.Parse(Console.ReadLine());

            //    if(num1 % 2 == 0)
            //    {
            //        Console.WriteLine($"{num1} is an even");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num1} is an odd");
            //    }

            //    Console.WriteLine("Enter \"q\" to terminate ");

            //    terminate = Console.ReadLine();


            //} while (terminate != "q");

            // for loop nested

            //for (int i = 1; i < 3; i++)
            //{
            //    for (int j = 1; j < 4; j++)
            //    {
            //        Console.WriteLine($"i = {i}; j = {j}");
            //    }
            //}

            Console.WriteLine("Enter first Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine($"========== Table of {i} ==========");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
            }


        }
    }
}
