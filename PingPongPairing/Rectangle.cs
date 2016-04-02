using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongPairing
{
    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double getPerimeter()
        {
            return this.length + this.length + this.width + this.width;
        }

        public double getArea()
        {
            return this.width * this.length;
        }
    }
}
