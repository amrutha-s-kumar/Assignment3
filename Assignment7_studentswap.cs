using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class studentSwap
    {
        public int _id;
        public string name;
        public int mark;
        public void read()
        {
            Console.WriteLine("Enter the Student id: ");
            _id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the mark: ");
            mark = int.Parse(Console.ReadLine());
        }
        public void swap(studentSwap v1, studentSwap v2)
        {
            studentSwap temp = new studentSwap();
            temp = v1;
            v1 = v2;
            v2 = temp;
            Console.WriteLine("Details After Swapping :");
            v1.display();
            v2.display();

        }
        public void display()
        {
            Console.WriteLine("Id:" + _id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Mark:" + mark);
        }
    }


    class Assignment7_studentswap
    {
        static void Main(string[] args)
        {
            studentSwap s1 = new studentSwap();
            studentSwap s2 = new studentSwap();
            s1.read();
            s2.read();
            Console.WriteLine("Details Before Swapping :");
            s1.display();
            s2.display();
            s1.swap(s1, s2);
           
            Console.ReadLine();
        }
    }
}

