using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expt13
{
    internal class A
    {
        public static void x()
        {
            Console.WriteLine("This is method x in class A");
        }
    }
    internal class B
    {
        public static void y() 
        {
            Console.WriteLine("This is method y in class B");
        }
    }
    internal class C
    {
        public static void z()
        {
            Console.WriteLine("This is method z in class C");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A.x();
            B.y();
            C.z();
            Console.ReadLine();
        }
    }
}
