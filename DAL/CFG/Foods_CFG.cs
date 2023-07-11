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
			builder.Property(x => x.FoodImagePath).HasColumnType("nvarchar(MAX)");
			builder.Property(x => x.FoodDescription).HasColumnType("nvarchar").HasMaxLength(150);
			builder.ToTable("Foods");
			builder.HasOne(x => x.Category).WithMany(x => x.Foods).HasForeignKey(x => x.CategoryID);
			builder.HasMany(x => x.UsersMeals).WithOne(x => x.Foods).HasForeignKey(x => x.FoodID);
			builder.HasData(
			   new Foods { ID = 1, FoodName = "Ayran", CategoryID = 1, CarbonHydrateValue = 2.7M, ProteinValue = 2M, FatValue = 2M, Calories = 37, FoodImagePath = "..\\..\\..\\Image\\Images\\beverages\\ayran.jpg", FoodDescription = "1 glass is 200 g" },
			   new Foods { ID = 2, FoodName = "Cappucino", CategoryID = 1, CarbonHydrateValue = 3.7M, ProteinValue = 2.3M, FatValue = 1.7M, Calories = 39, FoodImagePath = "..\\..\\..\\Image\\Images\\beverages\\cappucino.jpg", FoodDescription = "1 cup is 85 g" },
			   new Foods { ID = 3, FoodName = "Cola", CategoryID = 1, CarbonHydrateValue = 10.9M, ProteinValue = 0M, FatValue = 0M, Calories = 61, FoodImagePath = "..\\..\\..\\Image\\Images\\beverages\\cola.jpg", FoodDescription = "1 glass is 200 g" },
			   new Foods { ID = 4, FoodName = "Soda", CategoryID = 1, CarbonHydrateValue = 24M, ProteinValue = 0M, FatValue = 0M, Calories = 95, FoodImagePath = "..\\..\\..\\Image\\Images\\beverages\\soda.jpg", FoodDescription = "1 glass is 200 g" },
			   new Foods { ID = 5, FoodName = "Boiled Egg", CategoryID = 2, CarbonHydrateValue = 0M, ProteinValue = 12.1M, FatValue = 11.2M, Calories = 158, FoodImagePath = "..\\..\\..\\Image\\Images\\breakfastfoods\\boiledegg.jpg", FoodDescription = "1 piece is 60 g" },
			   new Foods { ID = 6, FoodName = "Honey", CategoryID = 2, CarbonHydrateValue = 78.4M, ProteinValue = 0.3M, FatValue = 0M, Calories = 315, FoodImagePath = "..\\..\\..\\Image\\Images\\breakfastfoods\\honey.jpg", FoodDescription = "1 teaspoon is 7 g" },
			   new Foods { ID = 7, FoodName = "Olive", CategoryID = 2, CarbonHydrateValue = 2M, ProteinValue = 1.8M, FatValue = 2M, Calories = 207, FoodImagePath = "..\\..\\..\\Image\\Images\\breakfastfoods\\olive.jpg", FoodDescription = "1 piece is 4 g" },
			   new Foods { ID = 8, FoodName = "Omelette", CategoryID = 2, CarbonHydrateValue = 2.3M, ProteinValue = 12.1M, FatValue = 14.4M, Calories = 184, FoodImagePath = "..\\..\\..\\Image\\Images\\breakfastfoods\\omelette.jpg", FoodDescription = "1 piece is 60 g" },
			   new Foods { ID = 9, FoodName = "Butter", CategoryID = 3, CarbonHydrateValue = 81.1M, ProteinValue = 0.9M, FatValue = 0.1M, Calories = 215, FoodImagePath = "..\\..\\..\\Image\\Images\\dairyproducts\\butter.jpg", FoodDescription = "1 teaspoon is 7 g" },
			   new Foods { ID = 10, FoodName = "Cheddar Cheese", CategoryID = 3, CarbonHydrateValue = 1.4M, ProteinValue = 27M, FatValue = 31.8M, Calories = 404, FoodImagePath = "..\\..\\..\\Image\\Images\\dairyproducts\\cheddarcheese.jpg", FoodDescription = "1 slice is 20 g" },
			   new Foods { ID = 11, FoodName = "Feta Cheese", CategoryID = 3, CarbonHydrateValue = 0M, ProteinValue = 22.5M, FatValue = 21.6M, Calories = 289, FoodImagePath = "..\\..\\..\\Image\\Images\\dairyproducts\\fetacheese.jpg", FoodDescription = "1 cube is 30 g" },
			   new Foods { ID = 12, FoodName = "Yogurt", CategoryID = 3, CarbonHydrateValue = 7M, ProteinValue = 5.3M, FatValue = 1.6M, Calories = 63, FoodImagePath = "..\\..\\..\\Image\\Images\\dairyproducts\\yogurt.jpg", FoodDescription = "1 cup is 180 g" },
			   new Foods { ID = 13, FoodName = "Baklava", CategoryID = 4, CarbonHydrateValue = 49.4M, ProteinValue = 7.7M, FatValue = 21.5M, Calories = 412, FoodImagePath = "..\\..\\..\\Image\\Images\\desserts\\baklava.jpg", FoodDescription = "1 slice is 40 g" },
			   new Foods { ID = 14, FoodName = "Cheesecake", CategoryID = 4, CarbonHydrateValue = 36.3M, ProteinValue = 4.8M, FatValue = 19.1M, Calories = 331, FoodImagePath = "..\\..\\..\\Image\\Images\\desserts\\cheesecake.jpg", FoodDescription = "1 slice is 125 g" },
			   new Foods { ID = 15, FoodName = "Donuts", CategoryID = 4, CarbonHydrateValue = 58.6M, ProteinValue = 10M, FatValue = 17.8M, Calories = 438, FoodImagePath = "..\\..\\..\\Image\\Images\\desserts\\donuts.jpg", FoodDescription = "1 piece is 85 g" },
			   new Foods { ID = 16, FoodName = "Souffle", CategoryID = 4, CarbonHydrateValue = 38.1M, ProteinValue = 7.3M, FatValue = 18.7M, Calories = 360, FoodImagePath = "..\\..\\..\\Image\\Images\\desserts\\souffle.jpg", FoodDescription = "1 piece is 95 g" },
			   new Foods { ID = 17, FoodName = "Hamburger", CategoryID = 5, CarbonHydrateValue = 19.9M, ProteinValue = 7M, FatValue = 6.1M, Calories = 165, FoodImagePath = "..\\..\\..\\Image\\Images\\fastfoods\\hamburger.jpg", FoodDescription = "1 piece is 190 g" },
			   new Foods { ID = 18, FoodName = "Hot Dog", CategoryID = 5, CarbonHydrateValue = 28M, ProteinValue = 8.3M, FatValue = 11.9M, Calories = 253, FoodImagePath = "..\\..\\..\\Image\\Images\\fastfoods\\hotdog.jpg", FoodDescription = "1 piece is 175 g" },
			   new Foods { ID = 19, FoodName = "Kokorec", CategoryID = 5, CarbonHydrateValue = 2.3M, ProteinValue = 15M, FatValue = 2.4M, Calories = 94, FoodImagePath = "..\\..\\..\\Image\\Images\\fastfoods\\kokorec.jpg", FoodDescription = "1 half loaf is 245 g" },
			   new Foods { ID = 20, FoodName = "Pizza", CategoryID = 5, CarbonHydrateValue = 30.5M, ProteinValue = 5.8M, FatValue = 4.3M, Calories = 186, FoodImagePath = "..\\..\\..\\Image\\Images\\fastfoods\\pizza.jpg", FoodDescription = "1 slice is 130 g" },
			   new Foods { ID = 21, FoodName = "Bulgur Pilaf", CategoryID = 6, CarbonHydrateValue = 18.2M, ProteinValue = 2.8M, FatValue = 3.4M, Calories = 114, FoodImagePath = "..\\..\\..\\Image\\Images\\grainfoods\\bulgurpilaf.jpg", FoodDescription = "1 portion is 130 g" },
			   new Foods { ID = 22, FoodName = "Corn Flakes", CategoryID = 6, CarbonHydrateValue = 84.1M, ProteinValue = 7.5M, FatValue = 0.4M, Calories = 357, FoodImagePath = "..\\..\\..\\Image\\Images\\grainfoods\\cornflakes.jpg", FoodDescription = "1 case is 50 g" },
			   new Foods { ID = 23, FoodName = "Rice", CategoryID = 6, CarbonHydrateValue = 24.8M, ProteinValue = 2.1M, FatValue = 5.8M, Calories = 162, FoodImagePath = "..\\..\\..\\Image\\Images\\grainfoods\\rice.jpg", FoodDescription = "1 portion is 170 g" },
			   new Foods { ID = 24, FoodName = "Rolled Oats", CategoryID = 6, CarbonHydrateValue = 11.7M, ProteinValue = 3.3M, FatValue = 1.8M, Calories = 77, FoodImagePath = "..\\..\\..\\Image\\Images\\grainfoods\\rolledoats.jpg", FoodDescription = "1 portion is 130 g" },
			   new Foods { ID = 25, FoodName = "Green Beans", CategoryID = 7, CarbonHydrateValue = 3.3M, ProteinValue = 2.6M, FatValue = 0.3M, Calories = 27, FoodImagePath = "..\\..\\..\\Image\\Images\\legumedishes\\greenbeans.jpg", FoodDescription = "1 portion is 130 g" },
			   new Foods { ID = 26, FoodName = "Green Pea", CategoryID = 7, CarbonHydrateValue = 14.4M, ProteinValue = 6.3M, FatValue = 0.4M, Calories = 84, FoodImagePath = "..\\..\\..\\Image\\Images\\legumedishes\\greenpea.jpg", FoodDescription = "1 portion is 180 g" },
			   new Foods { ID = 27, FoodName = "Haricot Bean", CategoryID = 7, CarbonHydrateValue = 29.4M, ProteinValue = 21.8M, FatValue = 1.4M, Calories = 281, FoodImagePath = "..\\..\\..\\Image\\Images\\legumedishes\\haricotbean.jpg", FoodDescription = "1 portion is 250 g" },
			   new Foods { ID = 28, FoodName = "Lentil Dish", CategoryID = 7, CarbonHydrateValue = 60.1M, ProteinValue = 24.7M, FatValue = 1.1M, Calories = 340, FoodImagePath = "..\\..\\..\\Image\\Images\\legumedishes\\lentildish.jpg", FoodDescription = "1 portion is 230 g" },
			   new Foods { ID = 29, FoodName = "Alinazik", CategoryID = 8, CarbonHydrateValue = 2.8M, ProteinValue = 5.2M, FatValue = 8M, Calories = 104, FoodImagePath = "..\\..\\..\\Image\\Images\\maincourses\\alinazik.jpg", FoodDescription = "1 portion is 416 g" },
			   new Foods { ID = 30, FoodName = "Beef Stroganoff", CategoryID = 8, CarbonHydrateValue = 3.5M, ProteinValue = 13.4M, FatValue = 9.2M, Calories = 152, FoodImagePath = "..\\..\\..\\Resources\\Images\\maincourses\\beefstroganoff.jpg", FoodDescription = "1 portion is 266 g" },
			   new Foods { ID = 31, FoodName = "Biryani", CategoryID = 8, CarbonHydrateValue = 26.5M, ProteinValue = 2.3M, FatValue = 10.2M, Calories = 198, FoodImagePath = "..\\..\\..\\Resources\\Images\\maincourses\\biryani.jpg", FoodDescription = "1 portion is 195 g" },
			   new Foods { ID = 32, FoodName = "İskender", CategoryID = 8, CarbonHydrateValue = 15.5M, ProteinValue = 9.7M, FatValue = 5.4M, Calories = 151, FoodImagePath = "..\\..\\..\\Resources\\Images\\maincourses\\iskender.jpg", FoodDescription = "1 portion is 500 g" },
			   new Foods { ID = 33, FoodName = "Beef", CategoryID = 9, CarbonHydrateValue = 5.6M, ProteinValue = 13.4M, FatValue = 11.6M, Calories = 183, FoodImagePath = "..\\..\\..\\Resources\\Images\\meatfoods\\beef.jpg", FoodDescription = "1 portion is 150 g" },
			   new Foods { ID = 34, FoodName = "Chicken", CategoryID = 9, CarbonHydrateValue = 0M, ProteinValue = 18.6M, FatValue = 15.1M, Calories = 215, FoodImagePath = "..\\..\\..\\Resources\\Images\\meatfoods\\chicken.jpg", FoodDescription = "1 portion is 170 g" },
			   new Foods { ID = 35, FoodName = "Kavurma", CategoryID = 9, CarbonHydrateValue = 0M, ProteinValue = 20.6M, FatValue = 28.5M, Calories = 345, FoodImagePath = "..\\..\\..\\Resources\\Images\\meatfoods\\kavurma.jpg", FoodDescription = "1 portion is 360 g" },
			   new Foods { ID = 36, FoodName = "Kuşbaşı", CategoryID = 9, CarbonHydrateValue = 2.6M, ProteinValue = 5.8M, FatValue = 7.6M, Calories = 137, FoodImagePath = "..\\..\\..\\Resources\\Images\\meatfoods\\kusbasi.jpg", FoodDescription = "1 portion is 237 g" },
			   new Foods { ID = 37, FoodName = "Almond", CategoryID = 10, CarbonHydrateValue = 19.8M, ProteinValue = 18.6M, FatValue = 54.2M, Calories = 600, FoodImagePath = "..\\..\\..\\Resources\\Images\\nuts\\almond.jpg", FoodDescription = "1 piece is 2 g" },
			   new Foods { ID = 38, FoodName = "Cashew", CategoryID = 10, CarbonHydrateValue = 32.7M, ProteinValue = 11.3M, FatValue = 46.4M, Calories = 574, FoodImagePath = "..\\..\\..\\Resources\\Images\\nuts\\cashew.jpg", FoodDescription = "1 piece is 4 g" },
			   new Foods { ID = 39, FoodName = "Hazelnut", CategoryID = 10, CarbonHydrateValue = 16.8M, ProteinValue = 12.6M, FatValue = 62.4M, Calories = 634, FoodImagePath = "..\\..\\..\\Resources\\Images\\nuts\\hazelnut.jpg", FoodDescription = "1 piece is 2 g" },
			   new Foods { ID = 40, FoodName = "Pumpkin Seeds", CategoryID = 10, CarbonHydrateValue = 10M, ProteinValue = 30.1M, FatValue = 50M, Calories = 610, FoodImagePath = "..\\..\\..\\Resources\\Images\\nuts\\pumpkinseeds.jpg", FoodDescription = "1 handful is 10 g" },
			   new Foods { ID = 41, FoodName = "Börek", CategoryID = 11, CarbonHydrateValue = 33.5M, ProteinValue = 10.1M, FatValue = 9.14M, Calories = 259, FoodImagePath = "..\\..\\..\\Resources\\Images\\pastryfoods\\borek.jpg", FoodDescription = "1 portion is 150 g" },
			   new Foods { ID = 42, FoodName = "Bread", CategoryID = 11, CarbonHydrateValue = 52.8M, ProteinValue = 8.1M, FatValue = 0.9M, Calories = 256, FoodImagePath = "..\\..\\..\\Resources\\Images\\pastryfoods\\bread.jpg", FoodDescription = "1 piece is 25 g" },
			   new Foods { ID = 43, FoodName = "Croissant", CategoryID = 11, CarbonHydrateValue = 42M, ProteinValue = 8.2M, FatValue = 7.4M, Calories = 271, FoodImagePath = "..\\..\\..\\Resources\\Images\\pastryfoods\\croissant.jpg", FoodDescription = "1 piece is 60 g" },
			   new Foods { ID = 44, FoodName = "Simit", CategoryID = 11, CarbonHydrateValue = 48.9M, ProteinValue = 2.3M, FatValue = 5.2M, Calories = 255, FoodImagePath = "..\\..\\..\\Resources\\Images\\pastryfoods\\simit.jpg", FoodDescription = "1 piece is 100 g" },
			   new Foods { ID = 45, FoodName = "Ceasar Salad", CategoryID = 12, CarbonHydrateValue = 6.6M, ProteinValue = 23.8M, FatValue = 5M, Calories = 128, FoodImagePath = "..\\..\\..\\Resources\\Images\\salads\\ceasarsalad.jpg", FoodDescription = "1 portion is 365 g" },
			   new Foods { ID = 46, FoodName = "Çoban Salad", CategoryID = 12, CarbonHydrateValue = 7.6M, ProteinValue = 1.5M, FatValue = 1.7M, Calories = 52, FoodImagePath = "..\\..\\..\\Resources\\Images\\salads\\cobansalad.jpg", FoodDescription = "1 portion is 220 g" },
			   new Foods { ID = 47, FoodName = "Cobb Salad", CategoryID = 12, CarbonHydrateValue = 2M, ProteinValue = 13.9M, FatValue = 13.8M, Calories = 188, FoodImagePath = "..\\..\\..\\Resources\\Images\\salads\\cobbsalad.jpg", FoodDescription = "1 portion is 173 g" },
			   new Foods { ID = 48, FoodName = "Gavurdağı Salad", CategoryID = 12, CarbonHydrateValue = 5M, ProteinValue = 1.9M, FatValue = 5M, Calories = 73, FoodImagePath = "..\\..\\..\\Resources\\Images\\salads\\gavurdagisalad.jpg", FoodDescription = "1 portion is 155 g" },
			   new Foods { ID = 49, FoodName = "Anchovy", CategoryID = 13, CarbonHydrateValue = 0M, ProteinValue = 17M, FatValue = 5M, Calories = 115, FoodImagePath = "..\\..\\..\\Resources\\Images\\seafoods\\anchovy.jpg", FoodDescription = "1 portion is 200 g" },
			   new Foods { ID = 50, FoodName = "Prawn", CategoryID = 13, CarbonHydrateValue = 0M, ProteinValue = 20.1M, FatValue = 0.5M, Calories = 85, FoodImagePath = "..\\..\\..\\Resources\\Images\\seafoods\\prawn.jpg", FoodDescription = "1 portion is 100 g" },
			   new Foods { ID = 51, FoodName = "Salmon", CategoryID = 13, CarbonHydrateValue = 0M, ProteinValue = 19.9M, FatValue = 10.4M, Calories = 179, FoodImagePath = "..\\..\\..\\Resources\\Images\\seafoods\\salmon.jpg", FoodDescription = "1 portion is 150 g" },
			   new Foods { ID = 52, FoodName = "Sushi", CategoryID = 13, CarbonHydrateValue = 7M, ProteinValue = 7.3M, FatValue = 6.7M, Calories = 113, FoodImagePath = "..\\..\\..\\Resources\\Images\\seafoods\\sushi.jpg", FoodDescription = "1 portion is 170 g" },
			   new Foods { ID = 53, FoodName = "Ezogelin Soup", CategoryID = 14, CarbonHydrateValue = 5.9M, ProteinValue = 1.9M, FatValue = 1.2M, Calories = 45, FoodImagePath = "..\\..\\..\\Resources\\Images\\soups\\ezogelinsoup.jpg", FoodDescription = "1 ladle is 150 g" },
			   new Foods { ID = 54, FoodName = "Fish Soup", CategoryID = 14, CarbonHydrateValue = 4.4M, ProteinValue = 4.5M, FatValue = 1.3M, Calories = 49, FoodImagePath = "..\\..\\..\\Resources\\Images\\soups\\fishsoup.jpg", FoodDescription = "1 ladle is 150 g" },
			   new Foods { ID = 55, FoodName = "Lentil Soup", CategoryID = 14, CarbonHydrateValue = 8.3M, ProteinValue = 2.5M, FatValue = 0.2M, Calories = 46, FoodImagePath = "..\\..\\..\\Resources\\Images\\soups\\lentilsoup.jpg", FoodDescription = "1 ladle is 150 g" },
			   new Foods { ID = 56, FoodName = "Tomato Soup", CategoryID = 14, CarbonHydrateValue = 4.4M, ProteinValue = 0.9M, FatValue = 1.1M, Calories = 32, FoodImagePath = "..\\..\\..\\Resources\\Images\\soups\\tomatosoup.jpg", FoodDescription = "1 ladle is 150 g" },
			   new Foods { ID = 57, FoodName = "Artichoke", CategoryID = 15, CarbonHydrateValue = 12M, ProteinValue = 2.9M, FatValue = 0.3M, Calories = 53, FoodImagePath = "..\\..\\..\\Resources\\Images\\vegetablefoods\\artichoke.jpg", FoodDescription = "1 portion is 100 g" },
			   new Foods { ID = 58, FoodName = "Mücver", CategoryID = 15, CarbonHydrateValue = 83M, ProteinValue = 3.7M, FatValue = 5M, Calories = 83, FoodImagePath = "..\\..\\..\\Resources\\Images\\vegetablefoods\\mucver.jpg", FoodDescription = "1 piece is 60 g" },
			   new Foods { ID = 59, FoodName = "Ratatouille", CategoryID = 15, CarbonHydrateValue = 4.4M, ProteinValue = 1.1M, FatValue = 0.7M, Calories = 27, FoodImagePath = "..\\..\\..\\Resources\\Images\\vegetablefoods\\ratatouille.jpg", FoodDescription = "1 portion is 480 g" },
			   new Foods { ID = 60, FoodName = "Spinach Meal", CategoryID = 15, CarbonHydrateValue = 5.7M, ProteinValue = 2.6M, FatValue = 4.6M, Calories = 76, FoodImagePath = "..\\..\\..\\Resources\\Images\\vegetablefoods\\spinachmeal.jpg", FoodDescription = "1 portion is 175 g" },
			   new Foods { ID = 61, FoodName = "Apple", CategoryID = 16, CarbonHydrateValue = 15M, ProteinValue = 0.2M, FatValue = 0.6M, Calories = 58, FoodImagePath = "..\\..\\..\\Resources\\Images\\vegetablesandfruits\\apple.jpg", FoodDescription = "1 piece is 90 g" },
			   new Foods { ID = 62, FoodName = "Avocado", CategoryID = 16, CarbonHydrateValue = 8.5M, ProteinValue = 2M, FatValue = 14.7M, Calories = 160, FoodImagePath = "..\\..\\..\\Resources\\Images\\vegetablesandfruits\\avocado.jpg", FoodDescription = "1 piece is 140 g" },
			   new Foods { ID = 63, FoodName = "Banana", CategoryID = 16, CarbonHydrateValue = 11.6M, ProteinValue = 1.1M, FatValue = 0.2M, Calories = 85, FoodImagePath = "..\\..\\..\\Resources\\Images\\vegetablesandfruits\\banana.jpg", FoodDescription = "1 piece is 170 g" },
			   new Foods { ID = 64, FoodName = "Carrot", CategoryID = 16, CarbonHydrateValue = 10M, ProteinValue = 0.1M, FatValue = 0.2M, Calories = 10, FoodImagePath = "..\\..\\..\\Resources\\Images\\vegetablesandfruits\\carrot.jpg", FoodDescription = "1 piece is 40 g" }
			   );
		}
	}
}