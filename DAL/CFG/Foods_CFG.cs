using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace DAL.CFG
{
    internal class Foods_CFG : IEntityTypeConfiguration<Foods>
    {
        public void Configure(EntityTypeBuilder<Foods> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.FoodName).IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            builder.Property(x => x.CarbonHydrateValue).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.ProteinValue).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.FatValue).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.Calories).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.FoodImagePath).HasColumnType("nvarchar");
            builder.Property(x => x.FoodDescription).HasColumnType("nvarchar").HasMaxLength(150);
            builder.ToTable("Foods");
            builder.HasOne(x => x.Category).WithMany(x => x.Foods).HasForeignKey(x => x.CategoryID);
            builder.HasMany(x => x.UsersMeals).WithOne(x=>x.Foods).HasForeignKey(x=>x.FoodID);
            builder.HasData(
                new Foods { FoodName = "Elma", CarbonHydrateValue = 8.9M, FatValue = 4.5M, ProteinValue = 3.7M, Calories = 52M, CategoryID = 1 },
                new Foods { FoodName = "Muz", CarbonHydrateValue = 8.9M, FatValue = 4.5M, ProteinValue = 3.7M, Calories = 52M, CategoryID = 1 }




                );
        }
    }
}