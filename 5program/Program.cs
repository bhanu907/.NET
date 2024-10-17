using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class student
{
    public int roll;
    public string name;
    public student(int x, string s)
    {
        roll = x;
        name = s;
    }
    public student(string s, int x)
    {
        name = s;
        roll = x;
    }
    public void show()
    {
        Console.WriteLine("RollNo:" + roll);
        Console.WriteLine("Name:" + name);
    }
}
class constructor
{
    static void Main(string[] args)
    {
        student s1 = new student(5, "thiru");
        student s2 = new student("thiru", 10);
        Console.WriteLine("First constructor");
        s1.show();
        Console.WriteLine("second constructor");
        s2.show();
        Console.ReadLine();
    }
}