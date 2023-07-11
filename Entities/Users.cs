using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Users:BaseEntity
	{
        public Users()
        {
			UsersMeals = new HashSet<User_Food_Meal>();
		}
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
		public bool IsAdmin { get; set; }
		public bool IsActive { get; set; }
		[NotMapped]
		public string FullName { get => FirstName + " " + LastName; }
		public UserDetails? UserDetails { get; set; }
        public  ICollection<User_Food_Meal>? UsersMeals { get; set; }
    }
}
