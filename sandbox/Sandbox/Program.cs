using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");

        // Circle myCircle = new Circle();
        // myCircle.SetRadius(10);
        // Console.WriteLine($"{myCircle.GetRadius():f2}");

        // Circle myCircle2 = new Circle();
        // myCircle2.SetRadius(20);

        // Cylinder myCylinder = new Cylinder();
        // myCylinder.SetHeight(10);
        // myCylinder.SetCircle(myCircle);
        // Console.WriteLine($"{myCylinder.GetVolume()}");
        int counter = 0;
        int duration = 10; // Duration in seconds for the spinner
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 100;

        string [] spinner = { "|", "/", "-", "\\", "*", "|", "/", "-", "\\", "*" };
        Action backspace = () => Console.Write("\b"); // Figure out...it's supposed to be a stand-in for backspacing.

        while (DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(sleepTime);
            Console.Write("\b/");
            Thread.Sleep(sleepTime);
            Console.Write("\b-");
            Thread.Sleep(sleepTime);
            Console.Write("\b\\");
            Thread.Sleep(sleepTime);
            Console.Write("\b|");
            Thread.Sleep(sleepTime);
            Console.Write("\b/");
            Thread.Sleep(sleepTime);
            Console.Write("\b-");
            Thread.Sleep(sleepTime);
            Console.Write("\b\\");
            Thread.Sleep(sleepTime);
            Console.Write("\b*");
            Thread.Sleep(sleepTime);
            counter++;
            if (counter == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("\b");
                    Thread.Sleep(sleepTime / 2);
                }
                Console.Write("   "); // Clear the spinner
                Console.Write("\b\b\b"); // Move back to the start of the spinner
                counter = 0;
            }

        }
    }
}