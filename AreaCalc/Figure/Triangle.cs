using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            if (a + b > c) //Проверка на сущестовование треугольника
            {
                if (a > c)
                {
                    double i;
                    i = a;
                    a = c;
                    c = i;
                }
                if (b > c)
                {
                    double i;
                    i = b;
                    b = c;
                    c = i;
                } 

                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                this.a = 0;
                this.b = 0;
                this.c = 0;
            }
            Rectangular = false;
            if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2)) // проверка на прямоугольность
            {
                Rectangular = true;
            }

        }
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }
        private double p { get; set; }
        public bool Rectangular { get; private set; }
        public double GetArea()
        {

            if (a == 0 || b == 0 || c == 0)
            {
                return 0;
            }
            p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }
    }
}
