using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ConAppStruct
{
    public struct Student
    {
        int id;
        string name;
            public Student(int _id,string _name)
        {
            *//*this.id = id;
            this.name = name;*//*
            id = _id;
            name = _name;
        }
        public void Display()
        {
            Console.WriteLine($"Student ID: {id} \t Student Name: {name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(12, "Raj");
            student.Display();
            Student student1 = new Student(13, "siva");
            student1.Display();
            Console.ReadKey();
        }
    }
}
*/



namespace StructExample
{
    public struct Rectangle
    {
        public int width;
        public int height;

        public void Area()
        {
            int area = height * width;
            Console.WriteLine($"Area of Rectangle {height} * {width} = {area}");
        }
    }
    public class MyClass
    {
        public static void Main()
        {
            Rectangle rect;
            Console.WriteLine("Enter the Height:");
            rect.height=int.Parse( Console.ReadLine() );
            Console.WriteLine("Enter the Width:");
            rect.width = int.Parse(Console.ReadLine());
            rect.Area();
            Console.ReadKey();
        }
    }
}








