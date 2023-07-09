using Entities;

namespace BLL.BLL
{
    public class User_Food_Meal_BLL : ICRUD<User_Food_Meal>
    {
        public void Add(User_Food_Meal entity)
        {
            BusinessLayer._db.UserFoodMealTable.Add(entity);
            BusinessLayer._db.SaveChanges();
        }

        public void Delete(User_Food_Meal entity)
        {
            BusinessLayer._db.UserFoodMealTable.Remove(Search(entity.ID));
            BusinessLayer._db.SaveChanges();
        }

        public List<User_Food_Meal> GetAll()
        {
            return BusinessLayer._db.UserFoodMealTable.ToList();
        }

        public User_Food_Meal Search(int id)
        {
            return BusinessLayer._db.UserFoodMealTable.Find(id);
        }

        public void Update(User_Food_Meal entity)
        {
            User_Food_Meal user_Food_Meal = Search(entity.ID);
            BusinessLayer._db.Entry(user_Food_Meal).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            user_Food_Meal.FoodID = entity.FoodID;
            user_Food_Meal.MealID = entity.MealID;
            user_Food_Meal.Amount = entity.Amount;
            BusinessLayer._db.SaveChanges();
        }
    }
}