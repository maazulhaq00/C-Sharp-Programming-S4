namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1

            //Console.WriteLine("Enter your first name: ");

            //string fname = Console.ReadLine();

            //Console.WriteLine("Enter your last name: ");

            //string lname = Console.ReadLine();

            //Console.WriteLine("Your name is " + fname + " " + lname);

            //Console.WriteLine("Your name is {0} {1}", fname, lname);

            //Console.WriteLine($"Your name is {fname} {lname}");

            // 2

            //string vars = "22";
            //int vari = int.Parse(vars);

            //Console.WriteLine("Enter number 1: ");

            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number 2: ");

            //int num2 = int.Parse(Console.ReadLine());

            //int result = num1 + num2;

            //Console.WriteLine($"The sum of {num1} and {num2} is {result}");

            // 3
            //Console.WriteLine("This is line 1.\nThis is line 2");
            //Console.WriteLine("Welcome class \"2410F1\"");
            //Console.WriteLine("This is Ali\'s Seat");

            // 4
            Console.WriteLine("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator (+, -, x, /): ");
            string op = Console.ReadLine();
            float result=0;

            if(op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "x")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }

            Console.WriteLine($"{num1} {op} {num2} = {result}");
        }
    }
}
