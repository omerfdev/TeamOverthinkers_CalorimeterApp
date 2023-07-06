using DAL.CFG;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Foods> FoodTable { get; set; }
        public DbSet<Categories> CategoryTable { get; set; }
        public DbSet<CategoryDetails> CategoryDetailsTable { get; set; }
        public DbSet<Meal> MealTable { get; set; }
        public DbSet<Users> UserTable { get; set; }
        public DbSet<UserDetails> UserDetailsTable { get; set; }
        public DbSet<User_Food_Meal> UserFoodMealTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=ALMALI\\OMERFDEV;Initial Catalog=CalorimeterDB;User ID=sa;pwd=Omer34;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Foods>(new Foods_CFG());
            modelBuilder.ApplyConfiguration<Categories>(new Categories_CFG());
            modelBuilder.ApplyConfiguration<CategoryDetails>(new Category_Details_CFG());
            modelBuilder.ApplyConfiguration<Meal>(new Meals_CFG());
            modelBuilder.ApplyConfiguration<User_Food_Meal>(new User_Food_Meal_CFG());


        }
    }
}