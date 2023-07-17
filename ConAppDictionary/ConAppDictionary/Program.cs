using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This program is for dictionary example and Sortedlist,To that change the names in the syntax,Done.
            /* SortedList<int, string> students = new SortedList<int, string>()
             {
                 {45, "sam" },
                 {22, "RAvi" },
                 {3, "Raj" }
             };
             Console.WriteLine("No.of students are : " +students.Count);
             Console.WriteLine("Roll \t Name");
             foreach(var k in students.Keys)
             {
                 Console.WriteLine(k+ "\t" + students[k]);
             }
             students.Add(4, "siva");
             Console.WriteLine("Updated list");
             Console.WriteLine("Roll \t Name");
             foreach(var k in students.Keys)
             {
                 Console.WriteLine(k+ "\t" + students[k]);
             }
             Console.ReadKey();*/

            SortedList<string, string> hardwareList = new SortedList<string, string>()
            {
                {"CD", "Compact Disc" },
                {"FDD" , "Floppy disc"},
                {"Hdd", "Hard drive" },
                {"RAM", "Random access momory" }
            };
            Console.WriteLine("Short form \t Full Form");
            foreach (var k in hardwareList.Keys)
            {
                Console.WriteLine(k+ "\t" + hardwareList[k]);
            }
            Console.ReadKey();
        }
    }
}
