using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Binding
{
    internal class FullTimeEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }
        #endregion

        #region Constructors
        public FullTimeEmployee(int id, string name, int age, decimal salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }

        #endregion


        #region Method 

        public override void GetEmployeeData()
        {
            Console.WriteLine($" Data : Id ={Id} , Name = {Name} , Age={Age} , Salary = {Salary}"); ;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine(" I Am FullTime Employee ");
        }
        #endregion

    }
}
