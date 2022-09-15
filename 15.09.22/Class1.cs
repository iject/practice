using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._09._22
{
    class Complex
    {
        public double re;
        public double im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public Complex()
        {
            this.re = 0;
            this.im = 0;
        }

        public double Re { get; set; }
        public double Im { get => im; set => im = value; }

        static public Complex add(Complex A, Complex B)
        {
            return new Complex(A.re + B.re, A.im + B.im);
        }

        public void showAlg()
        {
            Console.WriteLine("{0} + {1}i", this.re, this.im);
        }

        public double abs()
        {
            return Math.Sqrt(this.re * this.re + this.im * this.im);
        }
        public double arg()
        {
            return Math.Atan(this.im / this.re);
        }
        public void showGeom()
        {
            Console.WriteLine("{0}(*cos{1} + i * sin{1} + {1}i)", abs(), arg());
        }
      
    }
}
