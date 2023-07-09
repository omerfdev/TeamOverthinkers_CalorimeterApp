using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CFG
{
	internal class Category_Details_CFG : IEntityTypeConfiguration<CategoryDetails>
	{
		public void Configure(EntityTypeBuilder<CategoryDetails> builder)
		{
			builder.HasKey(x=> x.ID);	
			builder.ToTable("Category Details");
			builder.Property(x=>x.CategoryID).HasColumnType("int");
			builder.Property(x=>x.IsActive).HasColumnType("bit");   
			builder.Property(x=>x.IsGlutenFree).HasColumnType("bit");   
			builder.Property(x=>x.IsVegaterian).HasColumnType("bit");   
			builder.Property(x=>x.IsAllergen).HasColumnType("bit");

			builder.HasData(
				new CategoryDetails { ID = 1, CategoryID = 1, IsAllergen = false, IsGlutenFree = false, HasLactose = false, IsVegaterian = true },
				new CategoryDetails { ID = 2, CategoryID = 2, IsAllergen = true, IsGlutenFree = false, HasLactose = true, IsVegaterian = true },
				new CategoryDetails { ID = 3, CategoryID = 3, IsAllergen = true, IsGlutenFree = false, HasLactose = true, IsVegaterian = true },
				new CategoryDetails { ID = 4, CategoryID = 4, IsAllergen = false, IsGlutenFree = false, HasLactose = true, IsVegaterian = true },
				new CategoryDetails { ID = 5, CategoryID = 5, IsAllergen = false, IsGlutenFree = true, HasLactose = false, IsVegaterian = false },
				new CategoryDetails { ID = 6, CategoryID = 6, IsAllergen = true, IsGlutenFree = true, HasLactose = false, IsVegaterian = true },
				new CategoryDetails { ID = 7, CategoryID = 7, IsAllergen = false, IsGlutenFree = false, HasLactose = false, IsVegaterian = true },
				new CategoryDetails { ID = 8, CategoryID = 8, IsAllergen = false, IsGlutenFree = false, HasLactose = false, IsVegaterian = false },
				new CategoryDetails { ID = 9, CategoryID = 9, IsAllergen = false, IsGlutenFree = false, HasLactose = false, IsVegaterian = false },
				new CategoryDetails { ID = 10, CategoryID = 10, IsAllergen = true, IsGlutenFree = false, HasLactose = false, IsVegaterian = true },
				new CategoryDetails { ID = 11, CategoryID = 11, IsAllergen = false, IsGlutenFree = true, HasLactose = true, IsVegaterian = true },
				new CategoryDetails { ID = 12, CategoryID = 12, IsAllergen = false, IsGlutenFree = false, HasLactose = false, IsVegaterian = true },
				new CategoryDetails { ID = 13, CategoryID = 13, IsAllergen = true, IsGlutenFree = false, HasLactose = false, IsVegaterian = false },
				new CategoryDetails { ID = 14, CategoryID = 14, IsAllergen = false, IsGlutenFree = true, HasLactose = false, IsVegaterian = true },
				new CategoryDetails { ID = 15, CategoryID = 15, IsAllergen = false, IsGlutenFree = false, HasLactose = false, IsVegaterian = true },
				new CategoryDetails { ID = 16, CategoryID = 16, IsAllergen = false, IsGlutenFree = false, HasLactose = false, IsVegaterian = true }
				);
		}
	}
}