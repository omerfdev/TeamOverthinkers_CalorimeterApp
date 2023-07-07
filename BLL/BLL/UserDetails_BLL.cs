using Entities;

namespace BLL.BLL
{
    public class UserDetails_BLL : ICRUD<UserDetails>
    {
        public void Add(UserDetails entity)
        {
            BusinessLayer._db.UserDetailsTable.Add(entity);
            BusinessLayer._db.SaveChanges();
        }

        public void Delete(UserDetails entity)
        {
            BusinessLayer._db.UserDetailsTable.Remove(Search(entity.ID));
            BusinessLayer._db.SaveChanges();
        }

        public List<UserDetails> GetAll()
        {
            return BusinessLayer._db.UserDetailsTable.ToList();
        }

        public UserDetails Search(int id)
        {
            return BusinessLayer._db.UserDetailsTable.Find(id);
        }

        public void Update(UserDetails entity)
        {
            UserDetails userDetail = Search(entity.ID);

            BusinessLayer._db.Entry(userDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            // userDetail.UserID = entity.ID;
            userDetail.Phone = entity.Phone;
            userDetail.BirthDate = entity.BirthDate;
            userDetail.Height = entity.Height;
            userDetail.Weight = entity.Weight;
            userDetail.Gender = entity.Gender;
            userDetail.IsAllergic = entity.IsAllergic;
            userDetail.GlutenPreference = entity.GlutenPreference;
            userDetail.IsLactoseIntolerant = entity.IsLactoseIntolerant;
            userDetail.IsVegetarian = entity.IsVegetarian;

            BusinessLayer._db.SaveChanges();
        }
    }
}