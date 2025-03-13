using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Binding
{
    internal class Employee
    {
        #region Properties 
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Method

        public void GetEmployeeType()
        {
            Console.WriteLine(" I am Employee");
        }

        public virtual void GetEmployeeData()
        {
            Console.Write($" Data : Id ={Id} , Name = {Name} , Age={Age} ");
        }
        #endregion


    }
}
