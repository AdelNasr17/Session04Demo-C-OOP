using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Binding
{
    internal class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int a, int b, int c, int d) : base(a, b, c)
        {
            D = d;
        }

        public new void MyFun02()
        {
            Console.WriteLine($" TypeD : A={A} , B = {B} , C = {C} , D={D}");
        }

        public new void MyFun01()
        {
            Console.WriteLine(" I Am Type D [ Child Grand Child ]");

        }


    }
}
