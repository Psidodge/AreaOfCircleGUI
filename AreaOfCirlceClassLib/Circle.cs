using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCirlceClassLib
{
    public class Circle
    {
        private Point centerOfCircle;
        private double radius;

        public Circle()
        {
            this.centerOfCircle = new Point();
            this.radius = 0.0;
        }
        public Circle(int x, int y, double radius)
        {
            this.centerOfCircle = new Point(x, y);
            this.radius = radius;
        }
        public Circle(Point point, double radius)
        {
            this.centerOfCircle = point;
            this.radius = radius;
        }

        public Point GetPoint
        {
            get => this.centerOfCircle;
        }
        public double GetRadius
        {
            get => this.radius;
        }

        public double GetIntersectrionArea(Circle circle)
        {
            if(!IsIntersect(circle))
            {
                throw new NotIntersectException("Окружности не пересекаются.");
            }
            return SircleSectorArea(this, circle) + SircleSectorArea(circle, this);
        }
        public double SircleSectorArea(Circle circle1, Circle circle2)
        {
            double radius1 = circle1.GetRadius,
                   radius2 = circle2.GetRadius,
                   distance = circle1.GetPoint.Distance(circle2.GetPoint),
                   f = F(radius1, radius2, distance);

            return (Math.Pow(radius1, 2) * (f - Math.Sin(f))) / 2;
        }
        public double F(double radius1, double radius2, double distance)
        {
            double f = 2 * Math.Acos((Math.Pow(radius1, 2) - Math.Pow(radius2, 2) + Math.Pow(distance, 2)) / (2 * radius1 * distance));
            return f;
        }

        private bool IsIntersect(Circle circle)
        {
            var maxCircle = (this > circle ? this : circle);
            var minCircle = (this < circle ? this : circle);
            if ((maxCircle.GetPoint.Distance(minCircle.GetPoint) > maxCircle.GetRadius) && (maxCircle.GetPoint.Distance(minCircle.GetPoint) < maxCircle.GetRadius + minCircle.GetRadius))
                return true;
            return false;
        }

        public static bool operator >(Circle circletLeft, Circle circleRight)
        {
            if (circletLeft.GetPoint > circleRight.GetPoint)
                return true;
            return false;
        }
        public static bool operator <(Circle circletLeft, Circle circleRight)
        {
            if (circletLeft.GetPoint < circleRight.GetPoint)
                return true;
            return false;
        }
    }


    [Serializable]
    public class NotIntersectException : Exception
    {
        public NotIntersectException() { }
        public NotIntersectException(string message) : base(message) { }
        public NotIntersectException(string message, Exception inner) : base(message, inner) { }
        protected NotIntersectException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
