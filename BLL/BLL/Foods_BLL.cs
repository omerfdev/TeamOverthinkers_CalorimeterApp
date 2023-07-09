using Entities;

namespace BLL.BLL
{
    public class Foods_BLL : ICRUD<Foods>
    {
        public void Add(Foods entity)
        {
            BusinessLayer._db.FoodTable.Add(entity);
            BusinessLayer._db.SaveChanges();
        }

        public void Delete(Foods entity)
        {
            BusinessLayer._db.FoodTable.Remove(Search(entity.ID));
            BusinessLayer._db.SaveChanges();
        }

        public List<Foods> GetAll()
        {
            return BusinessLayer._db.FoodTable.ToList();
        }

        public Foods Search(int id)
        {
            return BusinessLayer._db.FoodTable.Find(id);
        }

        public void Update(Foods entity)
        {
            Foods food = Search(entity.ID);
            BusinessLayer._db.Entry(food).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            food.FoodName = entity.FoodName;
            food.CategoryID = entity.CategoryID;
            food.CarbonHydrateValue = entity.CarbonHydrateValue;
            food.ProteinValue = entity.ProteinValue;
            food.FatValue = entity.FatValue;
            food.Calories = entity.Calories;
            food.FoodImagePath = entity.FoodImagePath;
            food.FoodDescription = entity.FoodDescription;
            BusinessLayer._db.SaveChanges();
        }
    }
}