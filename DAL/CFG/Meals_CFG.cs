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
			builder.Property(x => x.MealName).HasColumnType("nvarchar");
			builder.ToTable("Meals");
			builder.HasMany(x=>x.UsersMeals).WithOne(x=>x.Meals).HasForeignKey(x=>x.MealID);
		}
	}
}