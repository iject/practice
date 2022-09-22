using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _22._09._22
{
    internal class tocki
    {
        private double x;
        private double y;
        private double z;

        public double X { get; set;}
        public double Y { get; set;}
        public double Z { get; set;}

        public tocki()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public tocki(double x,double y,double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static double dist(tocki A, tocki B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }

        public double dist_to_zero (tocki A)
        {
            return dist(A, new tocki(0, 0, 0));
        }

        public vector(tocki A, tocki B)
        {

        }
    }
}
