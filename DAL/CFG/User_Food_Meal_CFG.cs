using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CFG
{
	public class User_Food_Meal_CFG : IEntityTypeConfiguration<User_Food_Meal>
	{
		public void Configure(EntityTypeBuilder<User_Food_Meal> builder)
		{
			builder.HasKey(x=>new {x.UserID,x.FoodID,x.MealID});
			builder.ToTable("User Food Meals");
			builder.Ignore(x => x.ID);
				
		}
	}
}