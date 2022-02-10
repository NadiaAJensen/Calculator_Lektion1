using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Lektion1
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double sum = a + b;

            return sum;
        }

        public double Subract(double a, double b)
        {
            double sum = a - b;
            return sum;
        }

        public double Multiply(double a, double b)
        {
            double sum = a * b;
            return sum;
        }

        public double Power(double x, double exp)
        {
            double sum = Math.Pow(x,exp);
            return sum;
        }

        //Double divide - Her skal du sørge for den ikke kan dividere med 0. - Gustav
        //{
        //}

        //Lav en property som gemmer sidste sum - Katrine

        //Metode som clear sum - Christina

        public double Squareroot(double d) //Nadia
        {
            if (d < 0)
                throw new Exception("Will not give a real number");

            double sum = Math.Sqrt(d);
            return sum;
        }

        public double Devide(double a, double b)
        {
            if (b == 0)
                throw new Exception("Not allowed to divide by 0");
            double sum = a / b;
            return sum;
        }

    }
}
