using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_details_2
{
    class student
    {
        internal void studentinfo(int id, string name)
        {
            Console.WriteLine("student id is" + id);
            Console.WriteLine("student name is" + name);
        }
        internal void results(int m1, int m2,int m3)
        {
            Console.WriteLine("m1 marks: " + m1);
            Console.WriteLine("m2 marks: " + m2);
            Console.WriteLine("m3 marks: " + m3);
            int total = m1 + m2 + m3;
            Console.WriteLine("total marks are: " + total);
            int avg = total / 3;
            Console.WriteLine("average is: " + avg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student obj = new student();
            Console.WriteLine("enter student id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter student name");
            string name = Console.ReadLine();
            obj.studentinfo(id, name);
            Console.WriteLine("enter m1 marks");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter m2 marks");
            int m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter m3 marks");
            int m3 = int.Parse(Console.ReadLine());
            obj.results(m1, m2, m3);
        }
    }
}
