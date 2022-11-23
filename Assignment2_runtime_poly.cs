using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class B
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("hello... Welcome to Nest Digital");
        }
    }
    // Derived Class
    public class DClass :B
    {
        public override void GetInfo()
        {
            Console.WriteLine("Learn Run time polymorphism");
        }
    }
    class Assignment2_runtime_poly
    {
        static void Main(string[] args)
        {
            DClass d = new DClass();
            d.GetInfo();
            B b = new B();
            b.GetInfo();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}

