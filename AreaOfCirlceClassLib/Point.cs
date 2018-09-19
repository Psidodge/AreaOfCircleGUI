using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCirlceClassLib
{
    public class Point
    {
        private double x, y;

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get => this.x;
            set => this.x = value;
        }
        public double Y
        {
            get => this.y;
            set => this.y = value;
        }

        public double Distance(Point point)
        {
            return Math.Sqrt(Math.Pow(this.x - point.X, 2) + Math.Pow(this.y - point.Y, 2));
        }

        public static bool operator> (Point pointLeft, Point pointRight)
        {
            if ((pointLeft.X > pointRight.X) || (pointLeft.Y > pointRight.Y))
                return true;
            return false;
        }
        public static bool operator< (Point pointLeft, Point pointRight)
        {
            if ((pointLeft.X < pointRight.X) || (pointLeft.Y < pointRight.Y))
                return true;
            return false;
        }
        //public static Point operator - (Point pointLeft, Point pointRight)
        //{
        //    return new Point(pointLeft.X - pointRight.X, pointLeft.Y - pointRight.Y);
        //}
        //public static Point operator -(Point pointLeft, double constant)
        //{
        //    return new Point(pointLeft.X - constant, pointLeft.Y - constant);
        //}
        //public static Point operator +(Point pointLeft, Point pointRight)
        //{
        //    return new Point(pointLeft.X + pointRight.X, pointLeft.Y + pointRight.Y);
        //}
        //public static Point operator +(Point pointLeft, double constant)
        //{
        //    return new Point(pointLeft.X + constant, pointLeft.Y + constant);
        //}
    }
}
