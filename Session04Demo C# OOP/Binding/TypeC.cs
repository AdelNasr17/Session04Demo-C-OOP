using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Binding
{
    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }

        public override void MyFun02()
        {
            base.MyFun02();
            Console.WriteLine($" , C={C}");

        }

        public new void MyFun01()
        {
            Console.WriteLine("I am Type C [Grad Child ]");
        }

    }
}
