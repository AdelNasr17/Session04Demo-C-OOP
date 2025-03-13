using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos_OOP.Session04.Polymerphism___Overloading_
{
    // ViewModel : IS a Class That Represent Data That Will Be Render in View [ HTML ]
    internal class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }


        public static explicit operator UserViewModel(User user)
        {

            string[]? names = user?.FullName?.Split(" ");


            return new UserViewModel()
            {
                Id = user?.Id ?? 0,
                Email = user?.Email,
                FirstName = names?[0],
                LastName = names?.Length > 1 ? names[1] : null,

            };
        }

    }
}
