/* Call by value
 * using System;
namespace ConAppParameters
{
    public class Calc
    {
        public void Increment(int num)
        {
            Console.WriteLine("value of num inside method before increment: \t" + num);
            num += 5;
            Console.WriteLine("value of num inside method after increment: \t" + num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum;
            Console.WriteLine("Enter the numebr:");
            myNum=int.Parse(Console.ReadLine());
            Console.WriteLine("My numm main before method call: \t"+myNum);
            Calc calc = new Calc();
            calc.Increment(myNum);
            Console.WriteLine("myNum in main after method call is :\t" +myNum);
            Console.ReadKey();
        }
    }
}
*/

//Call by Reference
/*using System;
namespace ConAppParameters
{
    public class Calc
    {
        public void Increment(ref int num)
        {
            Console.WriteLine("value of num inside method before increment: \t" + num);
            num += 5;
            Console.WriteLine("value of num inside method after increment: \t" + num);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum;
            Console.WriteLine("Enter the numebr:");
            myNum = int.Parse(Console.ReadLine());
            Console.WriteLine("My numm main before method call: \t" + myNum);
            Calc calc = new Calc();
            calc.Increment(ref myNum);
            Console.WriteLine("myNum in main after method call is :\t" + myNum);
            Console.ReadKey();
        }
    }
}*/

/*using System;
namespace ConAppParameters
{
    public class Calc
    {
        public void BonusCal(double salary, ref double bonus)
        {
           bonus = salary * 0.2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 50000;
            double bonus = 500;
            Calc calc = new Calc();
            calc.BonusCal(salary, ref bonus);
            Console.WriteLine($"salary:\t {salary} and bonus: {bonus}");
            Console.ReadKey();
        }
    }
}*/

//out
/*using System;

namespace ConAppParameters
{
    public class Calc
    {
        public void BonusCal(double salary, out double bonus)
        {
            bonus = salary * 0.2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 50000;
            double bonus;
            Calc calc = new Calc();
            calc.BonusCal(salary, out bonus);
            Console.WriteLine($"salary:\t {salary} and bonus: {bonus}");
            Console.ReadKey();
        }
    }
}*/

using System;

public class Calc
{
    public double Add(params double[] numbers)
    {
        double total = 0;
        foreach (double number in numbers)
        {
            total += number;
        }
        return total;

    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Calc calc = new Calc();
        Console.WriteLine("Result after adding 1,12,23.5 is=\t" + calc.Add(1, 12, 23.5));
        Console.WriteLine("Result after adding 10,12 is =\t" + calc.Add(10, 12));
        Console.ReadKey();
    }
}
