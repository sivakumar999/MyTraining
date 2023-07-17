using System;
namespace ConAppMethods
{
    public class OurClass
    {
        //instance method
        public void Display()
        {
            Console.WriteLine("welcome to methods !!!");
        }
        //static Method
        public static void welcome()
        {
            Console.WriteLine("static method welcome you!!!");
        }
        //Methods return void & take two parameters
        public double Add(double n1, double n2)
        {
            double result;
            result = n1 + n2;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*OurClass obj = new OurClass();
            obj.Display();
            OurClass.welcome();*/
            OurClass ourClass = new OurClass();
            double num1,num2;
            Console.WriteLine("Enter the fnum:");
            num1=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Snum:");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Result after adding is: \t "+ourClass.Add(num1,num2));
            Console.ReadKey();
        }
    }
}
