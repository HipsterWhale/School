using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction pizza = new Fraction(3, 4);
        Fraction pizza2 = new Fraction(1, 3);
        Fraction pizza3 = new Fraction(1);
        Console.WriteLine("Pizza: " + pizza.GetFractionString());
        Console.WriteLine("Pizza: " + pizza.GetDecimalValue());
        Console.WriteLine("Pizza2: " + pizza2.GetDecimalValue());
        Console.WriteLine("Pizza2: " + pizza2.GetFractionString());
        Console.WriteLine("Pizza3: " + pizza3.GetFractionString());
        Console.WriteLine("Pizza3: " + pizza3.GetDecimalValue());

        
    }
}