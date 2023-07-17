using System;
using System.Collections;

namespace ConAppCollectionsCont
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*ArrsyList list = new ArrayList();
            Hashtable ht = new Hashtable();
            SortedList sortedList = new SortedList();
            Stack stack = new Stack();
            Queue queue = new Queue();*/

            /*Stack stack = new Stack();
            stack.Push("Aaman");
            stack.Push("Vijay");
            stack.Push("Zoya");
            stack.Push("Raj");
            stack.Push("Kiran");
            Console.WriteLine("No.of items in stack are: \t"+stack.Count);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After removing " + stack.Pop());
            Console.WriteLine("After removing " + stack.Pop());
            Console.WriteLine("No.of items in stack are: \t" + stack.Count);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek Example: \t"+stack.Peek());
            Console.WriteLine("after peek");
            Console.WriteLine("No.of items in stack are: \t" + stack.Count);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Clear();
            Console.WriteLine("After Clear Number of items in stack are: \t" + stack.Count);
            Console.ReadKey();*/

            Queue queue = new Queue();
            queue.Enqueue("Aaman");
            queue.Enqueue("Vijay");
            queue.Enqueue("Zoya");
            queue.Enqueue("Raj");
            queue.Enqueue("Kiran");
            Console.WriteLine("No.of items in Queue are: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After removing " + queue.Dequeue());
            Console.WriteLine("After removing " + queue.Dequeue());
            Console.WriteLine("No.of items in stack are: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek Example: \t" + queue.Peek());
            Console.WriteLine("after peek");
            Console.WriteLine("No.of items in stack are: \t" + queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Clear();
            Console.WriteLine("After Clear Number of items in stack are: \t" + queue.Count);
            Console.ReadKey();
        }
    }
}
