using System;
class Program
{
    static void Main()
    {
        Console.Write("Input number: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(Function(x));
    }
    static double Function(double x)
    {
        if(x > -1 && x <= 0)
        {
            return Math.Sqrt(1-Math.Pow(x , 2));
        }
        if(x > 0 && x <= 1)
        {
            return -1*Math.Sqrt(1-Math.Pow(x , 2)); 
        }
        if(x <= -1)
        {
            return Function(x + 2);
        }
        else
        {
            return Function(x - 2);
        }
    }
}
