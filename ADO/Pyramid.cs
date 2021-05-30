using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Pyramid
    {
        private readonly Point point1;
        private readonly Point point2;
        private readonly Point point3;
        private readonly Point point4;
        private readonly Point point5;

        private double volume;
        private double sq;

        public Pyramid(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point5 = point5;

            sqFun();
            volFun();
        }

        public Pyramid(Point[] points)
        {
            if (points.Length != 5)
            {
                throw new ArgumentException("Нужно 5 точек");
            }
            point1 = points[0];
            point2 = points[1];
            point3 = points[2];
            point4 = points[3];
            point5 = points[4];

            sqFun();
            volFun();
        }

        public double Volume { get => volume; }
        public double Sq { get => sq; }

        public override bool Equals(object obj)
        {
            return obj is Pyramid pyramid &&
                   EqualityComparer<Point>.Default.Equals(point1, pyramid.point1) &&
                   EqualityComparer<Point>.Default.Equals(point2, pyramid.point2) &&
                   EqualityComparer<Point>.Default.Equals(point3, pyramid.point3) &&
                   EqualityComparer<Point>.Default.Equals(point4, pyramid.point4) &&
                   EqualityComparer<Point>.Default.Equals(point5, pyramid.point5);
        }

        public override int GetHashCode()
        {
            int hashCode = -691195833;
            hashCode = hashCode * -1521134295 + EqualityComparer<Point>.Default.GetHashCode(point1);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point>.Default.GetHashCode(point2);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point>.Default.GetHashCode(point3);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point>.Default.GetHashCode(point4);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point>.Default.GetHashCode(point5);
            return hashCode;
        }

        public override string ToString()
        {
            return "pyramid: " + point1 + ", " + point2 + ", " + point3 + ", " + point4 + ", " + point5 + 
                "\nsquare osn: " + sq +
                "\nvolume: " + volume;
        }

        private void sqFun()
        {
            double p = (Point.Distance(point1, point2) + Point.Distance(point2, point3) +
                Point.Distance(point3, point4) + Point.Distance(point1, point4))/2;
            sq = Math.Sqrt(p
                * (p - Point.Distance(point1, point2))
                * (p - Point.Distance(point2, point3))
                * (p - Point.Distance(point3, point4))
                * (p - Point.Distance(point1, point4))
                );
        }

        private void volFun()
        {
            double vis= Math.Sqrt(
                (Point.Distance(point1,point5)* Point.Distance(point1, point5))
                - ((Point.Distance(point1,point3)/2)* (Point.Distance(point1, point3) / 2)));
            volume = (vis * sq) / 3;
        }
    }
}
