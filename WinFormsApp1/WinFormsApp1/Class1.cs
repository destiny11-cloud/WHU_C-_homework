using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface ISuc
    {
        bool judge();
    }
    public abstract class Figure
    {
        protected double measure;
        public abstract double Area { get; }
        public Figure(double m)
        {
            measure = m;
        }

    }
    public class Rectangle : Figure,ISuc
    {
        bool ISuc.judge() {
            if (this.measure > 0 && this.width > 0) return true;
            else return false;
        }
        public Rectangle(double m, double width) : base(m)
        {
            this.width = width;
        }
        private double width;
        public override double Area
        {
            get
            {
                return width * measure;
            }
        }
        public double getL()
        {
            return this.measure;
        }
        public double getW()
        {
            return this.width;
        }
    }
    public class Square : Figure,ISuc
    {
        bool ISuc.judge()
        {
            if (this.measure > 0) return true;
            else return false;
        }
        public Square(double m) : base(m) { }
        public override double Area
        {
            get
            {
                return measure * measure;
            }
        }
        public double getS()
        {
            return this.measure;
        }
    }
    public class Triangle : Figure,ISuc
    {
        bool ISuc.judge()
        {
            if ((this.measure + this.length1 > this.length2) && (this.length2 + this.length1 > this.measure) && (this.measure + this.length2 > this.length1) && this.measure > 0 && this.length1 > 0 && this.length2 > 0) return true;
            else return false;
        }
        public Triangle(double m, double l1, double l2) : base(m)
        {
            length1 = l1;
            length2 = l2;

        }
        private double length1;
        private double length2;
        public override double Area
        {
            get
            {
                double p = (measure + length1 + length2) / 2;

                return Math.Sqrt(p * (p - measure) * (p - length1) * (p - length2));
            }
        }
        public double getM()
        {
            return this.measure;
        }
        public double getL1()
        {
            return this.length1;
        }
        public double getL2()
        {
            return this.length2;
        }
    }
}
