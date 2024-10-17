using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Dog
{
    public virtual void eat()
    {
        Console.WriteLine("Dog is eating");
    }
}
public class cat : Dog
{
    public override void eat()
    {
        Console.WriteLine("cat is eating");
    }
}
public class MethodOverriding
{
    public static void Main(string[] args)
    {
     cat obj= new cat();
        obj.eat();
        Console.ReadLine();
    }
}
