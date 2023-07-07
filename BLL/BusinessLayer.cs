using BLL.BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessLayer
	{
		public static Context _db;
		public BusinessLayer()
		{
			_db = new Context();
			Categories = new Categories_BLL();
			CategoryDetails = new CategoryDetails_BLL();
			Foods = new Foods_BLL();
			Meal = new Meal_BLL();
			User_Food_Meal = new User_Food_Meal_BLL();
			UserDetails = new UserDetails_BLL();
			Users = new Users_BLL();
		}
		public Categories_BLL Categories { get; set; }
		public CategoryDetails_BLL CategoryDetails { get; set; }
		public Foods_BLL Foods { get; set; }
		public Meal_BLL Meal { get; set; }
		public User_Food_Meal_BLL User_Food_Meal { get; set; }
		public UserDetails_BLL UserDetails { get; set; }
		public Users_BLL Users { get; set; }
	}
}
