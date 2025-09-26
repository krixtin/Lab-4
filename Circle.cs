using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Circle
    {
        public int Radius { get; set; } //property


        public Circle(int radius) //constructor that requires an integer value for Radius
        {
            Radius = radius;
        }

        //method to calculate area
        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        //method to calculate circumference
        public double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }

        //method to calculate volume
        public double GetVolume()
        {
            return (4 * Math.PI *  (Radius ^ 3)) / 3;
        }

    }
}
