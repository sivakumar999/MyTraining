using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppGenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList arrayList = new ArrayList()
            { 1,"sam",'A',DateTime.Now};
            Console.WriteLine("item \t Datatype");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item+"\t"+item.GetType());
            }
            ArrayList nameList = new ArrayList() { "raj", "ravi", "sam" };
            Console.WriteLine("name list as follows");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            nameList.Add(12);
            nameList.Add(DateTime.Now);
            Console.WriteLine("Name list as follows");
            foreach(var item in nameList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();*/

            List<string> listNames = new List<string>()
            { "sam","Ravi","Amit"};
            Console.WriteLine("**NamesList***");
            foreach (var item in listNames)
            {
                Console.WriteLine(item);
            }
            listNames.Add("Renu");
            Console.WriteLine("**Names after add on item**");
            foreach (var item in listNames)
            {
                Console.WriteLine(item);
            }
            List<int> listNumbers = new List<int>()
            { 1, 2, 3, 4
            };
            Console.WriteLine("***Numbers list****");
            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }
            listNumbers.Add(5);
            Console.WriteLine("after add ing one elemnt 5");
            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}