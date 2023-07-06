using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Foods:BaseEntity
	{
        public Foods()
        {
            UsersMeals=new HashSet<User_Food_Meal>();
        }
        public string FoodName { get; set; }
		public int CategoryID { get; set; }
		public decimal CarbonHydrateValue { get; set; }
		public decimal ProteinValue { get; set; }
		public decimal FatValue { get; set; }
		public decimal Calories { get; set; }
		public string? FoodImagePath { get; set; }
		public string? FoodDescription { get; set; }
        public Categories? Category { get; set; }
		public ICollection<User_Food_Meal>? UsersMeals { get; set; }

	}

}
