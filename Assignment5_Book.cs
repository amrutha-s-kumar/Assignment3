using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
     class Assignment5_Book
    {

       
            private int Bookno;
            private string Title;
            private float Price;

            public void input()
            {
                Console.Write("Enter Book No: ");
                Bookno = int.Parse(Console.ReadLine());
                Console.Write("Enter Book Title: ");
                Title = Console.ReadLine();
                Console.Write("Enter Price: ");
                Price = int.Parse(Console.ReadLine());
            }

            private float Totalcost(int n)
            {
                return Price * n;
            }

            public void purchase()
            {
                Console.Write("Enter the number of copies  purchased: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Total cost paid: {0}", Totalcost(n));
            }

            public void display()
            {
                Console.WriteLine("Book No: {0}", Bookno);
                Console.WriteLine("Book Title: {0}", Title);
                Console.WriteLine("Price: {0}", Price);
            }

            static void Main(string[] args)
            {
                Assignment5_Book b = new Assignment5_Book();
                b.input();
                b.purchase();
                b.display();
                Console.ReadLine();
            }
       }
}
