using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEnum
{
    internal class Program
    {
        public enum DayofWeek
        {
            Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday
        }
        static void Main(string[] args)
        {
            DayofWeek today = DayofWeek.Wednesday;
            Console.WriteLine("Day:"+today);
            Console.WriteLine("Day Number " + (int)today);
            Console.ReadKey();
        }
    }
}
