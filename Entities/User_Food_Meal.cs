using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class User_Food_Meal:BaseEntity
	{
        public int UserID { get; set; }
        public int FoodID { get; set; }
        public int MealID { get; set; }
        public decimal Amount { get; set; }
        public DateTime MealDate { get; set; }

    }
}
