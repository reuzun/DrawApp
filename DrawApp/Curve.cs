using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DrawApp
{
    class Curve : ICloneable
    {
        public List<Point> pointList = new List<Point>();

        public void AddPoint(Point point) {
            pointList.Add(point);
        }
        public void RemovePoint(Point point) {
            pointList.Remove(point);
        }

        public void RemovePoint(int idx)
        {
            pointList.RemoveAt(idx);
        }

        public void PrintPoints() {
            Console.WriteLine("Points are shown below:");
            foreach (Point p in pointList) {
                Console.WriteLine(p);
            }
        }

        public double CurveLength() {
            int firstIndex = 1;
            double sumOfLen = 0;
            int len = this.pointList.Count;
            for (; firstIndex < len; firstIndex++) {
                sumOfLen += pointList[firstIndex] - pointList[firstIndex - 1];
            }
            return sumOfLen;
        }

        public object Clone()
        {
            Curve clone = new Curve();
            foreach (Point p in this.pointList) {
                clone.AddPoint(p);
            }
            return (Curve)clone;
        }

        public object ShallowCopy() {
            return this.MemberwiseClone();
        }

        public static bool operator >(Curve a, Curve b)
        {
            return a.CurveLength() > b.CurveLength();
        }

        public static bool operator <(Curve a, Curve b)
        {
            return !(a > b);
        }

        


    }
}
