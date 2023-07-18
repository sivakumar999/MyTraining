using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCustomEX
{
    public class CustomException : Exception
    {
        public CustomException(string message):base(message) 
        { 

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int userAge;
                Console.WriteLine("Enter your age:");
                userAge = int.Parse(Console.ReadLine());
                if(userAge<0)
                {
                    throw new CustomException("Age must be positive number, Please enter the positive number");
                }
                else if (userAge >= 18)
                {
                    Console.WriteLine("You are eligible for voting");

                }
                else { Console.WriteLine("You are not eligible for voting, you have to wait"); }

            }
            catch (CustomException ce) { Console.WriteLine("custom error!!!"+ce.Message); }
            catch (Exception ex) { Console.WriteLine("Error"+ex.Message); }
            finally
            {
                Console.WriteLine("***Bye Bye****");
                Console.ReadKey();
            }
        }
    }
}
