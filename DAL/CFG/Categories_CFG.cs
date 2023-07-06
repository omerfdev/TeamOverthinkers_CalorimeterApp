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
            builder.HasData(
                new Categories { CategoryName = "Meyve" });
        }

    }
}