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
			   new Categories { ID = 1, CategoryName = "Beverages", ImagePath = "beverages", CategoryDescription = "..." },
			   new Categories { ID = 2, CategoryName = "Breakfast Foods", ImagePath = "breakfastfoods", CategoryDescription = "..." },
			   new Categories { ID = 3, CategoryName = "Dairy Products", ImagePath = "dairyproducts", CategoryDescription = "..." },
			   new Categories { ID = 4, CategoryName = "Desserts", ImagePath = "desserts", CategoryDescription = "..." },
			   new Categories { ID = 5, CategoryName = "Fast Foods", ImagePath = "fastfoods", CategoryDescription = "..." },
			   new Categories { ID = 6, CategoryName = "Grain Foods", ImagePath = "grainfoods", CategoryDescription = "..." },
			   new Categories { ID = 7, CategoryName = "Legume Dishes", ImagePath = "legumedishes", CategoryDescription = "..." },
			   new Categories { ID = 8, CategoryName = "Main Courses", ImagePath = "maincourses", CategoryDescription = "..." },
			   new Categories { ID = 9, CategoryName = "Meat Foods", ImagePath = "meatfoods", CategoryDescription = "..." },
			   new Categories { ID = 10, CategoryName = "Nuts", ImagePath = "nuts", CategoryDescription = "..." },
			   new Categories { ID = 11, CategoryName = "Pastry Foods", ImagePath = "pastryfoods", CategoryDescription = "..." },
			   new Categories { ID = 12, CategoryName = "Salads", ImagePath = "salads", CategoryDescription = "..." },
			   new Categories { ID = 13, CategoryName = "Sea Foods", ImagePath = "seafoods", CategoryDescription = "..." },
			   new Categories { ID = 14, CategoryName = "Soups", ImagePath = "soups", CategoryDescription = "..." },
			   new Categories { ID = 15, CategoryName = "Vegetable Foods", ImagePath = "vegetablefoods", CategoryDescription = "..." },
			   new Categories { ID = 16, CategoryName = "Vegetables&fruits", ImagePath = "vegetablesandfruits", CategoryDescription = "..." }
				   );

		}

    }
}