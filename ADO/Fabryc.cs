using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Fabryc
    {
        private static readonly Validator pyrValidator = new Validator();

        public static Pyramid CreatePyramid(double point1X, double point1Y, double point1Z,
            double point2X, double point2Y, double point2Z,
            double point3X, double point3Y, double point3Z,
            double point4X, double point4Y, double point4Z,
            double point5X, double point5Y, double point5Z)
        {
           pyrValidator.Validate(new Point(point1X, point1Y, point1Z),
                new Point(point2X, point2Y, point2Z),
                new Point(point3X, point3Y, point3Z),
                new Point(point4X, point4Y, point4Z),
                new Point(point5X, point5Y, point5Z)
                );
            return new Pyramid(new Point(point1X, point1Y, point1Z),
                new Point(point2X, point2Y, point2Z),
                new Point(point3X, point3Y, point3Z),
                new Point(point4X, point4Y, point4Z),
                new Point(point5X, point5Y, point5Z)
                );
        }

        public static Pyramid CreatePyramid(String fileName)
        {
            char[] delimiterChars = { ' ', '\n' };
            string temp;
            Point[] points = new Point[5];
            using (StreamReader input = new StreamReader(fileName))
            {
                temp = input.ReadToEnd();
            }
            string[] info = temp.Split(delimiterChars);
            if (info.Length != 10)
            {
                throw new ArgumentException("The file must have 6 variables");
            }
            for (int i = 0; i < info.Length / 2; i++)
            {
                points[i] = new Point(double.Parse(info[i * 2]), 
                    double.Parse(info[i * 2 + 1]),
                    double.Parse(info[i * 2 + 2]));
            }
            pyrValidator.Validate(points[0], points[1], points[2],points[3],points[4]);
            return new Pyramid(points);
        }
    }
}
