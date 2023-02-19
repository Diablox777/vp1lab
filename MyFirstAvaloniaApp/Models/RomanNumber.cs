﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstAvaloniaApp.Models
{
    public class RomanNumber : ICloneable, IComparable
    {

        private ushort value;
        private string romanVal;

        private string calcRomanValue(ushort n)
        {
            char[] symb1 = new char[] { 'M', 'D', 'C', 'L', 'X', 'V' };
            char[] symb2 = new char[] { 'C', 'X', 'I' };
            string result = "";
            for (int i = 0; i < n / 1000; ++i) result += 'M';
            int t = n % 1000;
            for (int i = 100, k = 0; i > 0; i /= 10, ++k)
            {
                int x = t / i;
                if (x == 9) result = result + symb2[k] + symb1[k * 2];
                else if (x >= 5)
                {
                    result += symb1[1 + k * 2];
                    for (int j = 0; j < x - 5; ++j) result += symb2[k];
                }
                else
                {
                    if (x == 4) result = result + symb2[k] + symb1[1 + k * 2];
                    else
                    {
                        for (int j = 0; j < x; ++j) result += symb2[k];
                    }
                }
                t = t % i;
            }
            return result;
        }

        
        public RomanNumber(ushort n)
        {
            if (!(n > 0)) throw new RomanNumberException();
            value = n;
            romanVal = calcRomanValue(n);
        }

        public static RomanNumber operator +(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 == null || n2 == null) throw new ArgumentNullException();
            return new RomanNumber((ushort)(n1.value + n2.value));
        }

        
        public static RomanNumber operator -(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 == null || n2 == null) throw new ArgumentNullException();
            if (n1.value <= n2.value) throw new RomanNumberException();
            return new RomanNumber((ushort)(n1.value - n2.value));
        }
        
        public static RomanNumber operator *(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 == null || n2 == null) throw new ArgumentNullException();
            return new RomanNumber((ushort)(n1.value * n2.value));
        }
        
        public static RomanNumber operator /(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 == null || n2 == null) throw new ArgumentNullException();
            if (n2.value == 0 || ((ushort)(n1.value / n2.value)) == 0) throw new RomanNumberException();
            return new RomanNumber((ushort)(n1.value / n2.value));
        }
        
        public override string ToString()
        {
            return romanVal;
        }

        public object Clone()
        {
            return new RomanNumber(value);
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            RomanNumber another = obj as RomanNumber;

            if (another == null) throw new ArgumentException("Object is not a RomanNumber.");

            return value.CompareTo(another.value);
        }
    }

}