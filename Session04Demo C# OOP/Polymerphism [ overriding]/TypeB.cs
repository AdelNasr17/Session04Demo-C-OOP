using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Polymerphism___overriding_
{
    internal class TypeB : TypeA
    {

        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }

        // Overriding 
        // 1. Using new Keyword
        // 2. Using Override keyword [ public - virtual]
        public new void MyFun01()
        {
            Console.WriteLine("I Am Base child");
        }

        public override void MyFun02()
        {
            Console.WriteLine($" A= {A} , B= {B}");
        }



    }
}
