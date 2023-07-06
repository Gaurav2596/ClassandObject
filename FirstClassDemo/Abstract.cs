using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassDemo
{
    abstract public class Shape
    {
        public abstract void CalculateArea();
    }
    public class Circle:Shape
    {
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;
        }
        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }
        public override string ToString()
        {
            return $"Area is {area}";
        }
    }
    public class Rectangle:Shape
    {
        private double l, b, area;
        public Rectangle(double l,double b)
        {
            this.l = l;
            this.b = b; 
        }
        public override void CalculateArea()
        {
            area = 2 * (l + b);

        }
        public override string ToString()
        {
            return $"Area of rectangle is {area}";
        }
    }
}
