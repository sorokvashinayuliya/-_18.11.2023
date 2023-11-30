using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_18._11._2023
{
    internal class ComplexNumbers
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }
        internal ComplexNumbers(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static ComplexNumbers operator +(ComplexNumbers a, ComplexNumbers b)
        {
            return new ComplexNumbers(a.Real+b.Real,a.Imaginary+b.Imaginary);
        }
        public static ComplexNumbers operator -(ComplexNumbers a, ComplexNumbers b)
        {
            return new ComplexNumbers(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        public static ComplexNumbers operator *(ComplexNumbers a, ComplexNumbers b)
        {
            return new ComplexNumbers((a.Real * b.Real - a.Imaginary * b.Imaginary),(a.Real * b.Imaginary - b.Real * a.Imaginary));
        }
        public static bool operator ==(ComplexNumbers a, ComplexNumbers b)
        {
            return a.Real == b.Real && a.Imaginary == b.Imaginary;
        }
        public static bool operator !=(ComplexNumbers a, ComplexNumbers b)
        {
            return a != b;
        }
        public override string ToString()
        {
            return $"{ Real}+{ Imaginary}i";
        }
    }
}
