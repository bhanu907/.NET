using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class car
{
    private static string manufacturer;
    private string model;
    private int year;
    static car()
    {
        manufacturer = "Toyota";
        Console.WriteLine("static constructor called manufacturer:" + manufacturer);
    }
    private car()
    {
        model = "corolla";
        year = 2020;
        Console.WriteLine("private constructor called model:" + model + ",year:" + year);
    }
    public car(string model, int year)
    {
        this.model = model;
        this.year = year;
        Console.WriteLine("Instance constructor called model:" + this.model + ",year:" + this.year);
    }
    public static car createDefaultcar()
    {
        return new car();
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Car details:{manufacturer},{model},year:{year}");
    }
}
public class program
{
    static void Main(string[] args)
    {
        car car1 = new car("camry", 2022);
        car1.DisplayDetails();
        car defaultcar = car.createDefaultcar();
        defaultcar.DisplayDetails();
        Console.ReadLine();
    }
}