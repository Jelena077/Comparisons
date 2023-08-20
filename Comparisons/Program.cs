using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int a = 20, b = 15;
            result = (a > b);
            Console.WriteLine("a greater than b: " + result);
            result = (a < b);
            Console.WriteLine("a lesser than b: " + result);
            result = (a == b);
            Console.WriteLine("a equal to b: " + result);
            Console.ReadLine();

        }
    }
}
