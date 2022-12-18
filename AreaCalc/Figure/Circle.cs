using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double radius { get; private set; }
        public double GetArea()
        {
            if (radius == 0)
                return 0;
            return Math.PI * Math.Pow(radius, 2);

        }
      
    }
}
