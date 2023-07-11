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
			   new Categories { ID = 1, CategoryName = "Beverages", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\beverages.jpg", CategoryDescription = "..." },
			   new Categories { ID = 2, CategoryName = "Breakfast Foods", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\breakfastfoods.jpg", CategoryDescription = "..." },
			   new Categories { ID = 3, CategoryName = "Dairy Products", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\dairyproducts.jpg", CategoryDescription = "..." },
			   new Categories { ID = 4, CategoryName = "Desserts", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\desserts.jpg", CategoryDescription = "..." },
			   new Categories { ID = 5, CategoryName = "Fast Foods", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\fastfoods.jpg", CategoryDescription = "..." },
			   new Categories { ID = 6, CategoryName = "Grain Foods", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\grainfoods.jpg", CategoryDescription = "..." },
			   new Categories { ID = 7, CategoryName = "Legume Dishes", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\legumedishes.jpg", CategoryDescription = "..." },
			   new Categories { ID = 8, CategoryName = "Main Courses", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\maincourses.jpg", CategoryDescription = "..." },
			   new Categories { ID = 9, CategoryName = "Meat Foods", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\meatfoods.jpg", CategoryDescription = "..." },
			   new Categories { ID = 10, CategoryName = "Nuts", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\nuts.jpg", CategoryDescription = "..." },
			   new Categories { ID = 11, CategoryName = "Pastry Foods", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\pastryfoods.jpg", CategoryDescription = "..." },
			   new Categories { ID = 12, CategoryName = "Salads", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\salads.jpg", CategoryDescription = "..." },
			   new Categories { ID = 13, CategoryName = "Sea Foods", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\seafoods.jpg", CategoryDescription = "..." },
			   new Categories { ID = 14, CategoryName = "Soups", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\soups.jpg", CategoryDescription = "..." },
			   new Categories { ID = 15, CategoryName = "Vegetable Foods", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\vegetablefoods.jpg", CategoryDescription = "..." },
			   new Categories { ID = 16, CategoryName = "Vegetables&fruits", ImagePath = "..\\..\\..\\Image\\Images\\catagories\\vegetablesandfruits.jpg", CategoryDescription = "..." }
				   );

		}

    }
}