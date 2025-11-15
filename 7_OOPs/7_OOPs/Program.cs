namespace _7_OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value_ref_out.Run();

            Student s1 = new Student();
            s1.setStudent(1001, "Farooq Daniyal", 18, 8);
            s1.getStudentDetails();

            Student s2 = new Student();
            s2.setStudent(1002, "Arman Shabbir", 19, 9);
            s2.getStudentDetails();
        }
    }

    class Student
    {
        // properties
        int rollno;
        string name;
        int age;
        int standard;

        // method

        public void setStudent(int r, string n, int a, int s)
        {
            this.rollno = r;
            this.name = n;
            this.age = a;
            this.standard = s;
        }

        public void getStudentDetails()
        {
            Console.WriteLine($"The roll no is {this.rollno}.");
            Console.WriteLine($"The name is {this.name}.");
            Console.WriteLine($"The age is {this.age}.");
            Console.WriteLine($"The standard is {this.standard}.");
        }


    }
}
