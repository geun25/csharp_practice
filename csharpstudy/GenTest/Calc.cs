using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenTest
{
    class Calc
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int Substract(int a, int b)
        {
            int result = a - b;
            return result;
        }

        public int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public int Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }
    }

    class DoubleCalc
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Substract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Divide(double a, double b)
        {
            double result = a / b;
            return result;
        }
    }
}
