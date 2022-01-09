using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Point
    {
        public double x;
        public double y;

        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public double FindDistance(Point a) {
            return Math.Pow(Math.Pow((this.x - a.x), 2) + Math.Pow((this.y - a.y), 2), 0.5);
        }

        public static double operator - (Point a, Point b)
        {
            return a.FindDistance(b);
        }


        public override String ToString() {
            return "[" + x + ", " + y + "]";
        }
    }
}
