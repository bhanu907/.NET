using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;
            double result;
            Console.WriteLine("\t Welcome to .Net Programming");
            Console.WriteLine("Addition = {0}", a + b); ;
            Console.WriteLine("Subtraction = {0}", a - b);
            Console.WriteLine("Multiplication ={0}", a * b);
            result = (double)a / b;
            Console.WriteLine("Division = {0}", result);
            Console.ReadLine();
        }
    }
}
