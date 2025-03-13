using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Binding
{
    internal class PartTimeEmployee : Employee
    {
        #region Properties

        public decimal CountOfHours { get; set; }
        public decimal HourRate { get; set; }
        #endregion

        #region Constructors

        public PartTimeEmployee(int id, string name, int age, int countOfHours, decimal hourRate)
        {
            Id = id;
            Name = name;
            Age = age;
            HourRate = hourRate;
            CountOfHours = countOfHours;
        }
        #endregion


        #region Methods

        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($" , HourRate={HourRate} , CountOfHours = {CountOfHours}");
        }


        public new void GetEmployeeType()
        {
            Console.WriteLine(" I Am PartTime Employee ");
        }
        #endregion
    }

}
