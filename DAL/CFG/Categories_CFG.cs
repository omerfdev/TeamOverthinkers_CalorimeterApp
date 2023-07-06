using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.CFG
{
    public class Categories_CFG : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CategoryName).IsRequired();
            builder.Property(x => x.ImagePath).HasColumnType("nvarchar").HasMaxLength(150); 
            builder.Property(x => x.CategoryDescription).HasColumnType("nvarchar").HasMaxLength(150); 
			builder.ToTable("Categories");
			builder.HasOne(x => x.CategoryDetails).WithOne(x => x.Categories).HasForeignKey<CategoryDetails>(x=>x.CategoryID);
			
			builder.HasData(
                new Categories { CategoryName = "Meyve" });
        }

    }
}