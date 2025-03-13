using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Binding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }


        public override void MyFun02()
        {
            base.MyFun02();
            Console.Write($" , B= {B}");
        }


        public new void MyFun01()
        {
            Console.WriteLine(" I am Type B [Child]");
        }
    }
}
