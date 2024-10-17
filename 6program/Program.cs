using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class methodOverloading
{
    static void PrintInfo(int rollno, string name)
    {
        Console.WriteLine("rollno is{0}", rollno);
        Console.WriteLine("name is{0}", name);
    }
    static void PrintInfo(string name, int rollno)
    {
        Console.WriteLine("name is{0}", name);
        Console.WriteLine("rollno is{0}", rollno);
    }
    static void PtintInfo(string name)
    {
        Console.WriteLine("name is{0}", name);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("first method:");
        PrintInfo(15, "thiru");
        Console.WriteLine();
        Console.WriteLine("second method:");
        PrintInfo("Thiru", 15);
        Console.WriteLine();
        Console.WriteLine("third method:");
        Console.WriteLine("thiru");
        Console.ReadLine();
    }
}