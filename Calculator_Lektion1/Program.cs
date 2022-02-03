using System;

namespace Calculator_Lektion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator C = new Calculator();

            Console.WriteLine("Add: " + C.Add(5,15));
            Console.WriteLine("Subtract: " + C.Subract(6,3));
            Console.WriteLine("Multiply: " + C.Multiply(6,8));
            Console.WriteLine("Power: " + C.Power(5,2));

        }
    }
}
