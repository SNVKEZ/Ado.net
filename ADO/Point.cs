using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Point
    {
        private readonly double x;
        private readonly double y;
        private readonly double z;

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point(Point point)
        {
            x = point.X;
            y = point.Y;
            z = point.Z;
        }

        public double X { get => x; }
        public double Y { get => y; }
        public double Z { get => z; }

        public static double Distance(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2) 
                + Math.Pow(second.Z - first.Z, 2));
        }


        

        public static bool IsOnOneLine(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            if (((point1.X==point2.X) && (point2.X==point3.X) && (point3.X==point4.X) && (point4.X==point5.X)) &&
                ((point1.Y == point2.Y) && (point2.Y == point3.Y) && (point3.Y == point4.Y) && (point4.Y == point5.Y)) &&
                ((point1.Z == point2.Z) && (point2.Z == point3.Z) && (point3.Z == point4.Z) && (point4.Z == point5.Z)) 

                    )
                return false;
            else
                return true;
        }

        public override string ToString()
        {
            return "(" + x + ", " + y +", " + z + ")";
        }

        public override bool Equals(object obj)
        {
            return obj is Point point &&
                   x == point.x &&
                   y == point.y &&
                   z == point.z &&
                   X == point.X &&
                   Y == point.Y &&
                   Z == point.Z;
        }

        public override int GetHashCode()
        {
            int hashCode = -624234986;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            hashCode = hashCode * -1521134295 + z.GetHashCode();
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + Z.GetHashCode();
            return hashCode;
        }
    }
}
