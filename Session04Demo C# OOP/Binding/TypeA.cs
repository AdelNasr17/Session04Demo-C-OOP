using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Binding
{
    internal class TypeA
    {
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }


        public void MyFun01()
        {
            Console.WriteLine(" I Am type A [Base ] ");
        }

        public virtual void MyFun02()
        {
            Console.Write($"TypeA : A={A}");
        }

    }
}
