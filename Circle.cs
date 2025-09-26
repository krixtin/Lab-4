using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Circle
    {
        public Circle(int radius) 
        {
            Radius = radius;
        }


        
        
        public int Radius { get; set; }
        

        public static double GetArea(int radius)
        {
            return radius * radius * Math.PI;
        }

        public static double GetCircumference(int radius)
        {
            return 2 * radius * Math.PI;
        }

        public static double GetVolume(int radius)
        {
            return (4 * Math.PI *  (radius ^ 3)) / 3;
        }

    }
}
