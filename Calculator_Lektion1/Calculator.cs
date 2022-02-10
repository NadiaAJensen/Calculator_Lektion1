﻿using System;
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
        public double Sum { get; set; }
        
        public double Add(double a, double b)
        {
           Sum = a + b;

            return Sum;
        }

        public double Subract(double a, double b)
        {
            Sum = a - b;
            return Sum;
        }

        public double Multiply(double a, double b)
        {
           Sum = a * b;
            return Sum;
        }

        public double Power(double x, double exp)
        {
            Sum = Math.Pow(x,exp);
            return Sum;
        }

        //Double divide - Her skal du sørge for den ikke kan dividere med 0. - Gustav
        //{
        //}

        //Lav en property som gemmer sidste sum - Katrine

        

        public void ClearSum()
        {
            Sum = 0;
        }

        public double Squareroot(double d) //Nadia
        {
            if (d < 0)
                throw new Exception("Will not give a real number");
            Sum = Math.Sqrt(d);
            return Sum;
        }

        public double Devide(double a, double b)
        {
            if (b == 0)
                throw new Exception("Not allowed to divide by 0");
            Sum = a / b;
            return Sum;
        }

    }
}
