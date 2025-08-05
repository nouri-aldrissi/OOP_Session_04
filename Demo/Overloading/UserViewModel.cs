using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Overloading
{
    internal class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public static explicit operator UserViewModel(User user)
        {
            string[]? names = user?.FullName?.Split(" ");
            return new UserViewModel
            {
                Id = user.Id,
                FirstName = names?[0],
                LastName = names[1]?.Length > 1 ? names[1] : null,
                Email =user.Email,
                
            };

          

        }
    }
}
