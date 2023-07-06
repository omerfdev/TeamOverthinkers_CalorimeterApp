using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Meal:BaseEntity
	{
        public Meal()
        {
            UsersMeals = new HashSet<User_Food_Meal>();
        }
        public string MealName { get; set; }
		public ICollection<User_Food_Meal>? UsersMeals { get; set; }
	}
}
