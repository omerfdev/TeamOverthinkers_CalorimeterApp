using Entities;

namespace BLL.BLL
{
	public class Meal_BLL : ICRUD<Meal>
	{
		public void Add(Meal entity)
		{
			BusinessLayer._db.MealTable.Add(entity);
			BusinessLayer._db.SaveChanges();
		}

		public void Delete(Meal entity)
		{
			BusinessLayer._db.MealTable.Remove(Search(entity.ID));
			BusinessLayer._db.SaveChanges();
		}

		public List<Meal> GetAll()
		{
			return BusinessLayer._db.MealTable.ToList();
		}

		public Meal Search(int id)
		{
			return BusinessLayer._db.MealTable.Find(id);
		}

		public void Update(Meal entity)
		{
			Meal meal = Search(entity.ID);
			BusinessLayer._db.Entry<Meal>(meal).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			meal.MealName = entity.MealName;
			BusinessLayer._db.SaveChanges();
		}
	}
}