using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Polymerphism___Overloading_
{
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Img { get; set; }

        #endregion


        public override string ToString()
        {
            return $"{Real} + {Img} i";
        }


        #region Operators Overloading 
        public static Complex operator +(Complex left, Complex right)
        {
            //Complex Result = new Complex()
            //{
            //    Real = left.Real + right.Real,
            //    Img = left.Img + right.Img
            //};
            //return Result ;

            return new Complex()
            {
                // Operator '+'  Get Evaluated  Before the Null Coalescing Operator "??"
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Img = (left?.Img ?? 0) + (right?.Img ?? 0),
            };

        }


        public static Complex operator ++(Complex c)
        {
            //return new Complex()
            //{
            //    Real = (c?.Real ??0) + 1,
            //    Img = ( c?.Img ?? 0)
            //};

            if (c is not null)
            {
                return new Complex()
                {
                    Real = c.Real + 1,
                    Img = c.Img
                };
            }
            else
            {
                return new Complex();
            }
        }

        public static bool operator >(Complex left, Complex right)
        {
            // left.Real > right.Real  ==> True 
            // left.Real < right.Real  ==>  False 
            // left.Real == right.Real  == > 
            // left.Img > right.Img ==>  true
            //  left.Img < right.Img ==>  False

            if (left?.Real == right?.Real)
                return left?.Img > right?.Img;
            else
                return left?.Real > right?.Real;

        }

        public static bool operator <(Complex left, Complex right)
        {


            if (left?.Real == right?.Real)
                return left?.Img < right?.Img;
            else
                return left?.Real < right?.Real;

        }

        public static explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }

        public static implicit operator string(Complex C)
        {
            //if (C is not null)
            //    return $"{C.Real} + {C.Img}i ";
            //else
            //    return " ";

            return C?.ToString() ?? string.Empty;
        }
        #endregion
    }
}
