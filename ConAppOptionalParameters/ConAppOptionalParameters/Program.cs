using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOptionalParameters
{
    public class Calc
    {
        public double Add(double num1=10,double num2 = 40,double num3  =90)
        {
            double result= num1+ num2+ num3;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine(calc.Add());
            Console.WriteLine(calc.Add(1));
            Console.WriteLine(calc.Add(1,1));
            Console.WriteLine(calc.Add(1,1,1));
            Console.ReadKey();
        }
    }
}
