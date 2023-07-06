using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Users:BaseEntity
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserDetails UserDetails { get; set; }
        public  ICollection<User_Food_Meal> UsersMeals { get; set; }
    }
}
