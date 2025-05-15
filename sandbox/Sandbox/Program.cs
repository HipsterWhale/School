using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius():f2}");

        Circle myCircle2 = new Circle();
        myCircle2.SetRadius(20);

        Cylinder myCylinder = new Cylinder();
        myCylinder.SetHeight(10);
        myCylinder.SetCircle(myCircle);
        Console.WriteLine($"{myCylinder.GetVolume()}");



    }
}