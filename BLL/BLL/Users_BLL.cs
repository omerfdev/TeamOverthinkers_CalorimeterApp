using Entities;

namespace BLL.BLL
{
    public class Users_BLL : ICRUD<Users>
    {
        public void Add(Users entity)
        {
            BusinessLayer._db.UserTable.Add(entity);
            BusinessLayer._db.SaveChanges();
        }

        public void Delete(Users entity)
        {
            BusinessLayer._db.UserTable.Remove(Search(entity.ID));
            BusinessLayer._db.SaveChanges();
        }

        public List<Users> GetAll()
        {
            return BusinessLayer._db.UserTable.ToList();
        }

        public Users Search(int id)
        {
            return BusinessLayer._db.UserTable.Find(id);
        }

        public void Update(Users entity)
        {
            Users user = Search(entity.ID);
            BusinessLayer._db.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            user.FirstName = entity.FirstName;
            user.LastName = entity.LastName;
            user.Email = entity.Email;
            user.Password = entity.Password;
            user.IsAdmin = entity.IsAdmin;
            BusinessLayer._db.SaveChanges();
        }
    }
}