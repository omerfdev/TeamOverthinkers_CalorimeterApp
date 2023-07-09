using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CFG
{
	public class Meals_CFG : IEntityTypeConfiguration<Meal>
	{
		public void Configure(EntityTypeBuilder<Meal> builder)
		{
			builder.HasKey(x=>x.ID);
			builder.Property(x => x.MealName).HasColumnType("nvarchar").HasMaxLength(20);
			builder.ToTable("Meals");
			builder.HasMany(x=>x.UsersMeals).WithOne(x=>x.Meals).HasForeignKey(x=>x.MealID);
			builder.HasData(
			   new Meal { ID = 1, MealName = "Breakfast" },
			   new Meal { ID = 2, MealName = "Lunch" },
			   new Meal { ID = 3, MealName = "Dinner" },
			   new Meal { ID = 4, MealName = "Snack" }
			   );
		}
	}
}