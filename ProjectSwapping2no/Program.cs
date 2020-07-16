using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSwapping2no
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("\nEnter 1st Number :");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nEnter 2nd Number :");
            b = Convert.ToInt16(Console.ReadLine());
            a = a + b;     
            b = a - b;     
            a = a - b;
            Console.Write("\nNumbers after swapping : \na = "+a+ "b = "+b);
            //Console.ReadLine();
        }
    }
}
