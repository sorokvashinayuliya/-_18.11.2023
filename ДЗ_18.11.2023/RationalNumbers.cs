using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_18._11._2023
{
    internal class RationalNumbers
    {
        private int numerator;
        private int denominator;
        public RationalNumbers(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;

        }
        public static bool operator ==(RationalNumbers left, RationalNumbers right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(RationalNumbers left, RationalNumbers right)
        {
            return !left.Equals(right);
        }
        public override bool Equals(object obj)
        {
            if (obj == null|| GetType()!=obj.GetType())
            {
                return false;
            }
            RationalNumbers number = (RationalNumbers)obj;
            return (numerator==number.numerator) && (denominator==number.denominator);
        }
        public override int GetHashCode()
        {
            return numerator.GetHashCode() ^ denominator.GetHashCode();
        }
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
    }    
}
