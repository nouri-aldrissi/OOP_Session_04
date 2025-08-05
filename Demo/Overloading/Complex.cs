﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overloading
{
    internal class Complex
    {
        #region Properties

        public int Real { get; set; }
        public int Img { get; set; }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
        #endregion
        #region Operators Overloading 


        public static Complex operator -(Complex left, Complex right)
        {
           
            return new Complex()
            {
                Real =( left?.Real??0) - ( right?.Real??0),
                Img = (left?.Img??0 )  -  (right?.Img??0)
            };
        }
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Img = C?.Img ?? 0
            };
        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Img = C?.Img ?? 0
            };
        }
        public static bool operator > (Complex left, Complex right)
        {
           if (left == right)
                return left.Img > right.Img;
           else 
                return left.Real > right.Real;

        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left == right)
                return left.Img < right.Img;
            else
                return left.Real < right.Real;

        }

        public static explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }
        public static implicit operator string(Complex C)
        {
            return C.ToString()?? string.Empty;
        }
        #endregion
    }
}
