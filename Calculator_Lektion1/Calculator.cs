﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
            double sum = Math.Sqrt(d);
            return sum;
        }

    }
}
