using Entities;

namespace BLL.BLL
{
	public class CategoryDetails_BLL : ICRUD<CategoryDetails>
	{
		public void Add(CategoryDetails entity)
		{
			BusinessLayer._db.CategoryDetailsTable.Add(entity);
			BusinessLayer._db.SaveChanges();
		}

		public void Delete(CategoryDetails entity)
		{
			BusinessLayer._db.CategoryDetailsTable.Remove(Search(entity.ID));
			BusinessLayer._db.SaveChanges();
		}

		public List<CategoryDetails> GetAll()
		{
			return BusinessLayer._db.CategoryDetailsTable.ToList();
		}

		public CategoryDetails Search(int id)
		{
			return BusinessLayer._db.CategoryDetailsTable.Find(id);
		}

		public void Update(CategoryDetails entity)
		{
			CategoryDetails categoryDetail = Search(entity.ID);
			BusinessLayer._db.Entry<CategoryDetails>(categoryDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			categoryDetail.IsAllergen = entity.IsAllergen;
			categoryDetail.IsGlutenFree = entity.IsGlutenFree;
			categoryDetail.HasLactose = entity.HasLactose;
			categoryDetail.IsVegaterian = entity.IsVegaterian;
			BusinessLayer._db.SaveChanges();
		}
	}
}