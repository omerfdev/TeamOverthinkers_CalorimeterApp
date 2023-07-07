using Entities;

namespace BLL.BLL
{
	public class Categories_BLL : ICRUD<Categories>
	{
		public void Add(Categories entity)
		{
			BusinessLayer._db.CategoryTable.Add(entity);
			BusinessLayer._db.SaveChanges();
		}

		public void Delete(Categories entity)
		{
			BusinessLayer._db.CategoryTable.Remove(Search(entity.ID));
			BusinessLayer._db.SaveChanges();
		}

		public List<Categories> GetAll()
		{
			return BusinessLayer._db.CategoryTable.ToList();
		}

		public Categories Search(int id)
		{
			return BusinessLayer._db.CategoryTable.Find(id);
		}

		public void Update(Categories entity)
		{
			Categories category = Search(entity.ID);

			BusinessLayer._db.Entry<Categories>(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			category.CategoryName = entity.CategoryName;
			category.CategoryDescription = entity.CategoryDescription;
			category.CategoryDetails = entity.CategoryDetails;
			category.ImagePath = entity.ImagePath;

			BusinessLayer._db.SaveChanges();
		}
	}
}