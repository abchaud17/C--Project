using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            b= Convert.ToDouble(Console.ReadLine());
            
            double Mult  = a * b;
            double Div = a / b;

            Console.WriteLine( "a" + "*" + "b" + "=" + Mult);
            Console.WriteLine( "a" + "*" + "b" + "=" + Div);
        }
    }
}