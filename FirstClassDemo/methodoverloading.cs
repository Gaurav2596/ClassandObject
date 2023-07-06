using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassDemo
{
    internal class Methodoverloading
    {
        public int Subtraction(int a,int b) 
        { 
            return a - b;
        }
        public int Subtraction(int a,int b, int c)
        {
            return a - b - c;
        }
        public double Subtraction(double a,double b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Multiplication(int a, int b, int c)
        {
            return a * b * c;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }

    }
}
