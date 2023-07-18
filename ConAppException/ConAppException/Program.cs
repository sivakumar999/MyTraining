using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppException
{
    public class calculation
    {
        public static byte Add(byte num1, byte num2)
        {
            var result = num1+num2;
            return (byte)result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num1, num2, result;
            try
            {
                Console.WriteLine("Enetr the first number");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                num2 = int.Parse(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine("Result after adding {0} and {1} = \t {2}",num1,num2,result);
            }
            catch(Exception ex) {
                Console.WriteLine("Error!!!"+ex.Message);

            }
            finally
            {
                Console.WriteLine("End of program!!!");
                Console.ReadKey();
            }*/





            byte fnum, snum;
            try
            {


                Console.WriteLine("enter the first num:");
                fnum = byte.Parse(Console.ReadLine());
                Console.WriteLine("enter the second num:");
                snum = byte.Parse(Console.ReadLine());
                Console.WriteLine("Result:\t " + calculation.Add(fnum, snum));
            }
            catch (FormatException fe) { Console.WriteLine("Format error"+fe.Message); }
            catch (OverflowException fe) { Console.WriteLine("Overflow error"+ fe.Message); }
            catch (Exception ex) { Console.WriteLine("Error "+ex.Message); }
            finally
            {
                Console.WriteLine("End of program");
                Console.ReadKey();
            }


        }
    }
}
