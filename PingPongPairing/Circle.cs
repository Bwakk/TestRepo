using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongPairing
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;            
        }

        public double getPerimeter()
        {
            return 2 * 3.14 * this.radius;
        }

        public double getArea()
        {
            return 3.14 * (this.radius * this.radius); 
        }
    }
}
