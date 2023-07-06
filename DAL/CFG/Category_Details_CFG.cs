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

			builder.HasData(new CategoryDetails {ID=1, CategoryID = 1, });
		}
	}
}