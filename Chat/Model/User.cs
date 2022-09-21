using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Model
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string Role { get; set; }
        public enum UserRoles
        {
            User,
            Admin,
            None
        }

        public UserRoles UserRole
        {
            get
            {
                return Role switch
                {
                    "User" => UserRoles.User,
                    "Admin" => UserRoles.Admin,
                    _ => UserRoles.None,
                };
            }
        }

    }
}
