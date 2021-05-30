using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Validator
    {
        public void Validate(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            if (Point.IsOnOneLine(point1, point2, point3,point4,point5))
            {
                throw new ArgumentException("Точки в одной плоскости");
            }
        }
    }
}
