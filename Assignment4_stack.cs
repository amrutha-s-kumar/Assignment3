using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment4_stack
    {
        static void Main(string[] args)
        {
            int top = -1;
            int[] s = new int[10];
            Console.WriteLine("Enter The Size of The Stack");
            int MAX = Convert.ToInt16(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice :");
                int ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        if (top >= MAX - 1) Console.WriteLine("... Stack Overflow ...");
                        else
                        {
                            Console.WriteLine("Enter the item :");
                            int n = int.Parse(Console.ReadLine());
                            s[++top] = n;
                        }
                        break;
                    case 2:
                        if (top == -1) Console.WriteLine(" ... Stack Underflow ...");
                        else
                        {
                            Console.WriteLine("Popped item :" + s[top--]);
                        }
                        break;
                    case 3:
                        if (top == -1) Console.WriteLine("... Stack underflow ...");
                        else
                        {
                            Console.WriteLine("Elements in the stack");
                            for (int i = top; i >= 0; i--) Console.WriteLine(s[i]);
                        }
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}
