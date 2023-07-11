using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("welcome");
            //Console.ReadKey();
            //string firstName;
            //string lastName;
            //Console.WriteLine("Eneter first name:");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Enter LastName:");
            //lastName = Console.ReadLine();
            //Console.WriteLine("Welcome MR.\\MS. " + firstName+"  " + lastName);
            //Example-3
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter grade:");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter doj:");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary:");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name: \t" + name + "\n Age: " + age + "\n Grade: "+grade + "\n doj: " +doj + "\n salary: "+salary);
            Console.ReadKey();
        }
    }
}
